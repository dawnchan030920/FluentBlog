using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;

namespace FluentBlog.Store.Category
{
    public record CategoryState
    {
        public List<string>? Categories { get; init; }

        public List<ArticleOverviewData>? UncategorizedArticles { get; init; }
    }
}
