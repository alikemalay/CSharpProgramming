namespace Quiz_3
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
            this.lbCorbaBirim = new System.Windows.Forms.Label();
            this.lbYemekBirim = new System.Windows.Forms.Label();
            this.lbTatliBirim = new System.Windows.Forms.Label();
            this.txtCorba = new System.Windows.Forms.TextBox();
            this.txtYemek = new System.Windows.Forms.TextBox();
            this.txtTatli = new System.Windows.Forms.TextBox();
            this.lbCorbaAdet = new System.Windows.Forms.Label();
            this.lbYemekAdet = new System.Windows.Forms.Label();
            this.lbTatliAdet = new System.Windows.Forms.Label();
            this.lbCorbaToplam = new System.Windows.Forms.Label();
            this.lbYemekToplam = new System.Windows.Forms.Label();
            this.lbTatliToplam = new System.Windows.Forms.Label();
            this.cbBahsis = new System.Windows.Forms.CheckBox();
            this.lbGenelToplam = new System.Windows.Forms.Label();
            this.lbBahsis = new System.Windows.Forms.Label();
            this.lbToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCorbaBirim
            // 
            this.lbCorbaBirim.AutoSize = true;
            this.lbCorbaBirim.Location = new System.Drawing.Point(26, 17);
            this.lbCorbaBirim.Name = "lbCorbaBirim";
            this.lbCorbaBirim.Size = new System.Drawing.Size(124, 13);
            this.lbCorbaBirim.TabIndex = 0;
            this.lbCorbaBirim.Text = "Çorba (Birim Fiyatı 4.5TL)";
            // 
            // lbYemekBirim
            // 
            this.lbYemekBirim.AutoSize = true;
            this.lbYemekBirim.Location = new System.Drawing.Point(26, 43);
            this.lbYemekBirim.Name = "lbYemekBirim";
            this.lbYemekBirim.Size = new System.Drawing.Size(151, 13);
            this.lbYemekBirim.TabIndex = 1;
            this.lbYemekBirim.Text = "Ana Yemek (Birim Fiyatı 12 TL)";
            // 
            // lbTatliBirim
            // 
            this.lbTatliBirim.AutoSize = true;
            this.lbTatliBirim.Location = new System.Drawing.Point(26, 69);
            this.lbTatliBirim.Name = "lbTatliBirim";
            this.lbTatliBirim.Size = new System.Drawing.Size(110, 13);
            this.lbTatliBirim.TabIndex = 2;
            this.lbTatliBirim.Text = "Tatlı (Birim Fiyatı 2 TL)";
            // 
            // txtCorba
            // 
            this.txtCorba.Location = new System.Drawing.Point(247, 14);
            this.txtCorba.Name = "txtCorba";
            this.txtCorba.Size = new System.Drawing.Size(100, 20);
            this.txtCorba.TabIndex = 3;
            this.txtCorba.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtYemek
            // 
            this.txtYemek.Location = new System.Drawing.Point(247, 40);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.Size = new System.Drawing.Size(100, 20);
            this.txtYemek.TabIndex = 4;
            this.txtYemek.TextChanged += new System.EventHandler(this.txtYemek_TextChanged);
            // 
            // txtTatli
            // 
            this.txtTatli.Location = new System.Drawing.Point(247, 66);
            this.txtTatli.Name = "txtTatli";
            this.txtTatli.Size = new System.Drawing.Size(100, 20);
            this.txtTatli.TabIndex = 5;
            this.txtTatli.TextChanged += new System.EventHandler(this.txtTatli_TextChanged);
            // 
            // lbCorbaAdet
            // 
            this.lbCorbaAdet.AutoSize = true;
            this.lbCorbaAdet.Location = new System.Drawing.Point(206, 17);
            this.lbCorbaAdet.Name = "lbCorbaAdet";
            this.lbCorbaAdet.Size = new System.Drawing.Size(32, 13);
            this.lbCorbaAdet.TabIndex = 6;
            this.lbCorbaAdet.Text = "Adet:";
            // 
            // lbYemekAdet
            // 
            this.lbYemekAdet.AutoSize = true;
            this.lbYemekAdet.Location = new System.Drawing.Point(206, 43);
            this.lbYemekAdet.Name = "lbYemekAdet";
            this.lbYemekAdet.Size = new System.Drawing.Size(32, 13);
            this.lbYemekAdet.TabIndex = 7;
            this.lbYemekAdet.Text = "Adet:";
            // 
            // lbTatliAdet
            // 
            this.lbTatliAdet.AutoSize = true;
            this.lbTatliAdet.Location = new System.Drawing.Point(206, 69);
            this.lbTatliAdet.Name = "lbTatliAdet";
            this.lbTatliAdet.Size = new System.Drawing.Size(32, 13);
            this.lbTatliAdet.TabIndex = 8;
            this.lbTatliAdet.Text = "Adet:";
            // 
            // lbCorbaToplam
            // 
            this.lbCorbaToplam.AutoSize = true;
            this.lbCorbaToplam.Location = new System.Drawing.Point(377, 17);
            this.lbCorbaToplam.Name = "lbCorbaToplam";
            this.lbCorbaToplam.Size = new System.Drawing.Size(98, 13);
            this.lbCorbaToplam.TabIndex = 9;
            this.lbCorbaToplam.Text = "Toplam Fiyat : 0 TL";
            // 
            // lbYemekToplam
            // 
            this.lbYemekToplam.AutoSize = true;
            this.lbYemekToplam.Location = new System.Drawing.Point(377, 43);
            this.lbYemekToplam.Name = "lbYemekToplam";
            this.lbYemekToplam.Size = new System.Drawing.Size(98, 13);
            this.lbYemekToplam.TabIndex = 10;
            this.lbYemekToplam.Text = "Toplam Fiyat : 0 TL";
            // 
            // lbTatliToplam
            // 
            this.lbTatliToplam.AutoSize = true;
            this.lbTatliToplam.Location = new System.Drawing.Point(377, 69);
            this.lbTatliToplam.Name = "lbTatliToplam";
            this.lbTatliToplam.Size = new System.Drawing.Size(98, 13);
            this.lbTatliToplam.TabIndex = 11;
            this.lbTatliToplam.Text = "Toplam Fiyat : 0 TL";
            // 
            // cbBahsis
            // 
            this.cbBahsis.AutoSize = true;
            this.cbBahsis.Location = new System.Drawing.Point(247, 127);
            this.cbBahsis.Name = "cbBahsis";
            this.cbBahsis.Size = new System.Drawing.Size(98, 17);
            this.cbBahsis.TabIndex = 12;
            this.cbBahsis.Text = "Bahşiş Ekle %5";
            this.cbBahsis.UseVisualStyleBackColor = true;
            this.cbBahsis.CheckedChanged += new System.EventHandler(this.cbBahsis_CheckedChanged);
            // 
            // lbGenelToplam
            // 
            this.lbGenelToplam.AutoSize = true;
            this.lbGenelToplam.Location = new System.Drawing.Point(377, 96);
            this.lbGenelToplam.Name = "lbGenelToplam";
            this.lbGenelToplam.Size = new System.Drawing.Size(101, 13);
            this.lbGenelToplam.TabIndex = 13;
            this.lbGenelToplam.Text = "Genel Toplam : 0TL";
            // 
            // lbBahsis
            // 
            this.lbBahsis.AutoSize = true;
            this.lbBahsis.Location = new System.Drawing.Point(409, 128);
            this.lbBahsis.Name = "lbBahsis";
            this.lbBahsis.Size = new System.Drawing.Size(63, 13);
            this.lbBahsis.TabIndex = 14;
            this.lbBahsis.Text = "Bahşiş 0 TL";
            this.lbBahsis.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbToplam
            // 
            this.lbToplam.AutoSize = true;
            this.lbToplam.Location = new System.Drawing.Point(368, 162);
            this.lbToplam.Name = "lbToplam";
            this.lbToplam.Size = new System.Drawing.Size(107, 13);
            this.lbToplam.TabIndex = 15;
            this.lbToplam.Text = "Toplam Hesap : 0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 228);
            this.Controls.Add(this.lbToplam);
            this.Controls.Add(this.lbBahsis);
            this.Controls.Add(this.lbGenelToplam);
            this.Controls.Add(this.cbBahsis);
            this.Controls.Add(this.lbTatliToplam);
            this.Controls.Add(this.lbYemekToplam);
            this.Controls.Add(this.lbCorbaToplam);
            this.Controls.Add(this.lbTatliAdet);
            this.Controls.Add(this.lbYemekAdet);
            this.Controls.Add(this.lbCorbaAdet);
            this.Controls.Add(this.txtTatli);
            this.Controls.Add(this.txtYemek);
            this.Controls.Add(this.txtCorba);
            this.Controls.Add(this.lbTatliBirim);
            this.Controls.Add(this.lbYemekBirim);
            this.Controls.Add(this.lbCorbaBirim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCorbaBirim;
        private System.Windows.Forms.Label lbYemekBirim;
        private System.Windows.Forms.Label lbTatliBirim;
        private System.Windows.Forms.TextBox txtCorba;
        private System.Windows.Forms.TextBox txtYemek;
        private System.Windows.Forms.TextBox txtTatli;
        private System.Windows.Forms.Label lbCorbaAdet;
        private System.Windows.Forms.Label lbYemekAdet;
        private System.Windows.Forms.Label lbTatliAdet;
        private System.Windows.Forms.Label lbCorbaToplam;
        private System.Windows.Forms.Label lbYemekToplam;
        private System.Windows.Forms.Label lbTatliToplam;
        private System.Windows.Forms.CheckBox cbBahsis;
        private System.Windows.Forms.Label lbGenelToplam;
        private System.Windows.Forms.Label lbBahsis;
        private System.Windows.Forms.Label lbToplam;
    }
}

