using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;
using FluentBlog.Service.Category;
using FluentBlog.Store.Category.Action;
using FluentBlog.Model.Article;

namespace FluentBlog.Store.Category
{
    public class CategoryEffect
    {
        private CategoryHelper categoryHelper;

        public CategoryEffect(CategoryHelper categoryHelper)
        {
            this.categoryHelper = categoryHelper;
        }

        [EffectMethod]
        public async Task OnCategoryChainSet(CategoryChainSetAction action, IDispatcher dispatcher)
        {
            List<string>? subCategories;
            List<ArticleOverviewData>? uncategorizedArticles;
            categoryHelper.Categorize(out subCategories, out uncategorizedArticles, action.CurrentCategoryChain);

            dispatcher.Dispatch(new CategoryDataSetAction(subCategories, uncategorizedArticles));
        }
    }
}
