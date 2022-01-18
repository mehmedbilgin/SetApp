using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SetApp
{
    public partial class Log_form : Form
    {
        Connection con = new Connection();
        public Log_form()
        {
            InitializeComponent();
        }

        private void Log_form_Load(object sender, EventArgs e)
        {
            getData();
            
            
            

        }
        public void getData()
        {
            String sorgu = "SELECT * FROM kayitlar";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, con.baglan());
            adp.Fill(dt);
            giris_kayit.DataSource = dt;
        }
    }
}
