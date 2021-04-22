using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserIdenty.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string description { get; set; }
    }
}
