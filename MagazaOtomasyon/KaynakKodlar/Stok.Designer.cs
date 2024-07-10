
namespace odev
{
    partial class Stok
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_RafGuncelle = new System.Windows.Forms.RadioButton();
            this.rb_DepoGuncelle = new System.Windows.Forms.RadioButton();
            this.txt_MiktarGuncelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StokAdiGuncelle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_StokGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_UrunListesi = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Raf = new System.Windows.Forms.RadioButton();
            this.rb_Depo = new System.Windows.Forms.RadioButton();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_StokAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_StokEkle = new System.Windows.Forms.Button();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_FiyatGuncelle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(-19, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 65);
            this.panel1.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(37, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 30);
            this.label19.TabIndex = 9;
            this.label19.Text = "Stok İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mağaza Stok - Satış";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_StokGuncelle);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dgv_UrunListesi);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(737, 500);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Stok Listele - Düzenle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_FiyatGuncelle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rb_RafGuncelle);
            this.groupBox2.Controls.Add(this.rb_DepoGuncelle);
            this.groupBox2.Controls.Add(this.txt_MiktarGuncelle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_StokAdiGuncelle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(360, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 179);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok Bilgileri";
            // 
            // rb_RafGuncelle
            // 
            this.rb_RafGuncelle.AutoSize = true;
            this.rb_RafGuncelle.Location = new System.Drawing.Point(163, 144);
            this.rb_RafGuncelle.Name = "rb_RafGuncelle";
            this.rb_RafGuncelle.Size = new System.Drawing.Size(42, 19);
            this.rb_RafGuncelle.TabIndex = 21;
            this.rb_RafGuncelle.TabStop = true;
            this.rb_RafGuncelle.Text = "Raf";
            this.rb_RafGuncelle.UseVisualStyleBackColor = true;
            // 
            // rb_DepoGuncelle
            // 
            this.rb_DepoGuncelle.AutoSize = true;
            this.rb_DepoGuncelle.Location = new System.Drawing.Point(104, 144);
            this.rb_DepoGuncelle.Name = "rb_DepoGuncelle";
            this.rb_DepoGuncelle.Size = new System.Drawing.Size(53, 19);
            this.rb_DepoGuncelle.TabIndex = 20;
            this.rb_DepoGuncelle.TabStop = true;
            this.rb_DepoGuncelle.Text = "Depo";
            this.rb_DepoGuncelle.UseVisualStyleBackColor = true;
            // 
            // txt_MiktarGuncelle
            // 
            this.txt_MiktarGuncelle.Location = new System.Drawing.Point(104, 72);
            this.txt_MiktarGuncelle.Name = "txt_MiktarGuncelle";
            this.txt_MiktarGuncelle.Size = new System.Drawing.Size(191, 23);
            this.txt_MiktarGuncelle.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adı :";
            // 
            // txt_StokAdiGuncelle
            // 
            this.txt_StokAdiGuncelle.Location = new System.Drawing.Point(104, 43);
            this.txt_StokAdiGuncelle.Name = "txt_StokAdiGuncelle";
            this.txt_StokAdiGuncelle.Size = new System.Drawing.Size(191, 23);
            this.txt_StokAdiGuncelle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Miktarı :";
            // 
            // btn_StokGuncelle
            // 
            this.btn_StokGuncelle.Location = new System.Drawing.Point(589, 216);
            this.btn_StokGuncelle.Name = "btn_StokGuncelle";
            this.btn_StokGuncelle.Size = new System.Drawing.Size(119, 23);
            this.btn_StokGuncelle.TabIndex = 41;
            this.btn_StokGuncelle.Text = "Stok Güncelle";
            this.btn_StokGuncelle.UseVisualStyleBackColor = true;
            this.btn_StokGuncelle.Click += new System.EventHandler(this.btn_StokGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lütfen Düzenlemek İstediğiniz Stoğu Aşağıdan Seçin";
            // 
            // dgv_UrunListesi
            // 
            this.dgv_UrunListesi.AllowUserToAddRows = false;
            this.dgv_UrunListesi.AllowUserToDeleteRows = false;
            this.dgv_UrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UrunListesi.Location = new System.Drawing.Point(14, 31);
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
            this.tabControl1.Size = new System.Drawing.Size(745, 528);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_StokEkle);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(737, 500);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Stok Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Fiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rb_Raf);
            this.groupBox1.Controls.Add(this.rb_Depo);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_StokAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(191, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 163);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Bilgileri";
            // 
            // rb_Raf
            // 
            this.rb_Raf.AutoSize = true;
            this.rb_Raf.Location = new System.Drawing.Point(163, 130);
            this.rb_Raf.Name = "rb_Raf";
            this.rb_Raf.Size = new System.Drawing.Size(42, 19);
            this.rb_Raf.TabIndex = 21;
            this.rb_Raf.TabStop = true;
            this.rb_Raf.Text = "Raf";
            this.rb_Raf.UseVisualStyleBackColor = true;
            // 
            // rb_Depo
            // 
            this.rb_Depo.AutoSize = true;
            this.rb_Depo.Location = new System.Drawing.Point(104, 130);
            this.rb_Depo.Name = "rb_Depo";
            this.rb_Depo.Size = new System.Drawing.Size(53, 19);
            this.rb_Depo.TabIndex = 20;
            this.rb_Depo.TabStop = true;
            this.rb_Depo.Text = "Depo";
            this.rb_Depo.UseVisualStyleBackColor = true;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(104, 72);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(191, 23);
            this.txtMiktar.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stok Adı :";
            // 
            // txt_StokAdi
            // 
            this.txt_StokAdi.Location = new System.Drawing.Point(104, 43);
            this.txt_StokAdi.Name = "txt_StokAdi";
            this.txt_StokAdi.Size = new System.Drawing.Size(191, 23);
            this.txt_StokAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Miktarı :";
            // 
            // btn_StokEkle
            // 
            this.btn_StokEkle.Location = new System.Drawing.Point(420, 280);
            this.btn_StokEkle.Name = "btn_StokEkle";
            this.btn_StokEkle.Size = new System.Drawing.Size(119, 23);
            this.btn_StokEkle.TabIndex = 22;
            this.btn_StokEkle.Text = "Stok Ekle";
            this.btn_StokEkle.UseVisualStyleBackColor = true;
            this.btn_StokEkle.Click += new System.EventHandler(this.btn_StokEkle_Click);
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(104, 101);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(191, 23);
            this.txt_Fiyat.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fiyatı :";
            // 
            // txt_FiyatGuncelle
            // 
            this.txt_FiyatGuncelle.Location = new System.Drawing.Point(104, 101);
            this.txt_FiyatGuncelle.Name = "txt_FiyatGuncelle";
            this.txt_FiyatGuncelle.Size = new System.Drawing.Size(191, 23);
            this.txt_FiyatGuncelle.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fiyatı :";
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stok_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UrunListesi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_UrunListesi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Raf;
        private System.Windows.Forms.RadioButton rb_Depo;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_StokAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_StokEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_RafGuncelle;
        private System.Windows.Forms.RadioButton rb_DepoGuncelle;
        private System.Windows.Forms.TextBox txt_MiktarGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StokAdiGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_StokGuncelle;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FiyatGuncelle;
        private System.Windows.Forms.Label label7;
    }
}