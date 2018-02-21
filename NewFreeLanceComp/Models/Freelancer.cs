using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFreeLanceComp.Models
{
    public sealed class Freelancer
    {
        public int FreelancerID { get; set; }
        public int ProfileIDFk { get; set; }
        public Login Login { get; set; }
        public string Location { get; set; }
        public List<int> Skils { get; set; }
    }
}