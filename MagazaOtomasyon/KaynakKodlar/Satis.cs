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
    public partial class Satis : Form
    {
        public int MusteriId = 0;
        public int StokId = 0;

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Satis()
        {
            InitializeComponent();
        }

        private void Satis_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MusteriListele();
            StokListele();
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
            nud_StokSayisi.Value = 0;
        }

        public void MusteriListele()
        {
            try
            {
                baglan();
                string sorgu = "SELECT * FROM Musteriler";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dgv_MusteriListesi.DataSource = dt;
                baglanti_kapat();
                dgv_MusteriListesi.Columns[0].Visible = false;
                dgv_MusteriListesi.Columns[2].Visible = false;
                dgv_MusteriListesi.Columns[3].Visible = false;
                dgv_MusteriListesi.Columns[4].Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        public void StokListele()
        {
            try
            {
                baglan();
                string sorgu = "SELECT * FROM Stoklar";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dgv_UrunListesi.DataSource = dt;
                baglanti_kapat();
                dgv_UrunListesi.Columns[0].Visible = false;
                dgv_UrunListesi.Columns[3].Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        private void btn_SiparisVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (StokId == 0 || MusteriId == 0 || nud_StokSayisi.Value == 0)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }else
                {
                    int yeniMiktar = 0;
                    int stokMiktari = 0;
                    baglan();
                    string sorgu = "SELECT * FROM Stoklar WHERE id = @id";
                    OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", StokId);
                    OleDbDataReader sonuc = komut.ExecuteReader();
                    while (sonuc.Read())
                    {
                        stokMiktari = Convert.ToInt32(sonuc["StokMiktari"]);
                    }
                    baglanti_kapat();

                    if (stokMiktari == 0)
                    {
                        MessageBox.Show("Bu Üründe Stok Kalmamıştır!");
                    }
                    else
                    {
                        if(stokMiktari < nud_StokSayisi.Value)
                        {
                            MessageBox.Show("Ürünün Stok Miktarından Fazla Satış Yapamazsınız !");
                        }
                        else
                        {
                            DateTime tarih = DateTime.Now;
                            string tarihFormati = tarih.ToShortDateString();
                            baglan();
                            string ekle = "INSERT INTO Satislar (MusteriId , StokId, Miktar, Tarih) VALUES (@MusteriId, @StokId, @Miktar, @Tarih)";
                            OleDbCommand komut2 = new OleDbCommand(ekle, baglanti);
                            komut2.Parameters.AddWithValue("@MusteriId", MusteriId);
                            komut2.Parameters.AddWithValue("@StokId", StokId);
                            komut2.Parameters.AddWithValue("@Miktar", nud_StokSayisi.Value);
                            komut2.Parameters.AddWithValue("@Tarih", tarihFormati);
                            komut2.ExecuteNonQuery();
                            baglanti_kapat();

                            yeniMiktar = stokMiktari - Convert.ToInt32(nud_StokSayisi.Value);

                            baglan();
                            string guncelle = "UPDATE Stoklar SET StokMiktari = @StokMiktari WHERE id = @id";
                            OleDbCommand komut3 = new OleDbCommand(guncelle, baglanti);
                            komut3.Parameters.AddWithValue("@StokMiktari", yeniMiktar);
                            komut3.Parameters.AddWithValue("@id", StokId);
                            komut3.ExecuteNonQuery();
                            baglanti_kapat();
                            InputTemizle();
                            StokListele();
                            MessageBox.Show("Satış Başarıyla Yapıldı");
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        private void dgv_MusteriListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriId = Convert.ToInt32(dgv_MusteriListesi.CurrentRow.Cells[0].Value);
        }

        private void dgv_UrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StokId = Convert.ToInt32(dgv_UrunListesi.CurrentRow.Cells[0].Value);
        }
    }
}
