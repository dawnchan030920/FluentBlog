using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Service.Category;
using Fluxor;

namespace FluentBlog.Store.CategoryTab
{
	public class CategoryTabFeature : Feature<CategoryTabState>
	{
		public override string GetName() => "CategoryTab";

		protected override CategoryTabState GetInitialState()
		{
			return new CategoryTabState
			{
				TabActiveId = CategoryTabProvider.CategoryPanelId,
				ByForce = false
			};
		}
	}
}
