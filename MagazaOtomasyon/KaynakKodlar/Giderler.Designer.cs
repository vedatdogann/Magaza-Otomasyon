
namespace odev
{
    partial class Giderler
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GiderTuru = new System.Windows.Forms.TextBox();
            this.txt_GiderTutari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GiderKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mağaza Stok - Satış";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(-2, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 65);
            this.panel1.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(10, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 30);
            this.label19.TabIndex = 9;
            this.label19.Text = "Gider İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gider Türü : ";
            // 
            // txt_GiderTuru
            // 
            this.txt_GiderTuru.Location = new System.Drawing.Point(110, 134);
            this.txt_GiderTuru.Name = "txt_GiderTuru";
            this.txt_GiderTuru.Size = new System.Drawing.Size(206, 23);
            this.txt_GiderTuru.TabIndex = 22;
            // 
            // txt_GiderTutari
            // 
            this.txt_GiderTutari.Location = new System.Drawing.Point(110, 163);
            this.txt_GiderTutari.Name = "txt_GiderTutari";
            this.txt_GiderTutari.Size = new System.Drawing.Size(206, 23);
            this.txt_GiderTutari.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gider Tutarı : ";
            // 
            // btn_GiderKaydet
            // 
            this.btn_GiderKaydet.Location = new System.Drawing.Point(204, 192);
            this.btn_GiderKaydet.Name = "btn_GiderKaydet";
            this.btn_GiderKaydet.Size = new System.Drawing.Size(112, 23);
            this.btn_GiderKaydet.TabIndex = 25;
            this.btn_GiderKaydet.Text = "Gider Kaydet";
            this.btn_GiderKaydet.UseVisualStyleBackColor = true;
            this.btn_GiderKaydet.Click += new System.EventHandler(this.btn_GiderKaydet_Click);
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 248);
            this.Controls.Add(this.btn_GiderKaydet);
            this.Controls.Add(this.txt_GiderTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_GiderTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_GiderTuru;
        private System.Windows.Forms.TextBox txt_GiderTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GiderKaydet;
    }
}