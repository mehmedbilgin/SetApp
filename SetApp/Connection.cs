using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SetApp
{
    class Connection
    {
        public SqlConnection baglan()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-01ROSI4\\SQLEXPRESS;Initial Catalog=set;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
