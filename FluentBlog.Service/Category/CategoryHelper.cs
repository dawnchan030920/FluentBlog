using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;
using FluentBlog.Service.Article;

namespace FluentBlog.Service.Category
{
    public class CategoryHelper
    {
        private List<ArticleOverviewData>? articleOverviews = ArticleOverviewService.ArticleOverviews;

        public void Categorize(out List<string>? subCategories, out List<ArticleOverviewData>? uncategorizedArticles, List<string>? currentCategory)
        {
            subCategories = null;
            uncategorizedArticles = null;

            currentCategory ??= new List<string>();

            if (articleOverviews is not null)
            {
                foreach (var overview in articleOverviews)
                {
                    if (overview.CategoryChain is not null && overview.CategoryChain.Take(currentCategory.Count).SequenceEqual(currentCategory))
                    {
                        // Same length -> uncategorized article.
                        if (overview.CategoryChain.Count == currentCategory.Count)
                        {
                            uncategorizedArticles ??= new List<ArticleOverviewData>();
                            uncategorizedArticles.Add(overview);
                        }
                        // Different length --(overview's category is longer)-> sub category exist.
                        else
                        {
                            subCategories ??= new List<string>();
                            subCategories.Add(overview.CategoryChain.Skip(currentCategory.Count).ToList()[0]);
                        }
                    }
                }
            }
        }
    }
}
