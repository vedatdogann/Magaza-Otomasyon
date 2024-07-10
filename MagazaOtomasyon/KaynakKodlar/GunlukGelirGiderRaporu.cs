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
    public partial class GunlukGelirGiderRaporu : Form
    {

        public string Tarih = "";
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public GunlukGelirGiderRaporu()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Tarih = dtp_Tarih.Text;
            double GelirlerToplami = 0;
            double GiderlerToplami = 0;

            baglan();
            string Gelirsorgu = "SELECT Satislar.Miktar , Stoklar.Fiyat FROM Satislar INNER JOIN Stoklar ON Stoklar.id = Satislar.StokId WHERE Satislar.Tarih = @Tarih";
            OleDbCommand komut = new OleDbCommand(Gelirsorgu, baglanti);
            komut.Parameters.AddWithValue("@Tarih", Tarih);
            OleDbDataReader sonuc = komut.ExecuteReader();
            while (sonuc.Read())
            {
                GelirlerToplami += Convert.ToDouble(sonuc["Miktar"]) * Convert.ToDouble(sonuc["Fiyat"]);
            }
            baglanti_kapat();

            baglan();
            string GiderSorgu = "SELECT * FROM Giderler WHERE Tarih = @Tarih";
            OleDbCommand komut2 = new OleDbCommand(GiderSorgu, baglanti);
            komut2.Parameters.AddWithValue("@Tarih", Tarih);
            OleDbDataReader sonuc2 = komut2.ExecuteReader();
            while (sonuc2.Read())
            {
                GiderlerToplami += Convert.ToDouble(sonuc2["GiderTutari"]);
            }
            baglanti_kapat();

            lbl_GelirlerToplami.Text = GelirlerToplami.ToString() + " TL";
            lbl_GiderlerToplami.Text = GiderlerToplami.ToString() + " TL";
        }

        private void GunlukGelirGiderRaporu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lbl_rapor_bilgisi.Text = "Günlük Gelir Gider Raporu";
        }
    }
}
