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
       public SqlConnection conn = new SqlConnection(@"
            Data Source=ianketje.com;
            Integrated Security=False;
            User ID=sa;
            Password=7CbGNB#Xtq#TKSw!;
            Connect Timeout=15;
            Encrypt=False;
            Database=Webshop;
            TrustServerCertificate=True;
            ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False;
            MultipleActiveResultSets=true");
    }
}
