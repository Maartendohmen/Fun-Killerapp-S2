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
        private static List<Product> Discountproducts = new List<Product>();
        // GET: Crew
        public ActionResult CrewMain()
        {
            if (Session["Allow"] == null)
            {
                Session["error"] = "Om deze pagina te betreden moet je aangemeld zijn";
                return RedirectToAction("Index", "Main");
            }
            else
            {

                //currentcrewmember
                current = (Crew)Session["CurrentCrew"];
                ViewData["CurrentCrew"] = current;

                //Alldiscounts
                ViewBag.Alldiscounts = co.GetAllDiscounts();

                //allproducts
                ViewBag.Allproducts = co.GetAllProducts();

                //allorders
                ViewBag.Allorders = co.GetAllOrders(); 

                return View();
            }
        }

        [HttpPost]
        public ActionResult CrewMain(CrewModel model)
        {

            if (model.OrderInput != 0)
            {
                Order specificorder = co.GetOneOrder(model.OrderInput);
                ViewBag.Oneorder = specificorder.Products;
            }
            if (model.ProductIDInput != 0)
            {
                Discountproducts.Add(co.GetOneProduct(model.ProductIDInput));
            }
            if (model.Amount != 0 && model.Comment != null && model.Time != null)
            {
                co.SaveDiscounts(model.Amount, model.Time, model.Comment, Discountproducts);
            }
            if (model.Discountid != 0)
            {
                co.DeleteDiscount(model.Discountid);
            }
            return View(CrewMain());
        }
    }
}