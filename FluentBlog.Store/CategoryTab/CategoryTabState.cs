using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.CategoryTab
{
	public record CategoryTabState
	{
		public bool ByForce { get; set; }

		public string? TabActiveId { get; init; }
	}
}
