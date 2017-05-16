using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    class User
    {
        private int userID;
        private int customerID;
        private int crewID;
        private string emailadres;
        private string password;

        public int UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            private set { customerID = value; }
        }

        public int CrewID
        {
            get { return crewID; }
            private set { crewID = value; }
        }

        public string Emailadres
        {
            get { return emailadres; }
            private set { emailadres = value; }
        }

        public string Password
        {
            get { return password; }
            private set { password = value; }
        }

        public User(int userid, int customerid, int crewid, string emailadres, string password)
        {
            this.userID = userid;
            this.customerID = customerid;
            this.crewID = crewid;
            this.emailadres = emailadres;
            this.password = password;
        }
    }
}
