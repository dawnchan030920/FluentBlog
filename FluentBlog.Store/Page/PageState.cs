using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Page;

namespace FluentBlog.Store.Page
{
	public record PageState
	{
		public PageData? CurrentPage { get; init; }

		public List<SubPageData>? CurrentSubPages { get; init; }

		public bool IsHomeOrUndefined => (CurrentPage is not null && CurrentPage.IsHome) || CurrentPage is null;
	}
}
