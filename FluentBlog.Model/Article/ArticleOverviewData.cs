﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Model.Article
{
	public class ArticleOverviewData
	{
		public string Article { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public List<string> CategoryChain { get; set; }

		public List<string> Tags { get; set; }

		public DateTime EditTime { get; set; }

		public string Image { get; set; }

		public ArticleOverviewData(string article, string title, string description, List<string> categoryChain, List<string> tags, DateTime editTime, string image)
		{
			Article = article;
			Title = title;
			Description = description;
			CategoryChain = categoryChain;
			Tags = tags;
			EditTime = editTime;
			Image = image;
		}
	}
}