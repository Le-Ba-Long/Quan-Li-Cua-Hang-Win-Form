using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBconnect
    {
        protected SqlConnection sql_con = new SqlConnection(@"Data Source=LONGKUBI;Initial Catalog=Quan_Li_Cua_Hang_May_Tinh;Integrated Security=True");
    }
}
