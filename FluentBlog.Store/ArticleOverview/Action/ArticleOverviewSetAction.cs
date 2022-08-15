using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;

namespace FluentBlog.Store.ArticleOverview.Action
{
	public class ArticleOverviewSetAction
	{
		public List<ArticleOverviewData>? ArticleOverviews { get; set; }

		public ArticleOverviewSetAction(List<ArticleOverviewData>? articleOverviews)
		{
			ArticleOverviews = articleOverviews;
		}
	}
}
