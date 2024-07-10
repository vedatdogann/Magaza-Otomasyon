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
    public partial class GunlukSatisRaporu : Form
    {

        public string Tarih = "";
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public GunlukSatisRaporu()
        {
            InitializeComponent();
        }

        private void RaporEkrani_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            lbl_rapor_bilgisi.Text = "Günlük Satış Raporu";
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

        public void listele()
        {
            try
            {
               
                baglan();

                string sorgu = "SELECT Satislar.Tarih, Musteriler.AdSoyad, Stoklar.UrunAdi, Satislar.Miktar FROM (Satislar " +
                                "INNER JOIN Stoklar " +
                                "ON Stoklar.id = Satislar.StokId) " +
                                "INNER JOIN Musteriler " +
                                "ON Musteriler.id = Satislar.MusteriId " +
                                "WHERE Satislar.Tarih = @Tarih";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("Tarih", Tarih);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridView1.DataSource = dt;
                baglanti_kapat();

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarih = dtp_Tarih.Text;
            listele();
        }
    }
}
