using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbraco.presentation;
using Umbraco.Core.Models;

namespace Blog.Logic.Helpers
{
   public class SiteHelper
    {
        public IPublishedContent GetSiteRoot()
        {
            var rootNode = Umbraco.Web.UmbracoContext.Current.ContentCache
                .GetAtRoot().Single(n => n.DocumentTypeAlias == "homePage");
            return rootNode;
        }
    }
}
