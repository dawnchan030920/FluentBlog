using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Page;

namespace FluentBlog.Store.Page.Action
{
	public class MainSubPageSetAction
	{
		public PageData Page { get; set; }

		public List<SubPageData> SubPages { get; set; }

		public MainSubPageSetAction(PageData page, List<SubPageData> subPages)
		{
			Page = page;
			SubPages = subPages;
		}
	}
}
