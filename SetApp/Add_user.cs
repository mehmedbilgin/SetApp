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
    public partial class Add_user : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Add_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-01ROSI4\\SQLEXPRESS;Initial Catalog=set;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO kullanicilar (kullanici_adi, parola) VALUES(@ad,@pw)";
            cmd.Parameters.AddWithValue("@ad", kullanici_adi.Text);
            cmd.Parameters.AddWithValue("@pw", parola.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(kullanici_adi.Text +"kullanıcısı eklendi");
        }
    }
}
