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
    public partial class StokGor : Form
    {
        public StokGor()
        {
            InitializeComponent();
        }

        private void StokGor_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TÜR",50);
            listView1.Columns.Add("ÖLÇÜ", 50);
            listView1.Columns.Add("SERTİFİKA", 150);
            listView1.Columns.Add("ŞEKİL", 150);
            listView1.Columns.Add("DÖKÜM", 150);
            listView1.Columns.Add("ADET", 50);
            listView1.Width = 605;
        }
    }
}
