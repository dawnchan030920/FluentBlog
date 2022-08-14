using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Theme;

namespace FluentBlog.Store.Theme
{
    public record ThemeState
    {
        public LightDarkTheme LightDarkTheme { get; init; }
    }
}
