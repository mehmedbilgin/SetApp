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
    
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            String kul_ad = kullanici_adi.Text;
            String password = passwd.Text;
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM kullanicilar WHERE kullanici_adi=@usrname AND parola=@pswd";
            con = new SqlConnection("Data Source=DESKTOP-01ROSI4\\SQLEXPRESS;Initial Catalog=set;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText="SELECT parola FROM kullanicilar WHERE kullanici_adi=@kul_ad";
            cmd.Parameters.AddWithValue("@kul_ad",kullanici_adi.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                String dbase = dr["parola"].ToString();
                if (passwd.Text.Equals(dbase))
                {
                    Main main_form = new Main();
                    main_form.ad = kullanici_adi.Text;
                    main_form.Show();
                    this.Hide();
                    con.Close();
                    con.Open();
                    
                    cmd.CommandText = "INSERT INTO kayitlar (tarih, kullanici) VALUES(@date,@ad)";
                    DateTime time = DateTime.Now;
                    cmd.Parameters.AddWithValue("@date", time);
                    cmd.Parameters.AddWithValue("@ad", kullanici_adi.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Denemesi hata kodu 1");
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Denemesi");
            }
            con.Close();

        }

        private void admin_giris_Click(object sender, EventArgs e)
        {
            AdminScreen admin_screen = new AdminScreen();
            admin_screen.Show();
            this.Hide();
        }
    }
}
