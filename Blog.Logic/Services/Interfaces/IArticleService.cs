using Blog.Logic.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Logic.Services.Interfaces
{
   public interface IArticleService
    {
         ArticlesPage GetLastArticle();
    }
}
