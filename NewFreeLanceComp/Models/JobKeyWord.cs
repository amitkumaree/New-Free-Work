using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFreeLanceComp.Models
{
    public sealed class JobKeyWord
    {
        public int JobKeyWordID { get; set; }
        public int JobCategoryID { get; set; }
        public string JobKeyWords { get; set; }
    }
}