using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fun_Killerapp_S2;
using System.Collections.Generic;
using Fun_Killerapp_S2.Object;
using System.Linq;

namespace Testing
{
    [TestClass]
    public class CrewActions
    {
        [TestMethod]
        public void TestGetAllOrders()
        {
            //kijk of je alle orders kan opvragen
            CrewOverview cr = new CrewOverview();
            Assert.IsNotNull(cr.GetAllOrders());
        }

        [TestMethod]
        public void TestSaveLatestsLogin()
        {
            //save nieuwe laatste login-tijd
            CrewOverview cr = new CrewOverview();
            cr.Savelasttimelogin(DateTime.Now, 0);
        }

        [TestMethod]
        public void TestSaveDiscount()
        {
            //Kijk of je een Discount kan Saven (even tijdelijk op alle producten)
            CrewOverview cr = new CrewOverview();
            cr.SaveDiscounts(50, DateTime.Now, "Nieuwe korting", cr.GetAllProducts());
        }

        [TestMethod]
        public void TestDeleteDiscount()
        {
            //kijk of je de hiervoor genoemde discount weer kan verwijderen
            CrewOverview cr = new CrewOverview();
            List<Discount> alldiscounts = cr.GetAllDiscounts().Cast<Discount>().ToList();
            Discount latest = alldiscounts.Last();
            cr.DeleteDiscount(latest.DiscountID);
        }
    }
}
