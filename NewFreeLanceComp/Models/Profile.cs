using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFreeLanceComp.Models
{
    /// <summary>
    /// This will contain information for Customer profile and freelancer Profile too
    /// </summary>
    public sealed class Profile
    {
        public int ProfileID { get; set; }
        public string Name { get; set; }
    }
}