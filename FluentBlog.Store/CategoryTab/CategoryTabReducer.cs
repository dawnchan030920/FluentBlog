using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;
using FluentBlog.Store.CategoryTab.Action;

namespace FluentBlog.Store.CategoryTab
{
	public static class CategoryTabReducer
	{
		[ReducerMethod]
		public static CategoryTabState OnCategoryTabSet(CategoryTabState state, CategoryTabSetAction action)
		{
			return state with
			{
				TabActiveId = action.TabActiveId
			};
		}

		[ReducerMethod]
		public static CategoryTabState OnCategoryTabSetByForce(CategoryTabState state, CategoryTabSetByForceAction action)
		{
			return state with
			{
				TabActiveId = action.TabActiveId,
				ByForce = true
			};
		}
	}
}
