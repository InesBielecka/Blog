using Blog.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web.Mvc;

namespace Blog.Logic.Controllers.Surface
{
  public class BaseSurfaceController: SurfaceController
    {
        protected readonly SiteHelper SiteHelper;

        public BaseSurfaceController()
        {
            SiteHelper = new SiteHelper();
        }
    }
}
