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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void stocks_btn_Click(object sender, EventArgs e)
        {
            StokGor stokGor = new StokGor();
            stokGor.Show();
            this.Hide();
        }

        private void logs_btn_Click(object sender, EventArgs e)
        {
            Log_form log_form = new Log_form();
            log_form.Show();
            this.Hide();
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            Add_user add_User = new Add_user();
            add_User.Show();
            this.Hide();
        }
    }
}
