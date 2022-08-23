using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.CategoryTab.Action
{
	public class CategoryTabSetAction
	{
		public string TabActiveId { get; set; }

		public CategoryTabSetAction(string tabActiveId)
		{
			TabActiveId = tabActiveId;
		}
	}
}
