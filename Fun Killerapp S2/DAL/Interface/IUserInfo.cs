using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Interface
{
    interface IUserInfo
    {
        int getID(bool crewmember, string username, string password);
        string GetCustomername(int customerID);
    }
}
