using BlogMvcWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcWeb.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Bloglar.ToList());
        }
    }
}