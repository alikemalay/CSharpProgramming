using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] musteri = new string[10];
        string[] musteriSplit = new string[5];
        int musteriCount = 0, bayCount = 0, bynCount = 0;
        int[,] yasIst = new int[1,3];
        double[,] yasIstYuzde = new double[1, 3];


        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            
            string cinsiyet="Erkek",yasGrubu="Genc";
            if (rbErkek.Checked) {
                cinsiyet = "Erkek";
            }
            else {
                cinsiyet = "Kadın";
            }
            if (rbGenc.Checked) {
                yasGrubu = "Genc";
            }
            if (rbYetiskin.Checked)
            {
                yasGrubu = "Yetiskin";
            }
            if (rbYasli.Checked)
            {
                yasGrubu = "Yasli";
            }
            MusteriEkle(txtAdSoyad.Text.ToString(),cinsiyet,yasGrubu);
        }

        void MusteriEkle(string adSoyad, string Cinsiyet, string YasGrubu) {
            musteri[musteriCount] = adSoyad + " , " + Cinsiyet + " , " + YasGrubu;
            rbList.Text += musteri[musteriCount] + Environment.NewLine;
            musteriCount++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbList.Text = "";
            yasIst[0, 0]=0;
            yasIst[0, 1] = 0;
            yasIst[0, 2] = 0;

        }

        private void btnCinsiyetIst_Click(object sender, EventArgs e)
        {

            MessageBox.Show(cinsiyetIstastigi());
        }

        private void btnYasIst_Click(object sender, EventArgs e)
        {
            MessageBox.Show(yasGrubuIstatistigi());
        }

        public string cinsiyetIstastigi() {
            double yuzdeKadin, yuzdeErkek;
            yuzdeErkek = 0.0;
            yuzdeKadin = 0.0;
            int i = 0;
            bayCount = 0;
            bynCount = 0;
            for (i = 0; musteri[i] != null; i++)
            {
                musteriSplit = musteri[i].Split();
                if (musteriSplit[2] == "Erkek")
                {
                    bayCount++;
                }
                else
                {
                    bynCount++;
                }
            }

            yuzdeErkek = (100.0 / i ) * bayCount;
            yuzdeErkek = Math.Round(yuzdeErkek, 2);
            yuzdeKadin = 100.0 - yuzdeErkek;
            yuzdeKadin = Math.Round(yuzdeKadin, 2);
            return "Grupta " + bayCount.ToString() + " Bay " + bynCount.ToString() + " Bayan bulunmaktadır.\n" +
                "Grubun %"+yuzdeErkek+"i Baylar ve %"+yuzdeKadin+"i Bayanlardan oluşmaktadır.";
            
        }

        public string yasGrubuIstatistigi()
        {

            yasIst[0, 0] = 0;
            yasIst[0, 1] = 0;
            yasIst[0, 2] = 0;
            int i;
            for (i = 0; musteri[i] != null; i++)
            {
                musteriSplit = musteri[i].Split();
                if (musteriSplit[4] == "Genc")
                {
                    yasIst[0, 0]++;
                }
                else if (musteriSplit[4] == "Yetiskin")
                {
                    yasIst[0, 1]++;
                }
                else {
                    yasIst[0, 2]++;

                }
            }

            yasIstYuzde[0,0] =  (100.0 / i) * yasIst[0, 0];
            yasIstYuzde[0, 0] = Math.Round(yasIstYuzde[0, 0], 2);

            yasIstYuzde[0, 1] =(100.0/i) * yasIst[0, 1];
            yasIstYuzde[0, 1] = Math.Round(yasIstYuzde[0, 1], 2);

            yasIstYuzde[0, 2] = (100.0/i) * yasIst[0, 2];
            yasIstYuzde[0, 2] = Math.Round(yasIstYuzde[0, 2], 2);

            return "Grupta " + yasIst[0,0].ToString() + " Genç, " + yasIst[0, 1].ToString() + " Yetişkin, " + yasIst[0, 2].ToString() + " Yaşlı bulunmaktadır.\n" +
                "Grubun %" + yasIstYuzde[0,0] + "i Genç , %" + yasIstYuzde[0,1] + "i Yetişkin, %" + yasIstYuzde[0,2] + "i Yaşlılardan oluşmaktadır.";
        }

    }
}
