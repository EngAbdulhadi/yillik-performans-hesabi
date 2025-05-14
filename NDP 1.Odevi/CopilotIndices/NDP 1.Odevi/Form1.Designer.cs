namespace NDP_1.Odevi
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.Yiyecek = new System.Windows.Forms.ComboBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtCinsi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtKalori = new System.Windows.Forms.TextBox();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(84, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Adi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(75, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cinsi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(79, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fiati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(56, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "KDV Orani :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(75, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kalori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(46, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Yiyecek seciniz :";
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnYazdir.Location = new System.Drawing.Point(187, 581);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(98, 31);
            this.btnYazdir.TabIndex = 21;
            this.btnYazdir.Text = "Yazdir";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEkle.Location = new System.Drawing.Point(59, 581);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 31);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Yiyecek
            // 
            this.Yiyecek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Yiyecek.FormattingEnabled = true;
            this.Yiyecek.Location = new System.Drawing.Point(162, 97);
            this.Yiyecek.Name = "Yiyecek";
            this.Yiyecek.Size = new System.Drawing.Size(263, 24);
            this.Yiyecek.TabIndex = 16;
            // 
            // txtAdi
            // 
            this.txtAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAdi.Location = new System.Drawing.Point(162, 171);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(263, 22);
            this.txtAdi.TabIndex = 32;
            // 
            // txtCinsi
            // 
            this.txtCinsi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCinsi.Location = new System.Drawing.Point(162, 252);
            this.txtCinsi.Name = "txtCinsi";
            this.txtCinsi.Size = new System.Drawing.Size(263, 22);
            this.txtCinsi.TabIndex = 33;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFiyat.Location = new System.Drawing.Point(162, 329);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(263, 22);
            this.txtFiyat.TabIndex = 34;
            // 
            // txtKdv
            // 
            this.txtKdv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKdv.Location = new System.Drawing.Point(162, 397);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(263, 22);
            this.txtKdv.TabIndex = 35;
            // 
            // txtKalori
            // 
            this.txtKalori.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKalori.Location = new System.Drawing.Point(162, 485);
            this.txtKalori.Name = "txtKalori";
            this.txtKalori.Size = new System.Drawing.Size(263, 22);
            this.txtKalori.TabIndex = 36;
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 16;
            this.listBoxMenu.Location = new System.Drawing.Point(537, 63);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(471, 468);
            this.listBoxMenu.TabIndex = 37;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSil.Location = new System.Drawing.Point(327, 581);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 31);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(551, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 32);
            this.label7.TabIndex = 39;
            this.label7.Text = "Yemek Menüsü";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTotal.Location = new System.Drawing.Point(554, 548);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1125, 687);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.txtKalori);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtCinsi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.Yiyecek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox Yiyecek;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtCinsi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtKalori;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
    }
}

