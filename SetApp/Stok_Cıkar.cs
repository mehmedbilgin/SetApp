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
    public partial class Stok_Cıkar : Form
    {
        Connection con = new Connection();
        public Stok_Cıkar()
        {
            InitializeComponent();
        }
        public void controlsClear()
        {
            tur.SelectedIndex = -1;
            olcu.SelectedIndex = -1;
            sertifika.SelectedIndex = -1;
            sekil.SelectedIndex = -1;
            dokum.SelectedIndex = -1;
            adet.Clear();
            fiyat.Clear();
        }
        public void updateStok()
        {
            if (tur.SelectedIndex != -1 && olcu.SelectedIndex != -1 && sertifika.SelectedIndex != -1 && sekil.SelectedIndex != -1 && dokum.SelectedIndex != -1 && adet.Text != "" && fiyat.Text != "")
            {
                string addVanalar = "UPDATE Vanalar SET adet=adet-@p6, WHERE turAdi=@p1, olcuAdi=@p2, sertifikaAdi=@p3, sekilAdi=@p4, dokumAdi=@p5";
                SqlCommand command = new SqlCommand(addVanalar, con.baglan());
                command.Parameters.AddWithValue("@p1", tur.Text);
                command.Parameters.AddWithValue("@p2", olcu.Text);
                command.Parameters.AddWithValue("@p3", sertifika.Text);
                command.Parameters.AddWithValue("@p4", sekil.Text);
                command.Parameters.AddWithValue("@p5", dokum.Text);
                command.Parameters.AddWithValue("@p6", adet.Text);
                command.ExecuteNonQuery();
                con.baglan().Close();
                controlsClear();
                MessageBox.Show("Cıkarıldı.");
            }
            else
            {
                MessageBox.Show("Hicbir alan bos birakilamaz.");
            }
        }
        public void getDatas()
        {
            string getTur = "SELECT * FROM VanaTurleri";
            string getOLcu = "SELECT * FROM VanaOlculeri";
            string getSertfika = "SELECT * FROM VanaSertifikalari";
            string getSekil = "SELECT * FROM VanaSekilleri";
            string getDokum = "SELECT * FROM VanaDokumTurleri";

            SqlDataReader readTur;
            SqlCommand turLoadCommand = new SqlCommand(getTur, con.baglan());
            readTur = turLoadCommand.ExecuteReader();

            SqlDataReader readOlcu;
            SqlCommand olcuLoadCommand = new SqlCommand(getOLcu, con.baglan());
            readOlcu = olcuLoadCommand.ExecuteReader();

            SqlDataReader readSertifika;
            SqlCommand sertifikaLoadCommand = new SqlCommand(getSertfika, con.baglan());
            readSertifika = sertifikaLoadCommand.ExecuteReader();

            SqlDataReader readSekil;
            SqlCommand sekilLoadCommand = new SqlCommand(getSekil, con.baglan());
            readSekil = sekilLoadCommand.ExecuteReader();

            SqlDataReader readDokum;
            SqlCommand dokumLoadCommand = new SqlCommand(getDokum, con.baglan());
            readDokum = dokumLoadCommand.ExecuteReader();

            while (readTur.Read())
            {
                tur.Items.Add(readTur[1].ToString());
            }
            while (readOlcu.Read())
            {
                olcu.Items.Add(readOlcu[1].ToString());
            }
            while (readSertifika.Read())
            {
                sertifika.Items.Add(readSertifika[1].ToString());
            }
            while (readSekil.Read())
            {
                sekil.Items.Add(readSekil[1].ToString());
            }
            while (readDokum.Read())
            {
                dokum.Items.Add(readDokum[1].ToString());
            }

            con.baglan().Close();
        }

        private void Stok_Cıkar_Load(object sender, EventArgs e)
        {
            getDatas();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            updateStok();
        }
    }
}
