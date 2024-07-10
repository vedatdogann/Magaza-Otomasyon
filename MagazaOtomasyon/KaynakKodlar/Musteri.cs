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
    public partial class Musteri : Form
    {
        public int MusteriId = 0;

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Musteri()
        {
            InitializeComponent();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MusteriListele();
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
            txt_AdSoyad.Text = "";
            txt_AdSoyadGuncelle.Text = "";
            txt_Eposta.Text = "";
            txt_EpostaGuncelle.Text = "";
            txt_Telefon.Text = "";
            txt_TelefonGuncelle.Text = "";
            rtxt_Adres.Text = "";
            rtxt_AdresGuncelle.Text = "";
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

        private void dgv_MusteriListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriId = Convert.ToInt32(dgv_MusteriListesi.CurrentRow.Cells[0].Value);
            txt_AdSoyadGuncelle.Text = dgv_MusteriListesi.CurrentRow.Cells[1].Value.ToString();
            txt_TelefonGuncelle.Text = dgv_MusteriListesi.CurrentRow.Cells[2].Value.ToString();
            txt_EpostaGuncelle.Text = dgv_MusteriListesi.CurrentRow.Cells[3].Value.ToString();
            rtxt_AdresGuncelle.Text = dgv_MusteriListesi.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_AdSoyad.Text == "" || txt_Eposta.Text == "" || txt_Telefon.Text == "" || rtxt_Adres.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }
                else
                {
                    baglan();
                    string ekle = "INSERT INTO Musteriler (AdSoyad , Telefon, Eposta, Adres) VALUES (@AdSoyad, @Telefon, @Eposta, @Adres)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@AdSoyad", txt_AdSoyad.Text);
                    komut.Parameters.AddWithValue("@Telefon", txt_Telefon.Text);
                    komut.Parameters.AddWithValue("@Eposta", txt_Eposta.Text);
                    komut.Parameters.AddWithValue("@Adres", rtxt_Adres.Text);
                    komut.ExecuteNonQuery();
                    baglanti_kapat();

                    MusteriListele();
                    InputTemizle();
                    MessageBox.Show("Müşteri Başarıyla Eklendi");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        private void btn_MusteriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_AdSoyadGuncelle.Text == "" || txt_EpostaGuncelle.Text == "" || txt_TelefonGuncelle.Text == "" || rtxt_AdresGuncelle.Text == "" || MusteriId == 0)
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }
                else
                {
                    baglan();
                    string guncelle = "UPDATE Musteriler SET AdSoyad = @AdSoyad , Telefon = @Telefon, Eposta = @Eposta, Adres = @Adres WHERE id = @id";
                    OleDbCommand komut = new OleDbCommand(guncelle, baglanti);
                    komut.Parameters.AddWithValue("@AdSoyad", txt_AdSoyadGuncelle.Text);
                    komut.Parameters.AddWithValue("@Telefon", txt_TelefonGuncelle.Text);
                    komut.Parameters.AddWithValue("@Eposta", txt_EpostaGuncelle.Text);
                    komut.Parameters.AddWithValue("@Adres", rtxt_AdresGuncelle.Text);
                    komut.Parameters.AddWithValue("@id", MusteriId);
                    komut.ExecuteNonQuery();
                    baglanti_kapat();

                    MusteriListele();
                    InputTemizle();
                    MessageBox.Show("Müşteri Başarıyla Güncellendi");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }
    }
}
