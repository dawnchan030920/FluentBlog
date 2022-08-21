using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;

namespace FluentBlog.Store.Category.Action
{
    public class CategoryDataSetAction
    {
        public List<string>? Categories { get; set; }

        public List<ArticleOverviewData>? UncategorizedArticles { get; set; }

        public CategoryDataSetAction(List<string>? categories, List<ArticleOverviewData>? uncategorizedArticles)
        {
            Categories = categories;
            UncategorizedArticles = uncategorizedArticles;
        }
    }
}
