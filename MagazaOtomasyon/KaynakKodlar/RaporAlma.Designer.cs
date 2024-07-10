
namespace odev
{
    partial class RaporAlma
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
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RaftakiUrunler = new System.Windows.Forms.Button();
            this.btn_DepodakiUrunler = new System.Windows.Forms.Button();
            this.btn_GelirGiderRaporu = new System.Windows.Forms.Button();
            this.btn_SiparisRaporu = new System.Windows.Forms.Button();
            this.btn_SatisRaporu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mağaza Stok - Satış";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(20, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Rapor Alma Sayfası";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(1, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 65);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RaftakiUrunler);
            this.groupBox1.Controls.Add(this.btn_DepodakiUrunler);
            this.groupBox1.Controls.Add(this.btn_GelirGiderRaporu);
            this.groupBox1.Controls.Add(this.btn_SiparisRaporu);
            this.groupBox1.Controls.Add(this.btn_SatisRaporu);
            this.groupBox1.Location = new System.Drawing.Point(218, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 223);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raporlar";
            // 
            // btn_RaftakiUrunler
            // 
            this.btn_RaftakiUrunler.Location = new System.Drawing.Point(9, 148);
            this.btn_RaftakiUrunler.Name = "btn_RaftakiUrunler";
            this.btn_RaftakiUrunler.Size = new System.Drawing.Size(381, 23);
            this.btn_RaftakiUrunler.TabIndex = 4;
            this.btn_RaftakiUrunler.Text = "Raftaki Ürünler";
            this.btn_RaftakiUrunler.UseVisualStyleBackColor = true;
            this.btn_RaftakiUrunler.Click += new System.EventHandler(this.btn_RaftakiUrunler_Click);
            // 
            // btn_DepodakiUrunler
            // 
            this.btn_DepodakiUrunler.Location = new System.Drawing.Point(9, 119);
            this.btn_DepodakiUrunler.Name = "btn_DepodakiUrunler";
            this.btn_DepodakiUrunler.Size = new System.Drawing.Size(381, 23);
            this.btn_DepodakiUrunler.TabIndex = 3;
            this.btn_DepodakiUrunler.Text = "Depodaki Ürünler";
            this.btn_DepodakiUrunler.UseVisualStyleBackColor = true;
            this.btn_DepodakiUrunler.Click += new System.EventHandler(this.btn_DepodakiUrunler_Click);
            // 
            // btn_GelirGiderRaporu
            // 
            this.btn_GelirGiderRaporu.Location = new System.Drawing.Point(9, 90);
            this.btn_GelirGiderRaporu.Name = "btn_GelirGiderRaporu";
            this.btn_GelirGiderRaporu.Size = new System.Drawing.Size(381, 23);
            this.btn_GelirGiderRaporu.TabIndex = 2;
            this.btn_GelirGiderRaporu.Text = "Günlük Gelir Gider Raporu";
            this.btn_GelirGiderRaporu.UseVisualStyleBackColor = true;
            this.btn_GelirGiderRaporu.Click += new System.EventHandler(this.btn_GelirGiderRaporu_Click);
            // 
            // btn_SiparisRaporu
            // 
            this.btn_SiparisRaporu.Location = new System.Drawing.Point(9, 61);
            this.btn_SiparisRaporu.Name = "btn_SiparisRaporu";
            this.btn_SiparisRaporu.Size = new System.Drawing.Size(381, 23);
            this.btn_SiparisRaporu.TabIndex = 1;
            this.btn_SiparisRaporu.Text = "Günlük Sipariş Raporu";
            this.btn_SiparisRaporu.UseVisualStyleBackColor = true;
            this.btn_SiparisRaporu.Click += new System.EventHandler(this.btn_SiparisRaporu_Click);
            // 
            // btn_SatisRaporu
            // 
            this.btn_SatisRaporu.Location = new System.Drawing.Point(9, 32);
            this.btn_SatisRaporu.Name = "btn_SatisRaporu";
            this.btn_SatisRaporu.Size = new System.Drawing.Size(381, 23);
            this.btn_SatisRaporu.TabIndex = 0;
            this.btn_SatisRaporu.Text = "Günlük Satış Raporu";
            this.btn_SatisRaporu.UseVisualStyleBackColor = true;
            this.btn_SatisRaporu.Click += new System.EventHandler(this.btn_SatisRaporu_Click);
            // 
            // RaporAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaporAlma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.RaporAlma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GelirGiderRaporu;
        private System.Windows.Forms.Button btn_SiparisRaporu;
        private System.Windows.Forms.Button btn_SatisRaporu;
        private System.Windows.Forms.Button btn_DepodakiUrunler;
        private System.Windows.Forms.Button btn_RaftakiUrunler;
    }
}