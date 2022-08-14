using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;

namespace FluentBlog.Store.Theme
{
	public class ThemeFeature : Feature<ThemeState>
	{
		public override string GetName() => "Theme";

		protected override ThemeState GetInitialState()
		{
			return new ThemeState()
			{
				LightDarkTheme = Model.Theme.LightDarkTheme.Light
			};
		}
	}
}
