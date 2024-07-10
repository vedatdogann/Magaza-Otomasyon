
namespace odev
{
    partial class Satis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_SiparisVer = new System.Windows.Forms.Button();
            this.nud_StokSayisi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_UrunListesi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_MusteriListesi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StokSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MusteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mağaza Stok - Satış";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 65);
            this.panel1.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(10, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 30);
            this.label19.TabIndex = 9;
            this.label19.Text = "Satış İşlemi";
            // 
            // btn_SiparisVer
            // 
            this.btn_SiparisVer.Location = new System.Drawing.Point(783, 584);
            this.btn_SiparisVer.Name = "btn_SiparisVer";
            this.btn_SiparisVer.Size = new System.Drawing.Size(106, 31);
            this.btn_SiparisVer.TabIndex = 47;
            this.btn_SiparisVer.Text = "Satış Yap";
            this.btn_SiparisVer.UseVisualStyleBackColor = true;
            this.btn_SiparisVer.Click += new System.EventHandler(this.btn_SiparisVer_Click);
            // 
            // nud_StokSayisi
            // 
            this.nud_StokSayisi.Location = new System.Drawing.Point(713, 163);
            this.nud_StokSayisi.Name = "nud_StokSayisi";
            this.nud_StokSayisi.Size = new System.Drawing.Size(176, 23);
            this.nud_StokSayisi.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(713, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Satış Yapılacak Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Lütfen Ürün Seçin";
            // 
            // dgv_UrunListesi
            // 
            this.dgv_UrunListesi.AllowUserToAddRows = false;
            this.dgv_UrunListesi.AllowUserToDeleteRows = false;
            this.dgv_UrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UrunListesi.Location = new System.Drawing.Point(365, 154);
            this.dgv_UrunListesi.Name = "dgv_UrunListesi";
            this.dgv_UrunListesi.RowTemplate.Height = 25;
            this.dgv_UrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UrunListesi.Size = new System.Drawing.Size(317, 461);
            this.dgv_UrunListesi.TabIndex = 43;
            this.dgv_UrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UrunListesi_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Lütfen Müşteri Seçin";
            // 
            // dgv_MusteriListesi
            // 
            this.dgv_MusteriListesi.AllowUserToAddRows = false;
            this.dgv_MusteriListesi.AllowUserToDeleteRows = false;
            this.dgv_MusteriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MusteriListesi.Location = new System.Drawing.Point(10, 154);
            this.dgv_MusteriListesi.Name = "dgv_MusteriListesi";
            this.dgv_MusteriListesi.RowTemplate.Height = 25;
            this.dgv_MusteriListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MusteriListesi.Size = new System.Drawing.Size(317, 461);
            this.dgv_MusteriListesi.TabIndex = 41;
            this.dgv_MusteriListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MusteriListesi_CellClick);
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 634);
            this.Controls.Add(this.btn_SiparisVer);
            this.Controls.Add(this.nud_StokSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_UrunListesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_MusteriListesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.Satis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StokSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MusteriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_SiparisVer;
        private System.Windows.Forms.NumericUpDown nud_StokSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_UrunListesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_MusteriListesi;
    }
}