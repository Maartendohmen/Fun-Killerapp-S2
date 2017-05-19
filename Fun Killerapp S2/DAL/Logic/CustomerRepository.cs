using Fun_Killerapp_S2.DAL.Context;
using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Logic
{
    class CustomerRepository
    {
        private IMain context;

        public CustomerRepository()
        {
            this.context = new CustomerContext();
        }

        public List<Customer> GetAllCustomers()
        {
            return this.context.GetAll().Cast<Customer>().ToList();
        }

        public Customer GetOneCustomer(int id)
        {
            return (Customer)this.context.GetOne(id);
        }
    }
}
