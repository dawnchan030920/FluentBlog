using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.ArticleOverviewCriteria
{
	public record ArticleOverviewCriteriaState
	{
		public List<string>? CategoryChain { get; init; }

		public string? Series { get; init; }
		
		public List<string>? Tags { get; init; }

		public DateTime? From { get; init; }

		public DateTime? To { get; init; }
	}
}
