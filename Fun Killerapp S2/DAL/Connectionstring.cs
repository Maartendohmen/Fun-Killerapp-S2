using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Fun_Killerapp_S2.DAL
{
    abstract class Connectionstring
    {
       public SqlConnection conn = new SqlConnection(@"Data Source=MAARTEN-PC\SQLEXPRESS;Initial Catalog=Webshop;Integrated Security=True");
    }
}
