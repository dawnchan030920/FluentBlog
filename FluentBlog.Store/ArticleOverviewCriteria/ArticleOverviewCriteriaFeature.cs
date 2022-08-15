using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;

namespace FluentBlog.Store.ArticleOverviewCriteria
{
	public class ArticleOverviewCriteriaFeature : Feature<ArticleOverviewCriteriaState>
	{
		public override string GetName() => "ArticleOverviewCriteria";

		protected override ArticleOverviewCriteriaState GetInitialState()
		{
			return new ArticleOverviewCriteriaState();
		}
	}
}
