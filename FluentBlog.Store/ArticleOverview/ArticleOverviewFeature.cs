using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;
using FluentBlog.Service.Article;
using Fluxor;

namespace FluentBlog.Store.ArticleOverview
{
	public class ArticleOverviewFeature : Feature<ArticleOverviewState>
	{
		public override string GetName() => "ArticleOverview";

		protected override ArticleOverviewState GetInitialState()
		{
			return new ArticleOverviewState()
			{
				ArticleOverviews = ArticleOverviewService.ArticleOverviews
			};
		}
	}
}
