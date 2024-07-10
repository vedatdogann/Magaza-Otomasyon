using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace odev
{
    public partial class Giderler : Form
    {

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public Giderler()
        {
            InitializeComponent();
        }

        public void baglan()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        public void baglanti_kapat()
        {
            if (baglanti.State != ConnectionState.Closed)
            {
                baglanti.Close();
            }
        }

        private void InputTemizle()
        {
            txt_GiderTuru.Text = "";
            txt_GiderTutari.Text = "";
        }

        private void btn_GiderKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_GiderTuru.Text == "" || txt_GiderTutari.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }
                else
                {
                    DateTime tarih = DateTime.Now;
                    string tarihFormati = tarih.ToShortDateString();
                    baglan();
                    string ekle = "INSERT INTO Giderler (GiderTuru , GiderTutari , Tarih) VALUES (@GiderTuru, @GiderTutari, @Tarih)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@GiderTuru", txt_GiderTuru.Text);
                    komut.Parameters.AddWithValue("@GiderTutari", txt_GiderTutari.Text);
                    komut.Parameters.AddWithValue("@Tarih", tarihFormati);
                    komut.ExecuteNonQuery();
                    baglanti_kapat();

                    InputTemizle();
                    MessageBox.Show("Gider Başarıyla Eklendi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Edin!");
            }
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
