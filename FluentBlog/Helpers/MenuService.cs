using FluentBlog.Model;
using System.Net.Http.Json;

namespace FluentBlog.Helpers
{
    public class MenuService
    {
        private HttpClient client;
        private IHttpClientFactory httpClientFactory;

        private IConfiguration configuration;

        public MenuService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.httpClientFactory = httpClientFactory;
            this.configuration = configuration;
            client = this.httpClientFactory.CreateClient("MenuAPI");
        }

        public async Task<List<MenuItem>?> GetMenuItemsAsync()
        {
            return await client.GetFromJsonAsync<List<MenuItem>>(configuration["menuConfigPath"]);
        }
    }
}
