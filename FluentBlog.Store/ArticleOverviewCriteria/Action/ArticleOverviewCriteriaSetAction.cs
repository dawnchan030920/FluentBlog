using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.ArticleOverviewCriteria.Action
{
	public class ArticleOverviewCriteriaSetAction
	{
		public List<string>? CategoryChain { get; set; }

        public List<string>? Tags { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public ArticleOverviewCriteriaSetAction(List<string>? categoryChain, List<string>? tags, DateTime? from, DateTime? to)
        {
            CategoryChain = categoryChain;
            Tags = tags;
            From = from;
            To = to;
        }
    }
}
