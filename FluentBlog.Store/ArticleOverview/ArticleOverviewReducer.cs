using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Store.ArticleOverview.Action;
using Fluxor;

namespace FluentBlog.Store.ArticleOverview
{
	public static class ArticleOverviewReducer
	{
		[ReducerMethod]
		public static ArticleOverviewState OnArticleOverviewSet(ArticleOverviewState state, ArticleOverviewSetAction action)
		{
			return state with
			{
				ArticleOverviews = action.ArticleOverviews
			};
		}
	}
}
