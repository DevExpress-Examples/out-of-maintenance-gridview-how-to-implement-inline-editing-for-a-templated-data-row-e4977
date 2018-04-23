using DevExpress.Web.Mvc;
using DXWebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication3.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/
        public ActionResult Index() {
            return View(PersonLanguages.GetPersonLanguages());
        }
        public ActionResult GridViewPartial() {
            return PartialView(PersonLanguages.GetPersonLanguages());
        }
        public ActionResult UpdateGridView(Person person) {
            return PartialView("GridViewPartial", PersonLanguages.UpdatePerson(person));
        }

    }
}
