using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Our.Umbraco.Ditto;

namespace Blog.Logic.Models.Pages
{
    public class ArticlesPage
    {
        public string ArticleInfo { get; set; }
        public string ArticleContent { get; set; }
        public string Url { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
