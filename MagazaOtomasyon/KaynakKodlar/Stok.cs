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
    public partial class Stok : Form
    {
        public int StokId = 0;

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public Stok()
        {
            InitializeComponent();
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            txtMiktar.Text = "";
            txt_MiktarGuncelle.Text = "";
            txt_StokAdi.Text = "";
            txt_StokAdiGuncelle.Text = "";
            rb_Depo.Checked = false;
            rb_DepoGuncelle.Checked = false;
            rb_Raf.Checked = false;
            rb_RafGuncelle.Checked = false;
            txt_Fiyat.Text = "";
            txt_FiyatGuncelle.Text = "";
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

        private void dgv_UrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StokId = Convert.ToInt32(dgv_UrunListesi.CurrentRow.Cells[0].Value);
            txt_StokAdiGuncelle.Text = dgv_UrunListesi.CurrentRow.Cells[1].Value.ToString();
            txt_MiktarGuncelle.Text = dgv_UrunListesi.CurrentRow.Cells[2].Value.ToString();
            txt_FiyatGuncelle.Text = dgv_UrunListesi.CurrentRow.Cells[4].Value.ToString();

            if (Convert.ToInt32(dgv_UrunListesi.CurrentRow.Cells[3].Value) == 1)
            {
                rb_DepoGuncelle.Checked = true;
            }
            else
            {
                rb_RafGuncelle.Checked = true;
            }
        }

        private void btn_StokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_StokAdi.Text == "" || txtMiktar.Text == "" || txt_Fiyat.Text == "" || (rb_Depo.Checked == false && rb_Raf.Checked == false))
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }
                else
                {
                    int depo = 0;
                    if (rb_Depo.Checked == true)
                    {
                        depo = 1;
                    }
                    else
                    {
                        depo = 0;
                    }

                    baglan();
                    string ekle = "INSERT INTO Stoklar (UrunAdi , StokMiktari, Depo, Fiyat) VALUES (@UrunAdi, @StokMiktari, @Depo, @Fiyat)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);
                    komut.Parameters.AddWithValue("@UrunAdi", txt_StokAdi.Text);
                    komut.Parameters.AddWithValue("@StokMiktari", txtMiktar.Text);
                    komut.Parameters.AddWithValue("@Depo", depo);
                    komut.Parameters.AddWithValue("@Fiyat", txt_Fiyat.Text);
                    komut.ExecuteNonQuery();
                    baglanti_kapat();

                    StokListele();
                    InputTemizle();
                    MessageBox.Show("Stok Başarıyla Eklendi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Edin!");
            }
        }

        private void btn_StokGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_StokAdiGuncelle.Text == "" || txt_FiyatGuncelle.Text == "" || txt_MiktarGuncelle.Text == "" || StokId == 0 || (rb_DepoGuncelle.Checked == false && rb_RafGuncelle.Checked == false))
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun !");
                }
                else
                {
                    int depo = 0;
                    if (rb_DepoGuncelle.Checked == true)
                    {
                        depo = 1;
                    }
                    else
                    {
                        depo = 0;
                    }

                    baglan();
                    string guncelle = "UPDATE Stoklar SET UrunAdi = @UrunAdi , StokMiktari =  @StokMiktari , Depo = @Depo , Fiyat = @Fiyat WHERE id = @id";
                    OleDbCommand komut = new OleDbCommand(guncelle, baglanti);
                    komut.Parameters.AddWithValue("@UrunAdi", txt_StokAdiGuncelle.Text);
                    komut.Parameters.AddWithValue("@StokMiktari", txt_MiktarGuncelle.Text);
                    komut.Parameters.AddWithValue("@Depo", depo);
                    komut.Parameters.AddWithValue("@Fiyat", txt_FiyatGuncelle.Text);
                    komut.Parameters.AddWithValue("@id", StokId);
                    komut.ExecuteNonQuery();
                    baglanti_kapat();

                    StokListele();
                    InputTemizle();
                    MessageBox.Show("Stok Başarıyla Güncellendi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Girdiğiniz Değerleri Kontrol Edin!");
            }
        }
    }
}
