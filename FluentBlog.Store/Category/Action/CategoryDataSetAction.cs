using FluentBlog.Model.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.Category.Action
{
    public class CategoryDataSetAction
    {
        public CategoryData? Category { get; set; }

        public CategoryDataSetAction(CategoryData? category)
        {
            Category = category;
        }
    }
}
