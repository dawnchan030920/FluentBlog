using FluentBlog.Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Model.Category
{
    public class CategoryData
    {
        private Dictionary<string, CategoryData> categoryDictionary = new Dictionary<string, CategoryData>();

        public string Name { get; set; }

        public CategoryData? ParentCategory { get; set; }

        public List<CategoryData>? SubCategories { get; set; }

        public List<ArticleOverviewData>? Articles { get; set; }

        public int TotalArticleCount { get; set; } = 0;

        public List<string> CategoryChain
        {
            get
            {
                List<string> categoryChain = new List<string>();
                CategoryData currentCategory = this;
                while (currentCategory is not null && currentCategory is not RootCategory)
                {
                    categoryChain.Add(currentCategory.Name);
                    currentCategory = currentCategory.ParentCategory;
                }
                categoryChain.Reverse();
                return categoryChain;
            }
        }

        public CategoryData(string name, List<CategoryData>? subCategories, List<ArticleOverviewData>? articles, CategoryData parentCategory)
        {
            Name = name;
            SubCategories = subCategories;
            Articles = articles;
            ParentCategory = parentCategory;
        }

        public CategoryData(string name, CategoryData parentCategory)
        {
            Name = name;
            ParentCategory = parentCategory;
        }

        public CategoryData(string name)
        {
            Name = name;
        }

        public CategoryData? this[string name]
        {
            get
            {
                if (!categoryDictionary.ContainsKey(name)) return null;
                else return categoryDictionary[name];
            }
        }

        public void AddSubCategory(CategoryData category)
        {
            SubCategories ??= new List<CategoryData>();
            if (!categoryDictionary.ContainsKey(category.Name))
            {
                SubCategories.Add(category);
                categoryDictionary.Add(category.Name, category);
            }
        }
    }
}
