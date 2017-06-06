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
    public class CrewController : Controller
    {
        private static Crew current;
        private static CrewOverview co = new CrewOverview();
        // GET: Crew
        public ActionResult CrewMain()
        {
            //currentcrewmember
            current = (Crew)Session["CurrentCrew"];
            ViewData["CurrentCrew"] = current;

            //Alldiscounts
            List<Discount> alldiscounts = co.GetAllDiscounts();
            ViewBag.Alldiscounts = alldiscounts;

            //allproducts
            List<Product> allproducts = co.GetAllProducts();
            ViewBag.Allproducts = allproducts;

            //allorders
            List<Order> allorders = co.GetAllOrders();
            ViewBag.Allorders = allorders;

            return View();
        }

        [HttpPost]
        public ActionResult CrewMain(CrewModel model)
        {

            if (model.OrderInput != 0)
            {
                Order specificorder = co.GetOneOrder(model.OrderInput);
                ViewBag.Oneorder = specificorder.Products;
            }



            return View(CrewMain());
        }
    }
}