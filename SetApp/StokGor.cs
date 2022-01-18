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
    public partial class StokGor : Form
    {
        Connection con = new Connection();
        public StokGor()
        {
            InitializeComponent();
        }

        private void StokGor_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string getTur = "SELECT turAdi FROM VanaTurleri";
            SqlDataReader readTur;
            SqlCommand turLoadCommand = new SqlCommand(getTur, con.baglan());
            readTur = turLoadCommand.ExecuteReader();
            while (readTur.Read())
            {
                tur.Items.Add(readTur[0].ToString());
            }
        }
        public void fullFillData()
        {
           
            String sorgu = "SELECT * FROM Vanalar";
            DataTable dt = new DataTable();

            SqlDataAdapter adp = new SqlDataAdapter(sorgu, con.baglan());
            adp.Fill(dt);
            stok_gor.DataSource = dt;
        }
        public void fillData()
        {
            string a ="'"+tur.Text+"'";
            String sorgu = "SELECT * FROM Vanalar WHERE turAdi=" + a;
            DataTable dt = new DataTable();

            SqlDataAdapter adp = new SqlDataAdapter(sorgu, con.baglan());
            adp.Fill(dt);
            stok_gor.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fullFillData();
        }
    }
}
