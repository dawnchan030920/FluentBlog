using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Theme;

namespace FluentBlog.Service.Theme
{
	public class ThemeDefaultLightDarkService
	{
		public static Dictionary<LightDarkTheme, float> DefaultLightDarkLuminance { get; } = new Dictionary<LightDarkTheme, float>()
		{
			{LightDarkTheme.Light, 1f },
			{LightDarkTheme.Dark, 0.15f },
		};
	}
}
