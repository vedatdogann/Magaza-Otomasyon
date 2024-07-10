using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace odev
{
    public partial class RaporAlma : Form
    {
        public RaporAlma()
        {
            InitializeComponent();
        }

        private void RaporAlma_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_SatisRaporu_Click(object sender, EventArgs e)
        {
            GunlukSatisRaporu frm = new GunlukSatisRaporu();
            frm.ShowDialog();
        }

        private void btn_SiparisRaporu_Click(object sender, EventArgs e)
        {
            GunlukSiparisRaporu frm = new GunlukSiparisRaporu();
            frm.ShowDialog();
        }

        private void btn_GelirGiderRaporu_Click(object sender, EventArgs e)
        {
            GunlukGelirGiderRaporu frm = new GunlukGelirGiderRaporu();
            frm.ShowDialog();
        }

        private void btn_DepodakiUrunler_Click(object sender, EventArgs e)
        {
            DepodakiUrunlerRaporu frm = new DepodakiUrunlerRaporu();
            frm.ShowDialog();
        }

        private void btn_RaftakiUrunler_Click(object sender, EventArgs e)
        {
            RaftakiUrunlerRaporu frm = new RaftakiUrunlerRaporu();
            frm.ShowDialog();
        }
    }
}
