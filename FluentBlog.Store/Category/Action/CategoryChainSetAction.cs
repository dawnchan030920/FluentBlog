using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Store.Category.Action
{
    public class CategoryChainSetAction
    {
        public List<string>? CurrentCategoryChain { get; set; }

        public CategoryChainSetAction(List<string>? currentCategoryChain)
        {
            CurrentCategoryChain = currentCategoryChain;
        }
    }
}
