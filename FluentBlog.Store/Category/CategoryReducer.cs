using FluentBlog.Store.Category.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;

namespace FluentBlog.Store.Category
{
    public static class CategoryReducer
    {
        [ReducerMethod]
        public static CategoryState OnCategoryDataSet(CategoryState state, CategoryDataSetAction action)
        {
            return state with
            {
                Category = action.Category
            };
        }
    }
}
