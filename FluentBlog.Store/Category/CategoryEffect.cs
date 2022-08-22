using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Service.Category;
using FluentBlog.Store.Category.Action;
using Fluxor;

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
        public Task OnCategoryChainSet(CategoryChainSetAction action, IDispatcher dispatcher)
        {
            var category = categoryHelper.GetCategoryDataByCategoryChain(action.CategortChain);
            dispatcher.Dispatch(new CategoryDataSetAction(category));
            return Task.CompletedTask;
        }

        [EffectMethod(typeof(CategoryChainClearAction))]
        public Task OnCategoryChainClear(IDispatcher dispatcher)
        {
            var category = categoryHelper.GetCategoryDataByCategoryChain(null);
            dispatcher.Dispatch(new CategoryDataSetAction(category));
            return Task.CompletedTask;
        }
    }
}
