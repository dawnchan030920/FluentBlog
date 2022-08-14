using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;

namespace FluentBlog.Store.Page
{
	public class PageFeature : Feature<PageState>
	{
		public override string GetName() => "Page";

		protected override PageState GetInitialState()
		{
			return new PageState()
			{
				CurrentPage = null
			};
		}
	}
}
