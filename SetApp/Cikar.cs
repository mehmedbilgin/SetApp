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
    public partial class Cikar : Form
    {
        Connection con = new Connection();
        public Cikar()
        {
            InitializeComponent();
        }
        private void Cikar_Load(object sender, EventArgs e)
        {
            getDatas();
        }
        public void getDatas()
        {
            string getTable = "SELECT * FROM Vanalar";

            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(getTable, con.baglan());
            sqlda.Fill(dt);
            secilcek.DataSource = dt;
        }

        private void secilcek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(secilcek.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                secilcek.CurrentRow.Selected = true;
                adet.Text = secilcek.Rows[e.RowIndex].Cells["adet"].FormattedValue.ToString();
            }
        }
        public void azalt()
        {
            //string sorgu = "UPDATE Vanalar SET adet = @p1 WHERE id=@p2";
            //SqlCommand command = new SqlCommand(sorgu, con.baglan());
            //int yeni = Convert.ToInt32(adet.Text) - Convert.ToInt32(azaltilacak.Text);
            //command.Parameters.AddWithValue("@p1", yeni);
            //command.Parameters.AddWithValue("@p2", secilcek.Rows);
        }
    }
}
