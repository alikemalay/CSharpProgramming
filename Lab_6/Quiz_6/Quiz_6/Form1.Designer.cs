namespace Quiz_6
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
            this.components = new System.ComponentModel.Container();
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.listBoxImage = new System.Windows.Forms.ListBox();
            this.btnfotoEkle = new System.Windows.Forms.Button();
            this.btnFotoSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timerImage
            // 
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picBox
            // 
            this.picBox.ImageLocation = "";
            this.picBox.Location = new System.Drawing.Point(53, 27);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(197, 263);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(53, 296);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(89, 23);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(161, 296);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(89, 23);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // listBoxImage
            // 
            this.listBoxImage.FormattingEnabled = true;
            this.listBoxImage.Location = new System.Drawing.Point(306, 27);
            this.listBoxImage.Name = "listBoxImage";
            this.listBoxImage.Size = new System.Drawing.Size(197, 264);
            this.listBoxImage.TabIndex = 3;
            this.listBoxImage.SelectedIndexChanged += new System.EventHandler(this.listBoxImage_SelectedIndexChanged);
            // 
            // btnfotoEkle
            // 
            this.btnfotoEkle.Location = new System.Drawing.Point(306, 297);
            this.btnfotoEkle.Name = "btnfotoEkle";
            this.btnfotoEkle.Size = new System.Drawing.Size(89, 23);
            this.btnfotoEkle.TabIndex = 4;
            this.btnfotoEkle.Text = "Fotoğraf Ekle";
            this.btnfotoEkle.UseVisualStyleBackColor = true;
            this.btnfotoEkle.Click += new System.EventHandler(this.btnfotoEkle_Click);
            // 
            // btnFotoSil
            // 
            this.btnFotoSil.Location = new System.Drawing.Point(414, 297);
            this.btnFotoSil.Name = "btnFotoSil";
            this.btnFotoSil.Size = new System.Drawing.Size(89, 23);
            this.btnFotoSil.TabIndex = 5;
            this.btnFotoSil.Text = "Fotoğraf Sil";
            this.btnFotoSil.UseVisualStyleBackColor = true;
            this.btnFotoSil.Click += new System.EventHandler(this.btnFotoSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 378);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFotoSil);
            this.Controls.Add(this.btnfotoEkle);
            this.Controls.Add(this.listBoxImage);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.picBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerImage;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.ListBox listBoxImage;
        private System.Windows.Forms.Button btnfotoEkle;
        private System.Windows.Forms.Button btnFotoSil;
        private System.Windows.Forms.TextBox textBox1;
    }
}

