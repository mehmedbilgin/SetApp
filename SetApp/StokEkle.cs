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
    public partial class StokEkle : Form
    {
        Connection con = new Connection();
        public StokEkle()
        {
            InitializeComponent();
        }
        public void addData()
        {
            String sorgu = "INSERT INTO vanalar";
        }

        
    }
}
