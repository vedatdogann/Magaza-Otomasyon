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
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void anaEkran_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            RaporAlma frm = new RaporAlma();
            frm.ShowDialog();
        }

        private void btn_Tedarik_Click(object sender, EventArgs e)
        {
            Tedarik frm = new Tedarik();
            frm.ShowDialog();
        }

        private void btn_Stoklar_Click(object sender, EventArgs e)
        {
            Stok frm = new Stok();
            frm.ShowDialog();
        }

        private void btn_MusteriListesi_Click(object sender, EventArgs e)
        {
            Musteri frm = new Musteri();
            frm.ShowDialog();
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            Satis frm = new Satis();
            frm.ShowDialog();
        }

        private void btn_Giderler_Click(object sender, EventArgs e)
        {
            Giderler frm = new Giderler();
            frm.ShowDialog();
        }
    }
}
