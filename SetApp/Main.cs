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
    public partial class Main : Form
    {
        public string ad;
        public Main()
        {
            
            InitializeComponent();
        }

        private void show_stock_Click(object sender, EventArgs e)
        {
            StokGor stokGor = new StokGor();
            stokGor.Show();
            
        }

        private void add_stock_Click(object sender, EventArgs e)
        {
            StokEkle stokEkle = new StokEkle();
            stokEkle.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label3.Text = ad;
        }
    }
}
