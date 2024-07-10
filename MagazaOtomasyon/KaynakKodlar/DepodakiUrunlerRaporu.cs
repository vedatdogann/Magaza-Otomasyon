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
    public partial class DepodakiUrunlerRaporu : Form
    {

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/odev.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public DepodakiUrunlerRaporu()
        {
            InitializeComponent();
        }

        private void DepodakiUrunlerRaporu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lbl_rapor_bilgisi.Text = "Depodaki Ürünler Raporu";
            listele();
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

                string sorgu = "SELECT * FROM Stoklar WHERE depo = 1";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridView1.DataSource = dt;
                baglanti_kapat();

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message.ToString());
            }
        }

    }
}
