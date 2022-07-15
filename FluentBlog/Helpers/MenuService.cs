using FluentBlog.Model;
using System.Net.Http.Json;

namespace FluentBlog.Helpers
{
    public class MenuService
    {
        private HttpClient client;

        private IConfiguration configuration;

        public MenuService(HttpClient client, IConfiguration configuration)
        {
            this.client = client;
            this.configuration = configuration;
        }

        public async Task<List<MenuItem>> GetMenuItemsAsync()
        {
            return await client.GetFromJsonAsync<List<MenuItem>>(configuration["menuConfigPath"]);
        }
    }
}
