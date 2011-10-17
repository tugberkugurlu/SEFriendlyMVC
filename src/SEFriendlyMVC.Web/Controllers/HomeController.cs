using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSiteMapProvider;
using SEFriendlyMVC.Web.Models;

namespace SEFriendlyMVC.Web.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {

            return View();
        }

        public ActionResult Section(string type) {

            var repo = new SectionRepo();
            var model = repo.GetAll().Where(x => x.ToLower() == type.ToLower());

            if (model.Count() <= 0)
                return HttpNotFound();

            ViewBag.Type = model.First().ToString();

            return View();
        }

    }
}