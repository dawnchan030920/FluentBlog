using Microsoft.AspNetCore.Components.Routing;

namespace FluentBlog.Model
{
    public class MenuItem
    {
        public string Tag { get; set; } = string.Empty;

        public string Icon { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public NavLinkMatch Match { get; set; }

        public bool IsHome { get; set; }
    }
}