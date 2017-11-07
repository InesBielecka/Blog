using RJP.MultiUrlPicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Logic.Models
{
   public class MenuItem
    {
        public string MenuTitle { get; set; }

        public Link Link1lvl { get; set; }
        public IEnumerable<Link> Link2lvl { get; set; }

    }
}
