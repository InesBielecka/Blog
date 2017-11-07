using Our.Umbraco.Ditto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Logic.Models
{
    public class SiteSettings
    {
        [UmbracoProperty("siteName")]
        public string SiteNameLikeThis { get; set; }
    
        [UmbracoProperty("nawigacjaGlowna")]
       public IEnumerable<MenuItem> Navigation { get; set; }
    }
}
