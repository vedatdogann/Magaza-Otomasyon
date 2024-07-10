
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
    public partial class Tedarik : Form
    {

        public int TedarikciId, StokId = 0;
        public Tedarik()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void Tedarik_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            TedarikciListele();
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
            txt_Eposta.Text = "";
            txt_FirmaAdi.Text = "";
            txt_Telefon.Text = "";
            rtxt_Adres.Text = "";
            nud_StokSayisi.Value = 0;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_FirmaAdi.Text == "" || txt_Eposta.Text == "" || txt_Telefon.Text == "" || rtxt_Adres.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }else
                {
                    baglan();

                    string ekle = "INSERT INTO Tedarikci (FirmaAdi, Telefon, Eposta, Adres) VALUES (@FirmaAdi , @Telefon , @Eposta , @Adres)";

                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@FirmaAdi", txt_FirmaAdi.Text);
                    komut.Parameters.AddWithValue("@Telefon", txt_Telefon.Text);
                    komut.Parameters.AddWithValue("@Eposta", txt_Eposta.Text);
                    komut.Parameters.AddWithValue("@Adres", rtxt_Adres.Text);
                    komut.ExecuteNonQuery();
                    baglanti_kapat();
                    InputTemizle();
                    TedarikciListele();
                    MessageBox.Show("Tedarikçi Başarıyla Eklendi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        public void TedarikciListele()
        {
            try
            {
                baglan();
                string sorgu = "SELECT * FROM Tedarikci";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dgv_TedarikciListesi.DataSource = dt;
                baglanti_kapat();
                dgv_TedarikciListesi.Columns[0].Visible = false;
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

        private void dgv_TedarikciListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TedarikciId = Convert.ToInt32(dgv_TedarikciListesi.CurrentRow.Cells[0].Value);
        }

        private void dgv_UrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StokId = Convert.ToInt32(dgv_UrunListesi.CurrentRow.Cells[0].Value);
        }

        private void btn_SiparisVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (TedarikciId == 0 || StokId == 0 || nud_StokSayisi.Value == 0)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }
                else
                {
                    DateTime tarih = DateTime.Now;
                    string tarihFormati = tarih.ToShortDateString();
                    int MevcutStokMiktari  = 0;
                    int GuncelStokMiktari = 0;
                    baglan();
                    string ekle = "INSERT INTO VerilenSiparisler (TedarikciId , StokId, Miktar, Tarih) VALUES (@TedarikciId, @StokId, @Miktar, @Tarih)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@TedarikciId", TedarikciId);
                    komut.Parameters.AddWithValue("@StokId", StokId);
                    komut.Parameters.AddWithValue("@Miktar", nud_StokSayisi.Value);
                    komut.Parameters.AddWithValue("@Tarih", tarihFormati);
                    komut.ExecuteNonQuery();
                    baglanti_kapat();

                    baglan();
                    string sorgu = "SELECT * FROM Stoklar WHERE id = @id";
                    OleDbCommand komut2 = new OleDbCommand(sorgu, baglanti);
                    komut2.Parameters.AddWithValue("@id", StokId);
                    OleDbDataReader sonuc = komut2.ExecuteReader();

                    while (sonuc.Read())
                    {
                        MevcutStokMiktari = Convert.ToInt32(sonuc["StokMiktari"]);
                    }

                    baglanti_kapat();
                    GuncelStokMiktari = (MevcutStokMiktari + Convert.ToInt32(nud_StokSayisi.Value));
                    baglan();
                    string guncelle = "UPDATE Stoklar SET StokMiktari = @StokMiktari WHERE id = @id";
                    OleDbCommand komut3 = new OleDbCommand(guncelle, baglanti);
                    komut3.Parameters.AddWithValue("@StokMiktari", GuncelStokMiktari);
                    komut3.Parameters.AddWithValue("@id", StokId);
                    komut3.ExecuteNonQuery();
                    baglanti_kapat();
                    InputTemizle();
                    StokListele();
                    MessageBox.Show("Sipariş Başarıyla Verildi");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }
    }
}
