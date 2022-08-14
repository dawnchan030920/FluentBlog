using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Model.Page
{
	public class SubPageData
	{
		public string Title { get; set; }

		public string Url { get; set; }

		public SubPageData(string title, string url)
		{
			Title = title;
			Url = url;
		}
	}
}
