
namespace odev
{
    partial class Tedarik
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
            this.dgv_TedarikciListesi = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_FirmaAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_SiparisVer = new System.Windows.Forms.Button();
            this.nud_StokSayisi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_UrunListesi = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxt_Adres = new System.Windows.Forms.RichTextBox();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TedarikciListesi)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StokSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TedarikciListesi
            // 
            this.dgv_TedarikciListesi.AllowUserToAddRows = false;
            this.dgv_TedarikciListesi.AllowUserToDeleteRows = false;
            this.dgv_TedarikciListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TedarikciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TedarikciListesi.Location = new System.Drawing.Point(8, 31);
            this.dgv_TedarikciListesi.Name = "dgv_TedarikciListesi";
            this.dgv_TedarikciListesi.RowTemplate.Height = 25;
            this.dgv_TedarikciListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TedarikciListesi.Size = new System.Drawing.Size(317, 461);
            this.dgv_TedarikciListesi.TabIndex = 17;
            this.dgv_TedarikciListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TedarikciListesi_CellClick);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(519, 314);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(119, 23);
            this.btn_Ekle.TabIndex = 17;
            this.btn_Ekle.Text = "Tedarikçi Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_FirmaAdi
            // 
            this.txt_FirmaAdi.Location = new System.Drawing.Point(104, 43);
            this.txt_FirmaAdi.Name = "txt_FirmaAdi";
            this.txt_FirmaAdi.Size = new System.Drawing.Size(191, 23);
            this.txt_FirmaAdi.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Firma Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Lütfen Aşağıdan Sipariş Vermek İstediğiniz Tedarikçiyi Seçin";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_SiparisVer);
            this.tabPage1.Controls.Add(this.nud_StokSayisi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dgv_UrunListesi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_TedarikciListesi);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(968, 500);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Sipariş Ver";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_SiparisVer
            // 
            this.btn_SiparisVer.Location = new System.Drawing.Point(854, 461);
            this.btn_SiparisVer.Name = "btn_SiparisVer";
            this.btn_SiparisVer.Size = new System.Drawing.Size(106, 31);
            this.btn_SiparisVer.TabIndex = 40;
            this.btn_SiparisVer.Text = "Sipariş Ver";
            this.btn_SiparisVer.UseVisualStyleBackColor = true;
            this.btn_SiparisVer.Click += new System.EventHandler(this.btn_SiparisVer_Click);
            // 
            // nud_StokSayisi
            // 
            this.nud_StokSayisi.Location = new System.Drawing.Point(738, 40);
            this.nud_StokSayisi.Name = "nud_StokSayisi";
            this.nud_StokSayisi.Size = new System.Drawing.Size(176, 23);
            this.nud_StokSayisi.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(738, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sipariş Vermek İstediğiniz Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lütfen Aşağıdan Sipariş Vermek İstediğiniz Ürünü Seçin";
            // 
            // dgv_UrunListesi
            // 
            this.dgv_UrunListesi.AllowUserToAddRows = false;
            this.dgv_UrunListesi.AllowUserToDeleteRows = false;
            this.dgv_UrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UrunListesi.Location = new System.Drawing.Point(363, 31);
            this.dgv_UrunListesi.Name = "dgv_UrunListesi";
            this.dgv_UrunListesi.RowTemplate.Height = 25;
            this.dgv_UrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UrunListesi.Size = new System.Drawing.Size(317, 461);
            this.dgv_UrunListesi.TabIndex = 36;
            this.dgv_UrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UrunListesi_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 528);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_Ekle);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tedarikçi Ekle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxt_Adres);
            this.groupBox1.Controls.Add(this.txt_Eposta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Telefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_FirmaAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(290, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 256);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Bilgileri";
            // 
            // rtxt_Adres
            // 
            this.rtxt_Adres.Location = new System.Drawing.Point(104, 131);
            this.rtxt_Adres.Name = "rtxt_Adres";
            this.rtxt_Adres.Size = new System.Drawing.Size(191, 96);
            this.rtxt_Adres.TabIndex = 21;
            this.rtxt_Adres.Text = "";
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(104, 101);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(191, 23);
            this.txt_Eposta.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Adres :";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(104, 72);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(191, 23);
            this.txt_Telefon.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "E-Posta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Telefon :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mağaza Stok - Satış";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(37, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 30);
            this.label19.TabIndex = 9;
            this.label19.Text = "Tedarik İşlemleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(-21, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 65);
            this.panel1.TabIndex = 9;
            // 
            // Tedarik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 649);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tedarik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarik";
            this.Load += new System.EventHandler(this.Tedarik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TedarikciListesi)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_StokSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_TedarikciListesi;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_FirmaAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxt_Adres;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SiparisVer;
        private System.Windows.Forms.NumericUpDown nud_StokSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_UrunListesi;
    }
}