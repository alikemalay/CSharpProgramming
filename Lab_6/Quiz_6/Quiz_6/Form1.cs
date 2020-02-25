using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0, arraySize = 10;

        
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timerImage.Enabled = true;
            timerImage.Interval = 1000;
        }

        private void timerImage_Tick(object sender, EventArgs e)
        {
            picBox.Image = imgList.Images[counter];
            counter++;
            if (counter == arraySize)
                counter = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgList.ImageSize = new Size(256, 256);
            // Edit the path with your own address
            imgList.Images.Add("C:/images/image0.jpg", Image.FromFile("C:/images/image0.jpg"));
            imgList.Images.Add("C:/images/image1.jpg", Image.FromFile("C:/images/image1.jpg"));
            imgList.Images.Add("C:/images/image2.jpg", Image.FromFile("C:/images/image2.jpg"));
            imgList.Images.Add("C:/images/image3.jpg", Image.FromFile("C:/images/image3.jpg"));
            imgList.Images.Add("C:/images/image4.jpg", Image.FromFile("C:/images/image4.jpg"));
            imgList.Images.Add("C:/images/image5.jpg", Image.FromFile("C:/images/image5.jpg"));
            imgList.Images.Add("C:/images/image6.jpg", Image.FromFile("C:/images/image6.jpg"));
            imgList.Images.Add("C:/images/image7.jpg", Image.FromFile("C:/images/image7.jpg"));
            imgList.Images.Add("C:/images/image8.jpg", Image.FromFile("C:/images/image8.jpg"));
            imgList.Images.Add("C:/images/image9.jpg", Image.FromFile("C:/images/image9.jpg"));

            for (int i = 0; i < 10; i++) {
                listBoxImage.Items.Add("image" + (i)+"\n");
            }

        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timerImage.Enabled = false;
            //timerImage.Interval = 1000;
        }

        private void btnfotoEkle_Click(object sender, EventArgs e)
        {
            string photoName = textBox1.Text;
            imgList.Images.Add("C:/images/"+ photoName+".jpg", Image.FromFile("C:/images/" + photoName + ".jpg"));
            listBoxImage.Items.Add("image" + (listBoxImage.Items.Count) + "\n");
            arraySize++;
        }

        private void btnFotoSil_Click(object sender, EventArgs e)
        {
            imgList.Images.RemoveAt(listBoxImage.SelectedIndex);
            listBoxImage.Items.RemoveAt(listBoxImage.SelectedIndex);
            listBoxImage.SelectedIndex = 0;
            arraySize--;
            
        }

        private void listBoxImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImage.SelectedIndex >= 0)
            picBox.Image = imgList.Images[listBoxImage.SelectedIndex];
        }
    }
}
