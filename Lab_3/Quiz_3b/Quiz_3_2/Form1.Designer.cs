namespace Quiz_3_2
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
            this.btnTxtBox = new System.Windows.Forms.Button();
            this.lbSonuclar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTxtBox
            // 
            this.btnTxtBox.Location = new System.Drawing.Point(45, 42);
            this.btnTxtBox.Name = "btnTxtBox";
            this.btnTxtBox.Size = new System.Drawing.Size(160, 23);
            this.btnTxtBox.TabIndex = 0;
            this.btnTxtBox.Text = "TextBox Oluştur";
            this.btnTxtBox.UseVisualStyleBackColor = true;
            this.btnTxtBox.Click += new System.EventHandler(this.btnTxtBox_Click);
            // 
            // lbSonuclar
            // 
            this.lbSonuclar.AutoSize = true;
            this.lbSonuclar.Location = new System.Drawing.Point(251, 52);
            this.lbSonuclar.Name = "lbSonuclar";
            this.lbSonuclar.Size = new System.Drawing.Size(35, 13);
            this.lbSonuclar.TabIndex = 1;
            this.lbSonuclar.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 261);
            this.Controls.Add(this.lbSonuclar);
            this.Controls.Add(this.btnTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTxtBox;
        private System.Windows.Forms.Label lbSonuclar;
    }
}

