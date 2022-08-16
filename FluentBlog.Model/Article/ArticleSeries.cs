using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Model.Article
{
    public class ArticleSeries
    {
        public string Series { get; set; }

        public int Number { get; set; }

        public string? SeriesTitle { get; set; }

        public ArticleSeries(string series, int number, string? seriesTitle)
        {
            Series = series;
            Number = number;
            SeriesTitle = seriesTitle;
        }
    }
}
