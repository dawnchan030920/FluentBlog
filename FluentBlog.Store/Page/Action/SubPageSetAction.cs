using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Page;

namespace FluentBlog.Store.Page.Action
{
	public class SubPageSetAction
	{
		public List<SubPageData> Datas { get; set; }

		public SubPageSetAction(List<SubPageData> datas)
		{
			Datas = datas;
		}
	}
}
