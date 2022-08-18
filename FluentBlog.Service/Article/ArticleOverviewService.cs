using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;

namespace FluentBlog.Service.Article
{
	public class ArticleOverviewService
	{
		public static List<ArticleOverviewData>? ArticleOverviews
		{
			get => new List<ArticleOverviewData>()
			{
				new ArticleOverviewData("/nouse","Test Article","test article", new List<string>(){ "Test","Service"},new List<string>(){"blazor","web"},DateTime.Now,"_content/FluentBlog.Asset/icon-192.png",new ArticleSeries("fb test",1,null))
			};
		}
	}
}
