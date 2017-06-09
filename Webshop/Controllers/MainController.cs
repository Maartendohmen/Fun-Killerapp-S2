using Fun_Killerapp_S2;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            CustomerOverview cu = new CustomerOverview();
            object type_user = cu.GetCurrentUser(model.username, model.password);
            bool allow = true;

            if (type_user is Fun_Killerapp_S2.Object.Customer)
            {
                Session["CurrentCustomer"] = type_user;
                Session["Allow"] = allow;
                return RedirectToAction("CustomerMain", "Customer");
            }
            else if (type_user is Crew)
            {
                Session["CurrentCrew"] = type_user;
                Session["Allow"] = allow;
                return RedirectToAction("CrewMain", "Crew");
            }
            else
            {
                Session["error"] = "Foute aanmelding";
                return View();
            }
        }
    }
}