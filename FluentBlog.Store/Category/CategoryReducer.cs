using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;
using FluentBlog.Store.Category.Action;

namespace FluentBlog.Store.Category
{
    public static class CategoryReducer
    {
        [ReducerMethod]
        public static CategoryState OnCategoryDataSet(CategoryState state, CategoryDataSetAction action)
        {
            return state with
            {
                Categories = action.Categories,
                UncategorizedArticles = action.UncategorizedArticles
            };
        }
    }
}
