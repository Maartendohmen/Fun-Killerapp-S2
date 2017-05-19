using Fun_Killerapp_S2.DAL.Interface;
using Fun_Killerapp_S2.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Logic
{
    class UserRepository
    {
        private IUser context;

        public UserRepository()
        {
            this.context = new UserContext();
        }

        public List<User> GetAllUsers()
        {
            return this.context.GetAll().Cast<User>().ToList();
        }

        public User GetOneUser(string emailadres, string password)
        {
            return (User)this.context.GetOne(emailadres,password);
        }
    }
}
