using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;
using FluentBlog.Store.ArticleOverviewCriteria.Action;
using FluentBlog.Store.ArticleOverviewCriteria;
using FluentBlog.Store.ArticleOverview.Action;
using FluentBlog.Service.Article;
using FluentBlog.Model.Article;

namespace FluentBlog.Store.ArticleOverview
{
	public class ArticleOverviewEffect
	{
        private IState<ArticleOverviewCriteriaState> criteriaState;

		public ArticleOverviewEffect(IState<ArticleOverviewCriteriaState> criteriaState)
		{
			this.criteriaState = criteriaState;
		}

		[EffectMethod(typeof(ArticleOverviewCriteriaSetAction))]
		public Task UpdateOverviews(IDispatcher dispatcher)
		{
			var overviews = ArticleService.ArticleOverviews;
			IEnumerable<ArticleOverviewData>? query = overviews;
            if (overviews is not null)
			{
				if (criteriaState.Value.Tags is not null)
				{
					query = from overview in overviews
							where overview.Tags is not null && criteriaState.Value.Tags.All(crit => overview.Tags.Contains(crit))
							select overview;
					overviews = query.ToList();
				}
				if (criteriaState.Value.From is not null)
				{
					query = from overview in overviews
							where overview.EditTime >= criteriaState.Value.From
							orderby overview.EditTime
							select overview;
					overviews = query.ToList();
				}
				if (criteriaState.Value.To is not null)
				{
					query = from overview in overviews
							where overview.EditTime <= criteriaState.Value.To
							orderby overview.EditTime
							select overview;
					overviews = query.ToList();
				}
				if (criteriaState.Value.CategoryChain is not null)
				{
					query = from overview in overviews
							where ContainsCommonSubList(overview.CategoryChain, criteriaState.Value.CategoryChain)
							select overview;
					overviews.AsQueryable().ToList();
				}
				if (criteriaState.Value.Series is not null)
				{
					query = from overview in overviews
							where overview.Series?.Series is not null && overview.Series.Series.Equals(criteriaState.Value.Series)
							orderby overview.Series?.Number
							select overview;
				}

                dispatcher.Dispatch(new ArticleOverviewSetAction(query?.ToList()));
            }
			else dispatcher.Dispatch(new ArticleOverviewSetAction(null));
			return Task.CompletedTask;
		}

		private bool ContainsCommonSubList<T>(List<T>? super, List<T> sub)
        {
			if (super is null) return false;
            for (int i = 0; i <= super.Count - sub.Count; i++)
            {
				if (super.Skip(i).Take(sub.Count).SequenceEqual(sub)) return true;
            }
			return false;
        }
    }
}
