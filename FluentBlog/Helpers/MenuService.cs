using FluentBlog.Model;
using System.Net.Http.Json;

namespace FluentBlog.Helpers
{
    public class MenuService
    {
        private HttpClient client;

        public MenuService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<MenuItem>> GetMenuItemsAsync()
        {
            return await client.GetFromJsonAsync<List<MenuItem>>("data/menu.json");
        }
    }
}
