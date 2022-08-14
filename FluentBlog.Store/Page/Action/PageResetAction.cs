using FluentBlog.Model.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.Page.Action
{
	public class PageResetAction
	{
		public PageData Page { get; set; }

		public PageResetAction(PageData page)
		{
			Page = page;
		}
	}
}
