using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;

namespace FluentBlog.Store.ArticleOverview
{
	public record ArticleOverviewState
	{
		public List<ArticleOverviewData>? ArticleOverviews { get; set; }
	}
}
