using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;
using FluentBlog.Store.ArticleOverviewCriteria.Action;

namespace FluentBlog.Store.ArticleOverviewCriteria
{
	public static class ArticleOverviewCriteriaReducer
	{
		[ReducerMethod]
		public static ArticleOverviewCriteriaState OnArticleOverviewCriteriaSet(ArticleOverviewCriteriaState state, ArticleOverviewCriteriaSetAction action)
		{
			return state with
			{
				CategoryChain = action.CategoryChain,
				Series = action.Series,
				Tags = action.Tags,
				From = action.From,
				To = action.To
			};
		}
	}
}
