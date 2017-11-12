using Our.Umbraco.Ditto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models;

namespace Blog.Logic.Models
{
   public class MediaImage
    {
        public string Url { get; set; }
        public string Name { get; set; }
        [CurrentContentAs]
        public IPublishedContent Content { get; set; }
    }
}
