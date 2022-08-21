using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Page;
using Microsoft.Fast.Components.FluentUI;

namespace FluentBlog.Service.Page
{
    public class PageDataProvider
    {
        public const string Home = "Home";

        public const string Tags = "Tags";

        public const string Category = "Category";

        public static Dictionary<string, PageData> Datas => new()
        {
            {Home, new PageData("Home", FluentIcons.Home, "/", true) },
            {Tags, new PageData("Tags", FluentIcons.Tag, "/tags", false) },
            {Category, new PageData("Category", FluentIcons.Folder, "/category", false) }
        };
    }
}
