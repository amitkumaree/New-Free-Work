using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace NewFreeLanceComp.Models
{
    public sealed class Customer
    {
        public int CustomerCode { get; set; }
        public int ProfileIDFk { get; set; }
        public Login Login { get; set; }
    }
}
