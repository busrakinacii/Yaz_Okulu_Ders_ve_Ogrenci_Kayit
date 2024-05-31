using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public static class Connect
    {
     public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QUL77PV\SQLEXPRESS;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
