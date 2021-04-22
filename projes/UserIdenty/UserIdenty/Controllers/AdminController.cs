using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserIdenty.Identity;

namespace UserIdenty.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;

        public AdminController()
        {
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new IdentityDataContext()));
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}