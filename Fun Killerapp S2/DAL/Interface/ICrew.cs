using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.DAL.Interface
{
    interface ICrew : IMain
    {
       void Save(DateTime lasttimelogin, int crewid);
    }
}
