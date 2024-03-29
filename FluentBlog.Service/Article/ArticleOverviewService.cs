﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;

namespace FluentBlog.Service.Article
{
	public class ArticleService
	{
		public static List<ArticleOverviewData>? ArticleOverviews
		{
			get => new List<ArticleOverviewData>()
			{
				new ArticleOverviewData("/nouse","Test Article","test article", new List<string>(){ "Test","Service"},new List<string>(){"blazor","web"},DateTime.Now,"_content/FluentBlog.Asset/icon-192.png",new ArticleSeries("fb test",1,null)),
				new ArticleOverviewData("/nouse2","Test Article 2 at Night", "This is a new test article overview to figure out the wrong thing happening.", new List<string>(){"Test","Service"},new List<string>(){ "blazor","test"},DateTime.Now,"_content/FluentBlog.Asset/icon-192.png",new ArticleSeries("fb test",2,null)),
				new ArticleOverviewData("/nouse3","Test Article 3","This is the third test article",new List<string>(){ "Test","Otheror","Deeper"},new List<string>(){ "blazor"},DateTime.Now,"_content/FluentBlog.Asset/icon-192.png",new ArticleSeries("fb test",3,null)),
				new ArticleOverviewData("/nouse4","Test Article 4","This is the fourth article to test whether forced tab trasmission is possible.",new List<string>(){ "Test"},new List<string>(){"blazor"},DateTime.Now,"_content/FluentBlog.Asset/icon-192.png",new ArticleSeries("fb test",4,null)),
				new ArticleOverviewData("/nouse5","Test Article 5","This article is to see what on earth does the scrollbox in tabpanel look like.",new List<string>(){"Test","Service"},new List<string>(){ "blazor","test"},DateTime.Now,"_content/FluentBlog.Asset/icon-192/png",new ArticleSeries("fb test",5,null))
			};
		}
	}
}
