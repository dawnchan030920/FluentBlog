using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBlog.Model.Article;
using FluentBlog.Model.Category;

namespace FluentBlog.Store.Category
{
    public record CategoryState
    {
        public CategoryData? Category { get; init; }
    }
}
