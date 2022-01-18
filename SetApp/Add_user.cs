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
        Connection con = new Connection();
        public Add_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInsert = "INSERT INTO kullanicilar (kullanici_adi, parola) VALUES(@ad,@pw)";
            SqlCommand command = new SqlCommand(userInsert, con.baglan());
            command.Parameters.AddWithValue("@ad", kullanici_adi.Text);
            command.Parameters.AddWithValue("@pw", parola.Text);
            
            MessageBox.Show(kullanici_adi.Text +"kullanıcısı eklendi");
        }
    }
}
