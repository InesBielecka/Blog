using Blog.Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Blog.Logic.Controllers.Surface
{
  public class ArticleSurfaceController: BaseSurfaceController
    {
        private readonly IArticleService _articleService;
        public ArticleSurfaceController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public ActionResult RenderLatestArticle()
        {
            var lastArticle = _articleService.GetLastArticle();
            return PartialView("LatestArticlePartial", lastArticle);
        }
        public ActionResult RenderLatestArticleMenuItem()
        {
            var lastArticle = _articleService.GetLastArticle();
            return PartialView("LatestArticleMenuItemPartial", lastArticle);
        }
    }
}
