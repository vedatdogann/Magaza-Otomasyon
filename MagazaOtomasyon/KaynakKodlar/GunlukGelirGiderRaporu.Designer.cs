
namespace odev
{
    partial class GunlukGelirGiderRaporu
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
            this.lbl_rapor_bilgisi = new System.Windows.Forms.Label();
            this.dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_GelirlerToplami = new System.Windows.Forms.Label();
            this.lbl_GiderlerToplami = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mağaza Stok - Satış";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lbl_rapor_bilgisi);
            this.panel1.Location = new System.Drawing.Point(1, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 65);
            this.panel1.TabIndex = 23;
            // 
            // lbl_rapor_bilgisi
            // 
            this.lbl_rapor_bilgisi.AutoSize = true;
            this.lbl_rapor_bilgisi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rapor_bilgisi.ForeColor = System.Drawing.Color.White;
            this.lbl_rapor_bilgisi.Location = new System.Drawing.Point(20, 23);
            this.lbl_rapor_bilgisi.Name = "lbl_rapor_bilgisi";
            this.lbl_rapor_bilgisi.Size = new System.Drawing.Size(173, 25);
            this.lbl_rapor_bilgisi.TabIndex = 0;
            this.lbl_rapor_bilgisi.Text = "Rapor Alma Sayfası";
            // 
            // dtp_Tarih
            // 
            this.dtp_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Tarih.Location = new System.Drawing.Point(97, 134);
            this.dtp_Tarih.Name = "dtp_Tarih";
            this.dtp_Tarih.Size = new System.Drawing.Size(200, 23);
            this.dtp_Tarih.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Rapor Tarihi : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Rapor Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Gelirler Toplamı : ";
            // 
            // lbl_GelirlerToplami
            // 
            this.lbl_GelirlerToplami.AutoSize = true;
            this.lbl_GelirlerToplami.Location = new System.Drawing.Point(117, 183);
            this.lbl_GelirlerToplami.Name = "lbl_GelirlerToplami";
            this.lbl_GelirlerToplami.Size = new System.Drawing.Size(28, 15);
            this.lbl_GelirlerToplami.TabIndex = 30;
            this.lbl_GelirlerToplami.Text = "0 TL";
            // 
            // lbl_GiderlerToplami
            // 
            this.lbl_GiderlerToplami.AutoSize = true;
            this.lbl_GiderlerToplami.Location = new System.Drawing.Point(117, 207);
            this.lbl_GiderlerToplami.Name = "lbl_GiderlerToplami";
            this.lbl_GiderlerToplami.Size = new System.Drawing.Size(28, 15);
            this.lbl_GiderlerToplami.TabIndex = 32;
            this.lbl_GiderlerToplami.Text = "0 TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Giderler Toplamı :";
            // 
            // GunlukGelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 432);
            this.Controls.Add(this.lbl_GiderlerToplami);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_GelirlerToplami);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_Tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GunlukGelirGiderRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günlük Gelirler ve Giderler Toplamı";
            this.Load += new System.EventHandler(this.GunlukGelirGiderRaporu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_rapor_bilgisi;
        private System.Windows.Forms.DateTimePicker dtp_Tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_GelirlerToplami;
        private System.Windows.Forms.Label lbl_GiderlerToplami;
        private System.Windows.Forms.Label label6;
    }
}