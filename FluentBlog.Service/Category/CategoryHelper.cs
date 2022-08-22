using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;
using FluentBlog.Model.Category;
using FluentBlog.Service.Article;

namespace FluentBlog.Service.Category
{
    public class CategoryHelper
    {
        private List<ArticleOverviewData>? articleOverviews = ArticleService.ArticleOverviews;

        private CategoryData _categoryTree = new RootCategory("ROOT");

        public CategoryData CategoryTree => _categoryTree;

        public CategoryData? GetCategoryDataByCategoryChain(List<string>? chain)
        {
            if (chain is null || chain.Count == 0 || chain.All(s => s == string.Empty)) return CategoryTree;
            else
            {
                CategoryData? currentCategory = CategoryTree;
                foreach (var category in chain)
                {
                    currentCategory = currentCategory?[category];
                    if (currentCategory is null) return null;
                }
                return currentCategory;
            }
        }

        public CategoryHelper()
        {
            if (articleOverviews is not null)
            {
                foreach (var overview in articleOverviews)
                {
                    CategoryData currentCategory = _categoryTree;
                    currentCategory.TotalArticleCount++;
                    if (overview.CategoryChain is null)
                    {
                        (currentCategory.Articles ??= new List<ArticleOverviewData>()).Add(overview);
                    }
                    else
                    {
                        foreach (var category in overview.CategoryChain)
                        {
                            var newCate = currentCategory[category] is not null ? currentCategory[category] : new CategoryData(category, currentCategory);
                            currentCategory.AddSubCategory(newCate);
                            currentCategory = newCate;
                            currentCategory.TotalArticleCount++;
                        }
                        (currentCategory.Articles ??= new List<ArticleOverviewData>()).Add(overview);
                    }
                }
            }
        }
    }
}
