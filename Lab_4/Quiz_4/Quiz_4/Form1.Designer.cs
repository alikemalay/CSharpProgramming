namespace Quiz_4
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.gBoxYasGrubu = new System.Windows.Forms.GroupBox();
            this.rbGenc = new System.Windows.Forms.RadioButton();
            this.rbYetiskin = new System.Windows.Forms.RadioButton();
            this.rbYasli = new System.Windows.Forms.RadioButton();
            this.btnListeyeEkle = new System.Windows.Forms.Button();
            this.btnCinsiyetIst = new System.Windows.Forms.Button();
            this.btnYasIst = new System.Windows.Forms.Button();
            this.rbList = new System.Windows.Forms.Label();
            this.gBoxCinsiyet.SuspendLayout();
            this.gBoxYasGrubu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(26, 40);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(214, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // gBoxCinsiyet
            // 
            this.gBoxCinsiyet.Controls.Add(this.rbKadin);
            this.gBoxCinsiyet.Controls.Add(this.rbErkek);
            this.gBoxCinsiyet.Location = new System.Drawing.Point(26, 87);
            this.gBoxCinsiyet.Name = "gBoxCinsiyet";
            this.gBoxCinsiyet.Size = new System.Drawing.Size(89, 100);
            this.gBoxCinsiyet.TabIndex = 2;
            this.gBoxCinsiyet.TabStop = false;
            this.gBoxCinsiyet.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(6, 30);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 3;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(6, 53);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 3;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // gBoxYasGrubu
            // 
            this.gBoxYasGrubu.Controls.Add(this.rbYasli);
            this.gBoxYasGrubu.Controls.Add(this.rbYetiskin);
            this.gBoxYasGrubu.Controls.Add(this.rbGenc);
            this.gBoxYasGrubu.Location = new System.Drawing.Point(131, 87);
            this.gBoxYasGrubu.Name = "gBoxYasGrubu";
            this.gBoxYasGrubu.Size = new System.Drawing.Size(109, 100);
            this.gBoxYasGrubu.TabIndex = 3;
            this.gBoxYasGrubu.TabStop = false;
            this.gBoxYasGrubu.Text = "Yaş Grubu";
            // 
            // rbGenc
            // 
            this.rbGenc.AutoSize = true;
            this.rbGenc.Location = new System.Drawing.Point(0, 19);
            this.rbGenc.Name = "rbGenc";
            this.rbGenc.Size = new System.Drawing.Size(87, 17);
            this.rbGenc.TabIndex = 0;
            this.rbGenc.TabStop = true;
            this.rbGenc.Text = "Genç ( < 27 )";
            this.rbGenc.UseVisualStyleBackColor = true;
            // 
            // rbYetiskin
            // 
            this.rbYetiskin.AutoSize = true;
            this.rbYetiskin.Location = new System.Drawing.Point(0, 42);
            this.rbYetiskin.Name = "rbYetiskin";
            this.rbYetiskin.Size = new System.Drawing.Size(98, 17);
            this.rbYetiskin.TabIndex = 1;
            this.rbYetiskin.TabStop = true;
            this.rbYetiskin.Text = "Yetişkin (27-64)";
            this.rbYetiskin.UseVisualStyleBackColor = true;
            // 
            // rbYasli
            // 
            this.rbYasli.AutoSize = true;
            this.rbYasli.Location = new System.Drawing.Point(0, 65);
            this.rbYasli.Name = "rbYasli";
            this.rbYasli.Size = new System.Drawing.Size(74, 17);
            this.rbYasli.TabIndex = 2;
            this.rbYasli.TabStop = true;
            this.rbYasli.Text = "Yaşlı (>64)";
            this.rbYasli.UseVisualStyleBackColor = true;
            // 
            // btnListeyeEkle
            // 
            this.btnListeyeEkle.Location = new System.Drawing.Point(26, 193);
            this.btnListeyeEkle.Name = "btnListeyeEkle";
            this.btnListeyeEkle.Size = new System.Drawing.Size(214, 23);
            this.btnListeyeEkle.TabIndex = 4;
            this.btnListeyeEkle.Text = "Listeye Ekle";
            this.btnListeyeEkle.UseVisualStyleBackColor = true;
            this.btnListeyeEkle.Click += new System.EventHandler(this.btnListeyeEkle_Click);
            // 
            // btnCinsiyetIst
            // 
            this.btnCinsiyetIst.Location = new System.Drawing.Point(26, 341);
            this.btnCinsiyetIst.Name = "btnCinsiyetIst";
            this.btnCinsiyetIst.Size = new System.Drawing.Size(214, 23);
            this.btnCinsiyetIst.TabIndex = 5;
            this.btnCinsiyetIst.Text = "Cinsiyet Istatistigi";
            this.btnCinsiyetIst.UseVisualStyleBackColor = true;
            this.btnCinsiyetIst.Click += new System.EventHandler(this.btnCinsiyetIst_Click);
            // 
            // btnYasIst
            // 
            this.btnYasIst.Location = new System.Drawing.Point(26, 370);
            this.btnYasIst.Name = "btnYasIst";
            this.btnYasIst.Size = new System.Drawing.Size(214, 23);
            this.btnYasIst.TabIndex = 6;
            this.btnYasIst.Text = "Yas Istatistigi";
            this.btnYasIst.UseVisualStyleBackColor = true;
            this.btnYasIst.Click += new System.EventHandler(this.btnYasIst_Click);
            // 
            // rbList
            // 
            this.rbList.Location = new System.Drawing.Point(29, 229);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(211, 109);
            this.rbList.TabIndex = 7;
            this.rbList.Text = "Liste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 409);
            this.Controls.Add(this.rbList);
            this.Controls.Add(this.btnYasIst);
            this.Controls.Add(this.btnCinsiyetIst);
            this.Controls.Add(this.btnListeyeEkle);
            this.Controls.Add(this.gBoxYasGrubu);
            this.Controls.Add(this.gBoxCinsiyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxCinsiyet.ResumeLayout(false);
            this.gBoxCinsiyet.PerformLayout();
            this.gBoxYasGrubu.ResumeLayout(false);
            this.gBoxYasGrubu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxCinsiyet;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.GroupBox gBoxYasGrubu;
        private System.Windows.Forms.RadioButton rbYasli;
        private System.Windows.Forms.RadioButton rbYetiskin;
        private System.Windows.Forms.RadioButton rbGenc;
        private System.Windows.Forms.Button btnListeyeEkle;
        private System.Windows.Forms.Button btnCinsiyetIst;
        private System.Windows.Forms.Button btnYasIst;
        private System.Windows.Forms.Label rbList;
    }
}

