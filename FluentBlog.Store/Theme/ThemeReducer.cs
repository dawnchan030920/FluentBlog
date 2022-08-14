using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Store.Theme.Action;
using Fluxor;

namespace FluentBlog.Store.Theme
{
	public static class ThemeReducer
	{
		[ReducerMethod(typeof(ThemeLightDarkChangeAction))]
		public static ThemeState OnThemeLightDarkChange(ThemeState state)
		{
			return state with
			{
				LightDarkTheme = state.LightDarkTheme == Model.Theme.LightDarkTheme.Light ? Model.Theme.LightDarkTheme.Dark : Model.Theme.LightDarkTheme.Light
			};
		}
	}
}
