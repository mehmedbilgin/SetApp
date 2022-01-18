using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetApp
{
    public partial class Son_islem : Form
    {
        Connection con = new Connection();
        public Son_islem()
        {
            InitializeComponent();
        }
        public void getData()
        {
            String sorgu = "SELECT * FROM stok";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, con.baglan());
            adp.Fill(dt);
            islem.DataSource = dt;
        }

        private void Son_islem_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
