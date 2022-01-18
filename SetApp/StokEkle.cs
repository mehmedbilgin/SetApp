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
    public partial class StokEkle : Form
    {
        Connection con = new Connection();
        public StokEkle()
        {
            InitializeComponent();
        }
        private void StokEkle_Load(object sender, EventArgs e)
        {
            getDatas();
        }
        public void addStok()
        {
            if (tur.SelectedIndex != -1 && olcu.SelectedIndex != -1 && sertifika.SelectedIndex != -1 && sekil.SelectedIndex != -1 && dokum.SelectedIndex != -1 && adet.Text != "" && fiyat.Text != "")
            {
                string addVanalar = "INSERT INTO Vanalar (turAdi, olcuAdi, sertifikaAdi, sekilAdi, dokumAdi, adet) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
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
                MessageBox.Show("Kaydedildi.");
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            addStok();
        }
    }
}
