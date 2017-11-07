using Blog.Logic.Models;
using Our.Umbraco.Ditto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web;

namespace Blog.Logic.Helpers
{
   public static class UmbracoAssist
    {
        public static SiteSettings GetSettings()
        {
            var helper = new UmbracoHelper(UmbracoContext.Current);
            var settingPage = helper.TypedContentSingleAtXPath("//siteSettings");
            return settingPage != null ? settingPage.As<SiteSettings>() : new SiteSettings();
        }
    }
}
