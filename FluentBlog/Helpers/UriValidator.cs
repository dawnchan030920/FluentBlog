using FluentBlog.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace FluentBlog.Helpers
{
    public class UriValidator
    {
		private NavigationManager navigationManager;

		public UriValidator(NavigationManager navigationManager)
        {
			this.navigationManager = navigationManager;
        }

        public bool IsActive(MenuItem item)
        {
			var href = item?.Url;
			var match = item?.Match;
			bool flag = false;
			if (href is not null)
			{
				var relative = $"/{navigationManager.ToBaseRelativePath(navigationManager.Uri).ToLower()}";
				flag = match == NavLinkMatch.All ? relative == href.ToLower() : relative.StartsWith(href.ToLower());
			}
			return flag;
		}
    }
}
