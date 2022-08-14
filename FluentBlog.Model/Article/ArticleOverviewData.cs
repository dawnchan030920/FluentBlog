using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Model.Article
{
	public class ArticleOverviewData
	{
		public string Url { get; set; }

		public RenderFragment Title { get; set; }

		public RenderFragment Description { get; set; }

		public List<string> CategoryChain { get; set; }

		public List<string> Tags { get; set; }

		public DateTime EditTime { get; set; }

		public string Image { get; set; }

		public ArticleOverviewData(string url, RenderFragment title, RenderFragment description, List<string> categoryChain, List<string> tags, DateTime editTime, string image)
		{
			Url = url;
			Title = title;
			Description = description;
			CategoryChain = categoryChain;
			Tags = tags;
			EditTime = editTime;
			Image = image;
		}
	}
}
