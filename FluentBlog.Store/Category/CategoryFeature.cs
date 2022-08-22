using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fluxor;
using FluentBlog.Model.Category;

namespace FluentBlog.Store.Category
{
    public class CategoryFeature : Feature<CategoryState>
    {
        public override string GetName() => "Category";

        protected override CategoryState GetInitialState()
        {
            return new CategoryState()
            {
                Category = null
            };
        }
    }
}
