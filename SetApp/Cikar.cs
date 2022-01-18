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
        public string name;
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
        public void stokCikar()
        {
            int index = Convert.ToInt32(secilcek.CurrentRow.Cells[0].Value);

            string sorgu = "UPDATE Vanalar SET adet=adet-"+azaltilacak.Text+" WHERE id=@p2";
            SqlCommand command = new SqlCommand(sorgu, con.baglan());
            command.Parameters.AddWithValue("@p2", index);
            command.ExecuteNonQuery();
            con.baglan().Close();

            MessageBox.Show("Cikarma islemi gerceklesti");
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            stokCikar();
            logTut();
            controlsClear();
            getDatas();
        }
        public void controlsClear()
        {
            adet.Clear();
            azaltilacak.Clear();
            fiyat.Clear();
            secilcek.ClearSelection();
        }
        public void logTut()
        {
            int degisim = Convert.ToInt32("-" + azaltilacak.Text);
            int vanaId = Convert.ToInt32(secilcek.CurrentRow.Cells[0].Value);

            string insertLog = "INSERT INTO Stok (kullaniciAdi, vanaId, fiyat, degisim, zaman) VALUES (@p1, @p2, @p3, @p4, @p5)";
            SqlCommand command = new SqlCommand(insertLog, con.baglan());
            command.Parameters.AddWithValue("@p1", name);
            command.Parameters.AddWithValue("@p2", vanaId);
            command.Parameters.AddWithValue("@p3", Convert.ToInt32(fiyat.Text));
            command.Parameters.AddWithValue("@p4", degisim);
            command.Parameters.AddWithValue("@p5", DateTime.Now);
            command.ExecuteNonQuery();
            con.baglan().Close();

        }
    }
}
