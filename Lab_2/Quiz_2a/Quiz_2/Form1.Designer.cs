namespace Quiz_2
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
            this.arraySize = new System.Windows.Forms.TextBox();
            this.createArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.Label();
            this.avaValue = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.Label();
            this.arrayTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(93, 38);
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(100, 20);
            this.arraySize.TabIndex = 0;
            // 
            // createArray
            // 
            this.createArray.Location = new System.Drawing.Point(93, 64);
            this.createArray.Name = "createArray";
            this.createArray.Size = new System.Drawing.Size(100, 23);
            this.createArray.TabIndex = 1;
            this.createArray.Text = "Create Array";
            this.createArray.UseVisualStyleBackColor = true;
            this.createArray.Click += new System.EventHandler(this.createArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size of Array:";
            // 
            // minValue
            // 
            this.minValue.AutoSize = true;
            this.minValue.Location = new System.Drawing.Point(326, 44);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(57, 13);
            this.minValue.TabIndex = 4;
            this.minValue.Text = "Min Value:";
            // 
            // avaValue
            // 
            this.avaValue.AutoSize = true;
            this.avaValue.Location = new System.Drawing.Point(326, 73);
            this.avaValue.Name = "avaValue";
            this.avaValue.Size = new System.Drawing.Size(80, 13);
            this.avaValue.TabIndex = 5;
            this.avaValue.Text = "Avarage Value:";
            // 
            // maxValue
            // 
            this.maxValue.AutoSize = true;
            this.maxValue.Location = new System.Drawing.Point(329, 106);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(60, 13);
            this.maxValue.TabIndex = 6;
            this.maxValue.Text = "Max Value:";
            // 
            // arrayTextbox
            // 
            this.arrayTextbox.Location = new System.Drawing.Point(199, 38);
            this.arrayTextbox.Multiline = true;
            this.arrayTextbox.Name = "arrayTextbox";
            this.arrayTextbox.Size = new System.Drawing.Size(100, 93);
            this.arrayTextbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 174);
            this.Controls.Add(this.arrayTextbox);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.avaValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createArray);
            this.Controls.Add(this.arraySize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox arraySize;
        private System.Windows.Forms.Button createArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minValue;
        private System.Windows.Forms.Label avaValue;
        private System.Windows.Forms.Label maxValue;
        private System.Windows.Forms.TextBox arrayTextbox;
    }
}

