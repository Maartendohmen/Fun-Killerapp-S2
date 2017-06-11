using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Webshop.Models;

namespace Webshop.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/<controller>
        public List<Customers2> Get()
        {
            return Customers2.Allcustomers;
        }

        // GET api/<controller>/5
        public Customers2 Get(int id)
        {
            Customers2 current = null;
            foreach (Customers2 cus in Customers2.Allcustomers)
            {
                if (cus.Customerid == id)
                {
                    current = cus;
                }
            }
            return current;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}