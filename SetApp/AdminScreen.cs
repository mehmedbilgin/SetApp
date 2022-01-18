using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetApp
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            String sifre = "12345";
            if (admin_sifre.Text.Equals(sifre))
            {
                AdminMain admin_main = new AdminMain();
                admin_main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre Hatalı");
            }
        }
    }
}
