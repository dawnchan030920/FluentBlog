using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBlog.Model.Page
{
    public class PageData : IEquatable<PageData>
    {
        public string Tag { get; set; }

        public string Icon { get; set; }

        public string IndexUrl { get; set; }

        public bool IsHome { get; set; }

        public PageData(string tag, string icon, string indexUrl, bool isHome)
        {
            Tag = tag;
            Icon = icon;
            IndexUrl = indexUrl;
            IsHome = isHome;
        }

        public override bool Equals(object? obj) => Equals(obj as PageData);

        public bool Equals(PageData? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            if (Tag == other.Tag && Icon == other.Icon && IndexUrl == other.IndexUrl && IsHome == other.IsHome)
            {
                return true;
            }
            else return false;
        }

        public override int GetHashCode() => (Tag, Icon, IndexUrl, IsHome).GetHashCode();

        public static bool operator ==(PageData? x, PageData? y)
        {
            if (x is null)
            {
                return y is null;
            }
            else return x.Equals(y);
        }

        public static bool operator !=(PageData? x, PageData? y) => !(x == y);
    }
}
