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
    public partial class Vana_ekle : Form
    {
        Connection con = new Connection();
        public Vana_ekle()
        {
            InitializeComponent();
        }
        public void insertData()
        {
            if (tur.Text != "")
            {
                string insertToVanaTurleri = "INSERT INTO VanaTurleri (turAdi) VALUES (@p1)";
                SqlCommand commandToVT = new SqlCommand(insertToVanaTurleri, con.baglan());
                commandToVT.Parameters.AddWithValue("@p1", tur.Text);
                commandToVT.ExecuteNonQuery();
            }

            if (olcu.Text != "")
            {
                string insertToVanaOlculeri = "INSERT INTO VanaOlculeri (olcu) VALUES (@p2)";
                SqlCommand commandToVO = new SqlCommand(insertToVanaOlculeri, con.baglan());
                commandToVO.Parameters.AddWithValue("@p2", olcu.Text);
                commandToVO.ExecuteNonQuery();
            }

            if (sertifika.Text != "")
            {
                string insertToVanaSertifikalari = "INSERT INTO VanaSertifikalari (sertifikaAdi) VALUES (@p3)";
                SqlCommand commandToVS = new SqlCommand(insertToVanaSertifikalari, con.baglan());
                commandToVS.Parameters.AddWithValue("@p3", sertifika.Text);
                commandToVS.ExecuteNonQuery();
            }

            if (sekil.Text != "")
            {
                string insertToVanaSekilleri = "INSERT INTO VanaSekilleri (vanaSekli) VALUES (@p4)";
                SqlCommand commandToVSekil = new SqlCommand(insertToVanaSekilleri, con.baglan());
                commandToVSekil.Parameters.AddWithValue("@p4", tur.Text);
                commandToVSekil.ExecuteNonQuery();
            }

            if (dokum.Text != "")
            {
                string insertToVanaDokumleri = "INSERT INTO VanaDokumTurleri (dokumAdi) VALUES (@p5)";
                SqlCommand commandToVD = new SqlCommand(insertToVanaDokumleri, con.baglan());
                commandToVD.Parameters.AddWithValue("@p5", tur.Text);
                commandToVD.ExecuteNonQuery();
            }

            con.baglan().Close();

            MessageBox.Show("Kaydedildi.");
            controlsClear();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            insertData();
        }
        public void controlsClear()
        {
            tur.Clear();
            olcu.Clear();
            sertifika.Clear();
            sekil.Clear();
            dokum.Clear();
        }
    }
}
