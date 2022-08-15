using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.ArticleOverviewCriteria
{
	public record ArticleOverviewCriteriaState
	{
		public List<string>? CategoryChain { get; set; }
		
		public List<string>? Tags { get; set; }

		public DateTime? From { get; set; }

		public DateTime? To { get; set; }
	}
}
