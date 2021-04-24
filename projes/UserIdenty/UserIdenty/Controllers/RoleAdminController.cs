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
    public class RoleAdminController : Controller
    {
        private RoleManager<IdentityRole> roleManager;

        public RoleAdminController()
        {
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new IdentityDataContext()));
        }
        // GET: RoleAdmin
        public ActionResult Index()
        {
            return View(roleManager.Roles);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name)
        {
            if (ModelState.IsValid)
            {
                var result = roleManager.Create(new IdentityRole(name));

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item);
                    }
                }
            }
            return View(name);
        }

        [HttpPost]
        public ActionResult Delete(string id)
        {
            var role = roleManager.FindById(id);

            if (role!=null)
            {
                var result = roleManager.Delete(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("Error", result.Errors);
                }
            }
            else
            {
                return View("Error", new string[] { "Rol bulunamadı..." });
            }
        }
    }
}