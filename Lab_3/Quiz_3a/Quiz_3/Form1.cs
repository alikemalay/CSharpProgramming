using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double corba = 0.0, yemek = 0.0, tatli = 0.0,geneltoplam=0.0,bahsis,toplamhesap=0.0;

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCorba.Text = " ";
            txtYemek.Text = " ";
            txtTatli.Text = " ";
            corba = 0.0;
            yemek = 0.0; tatli = 0.0; geneltoplam = 0.0; bahsis=0.0; toplamhesap = 0.0;
        }

        private void cbBahsis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBahsis.Checked)
            {
                bahsis = (geneltoplam / 100) * 5;
                lbBahsis.Text = "Bahşiş : " + bahsis.ToString();
                toplamhesap += bahsis;
                lbToplam.Text = "Toplam Hesap : " + toplamhesap.ToString();
            }
            else
            {
                toplamhesap -= bahsis;
                lbToplam.Text = "Toplam Hesap : " + toplamhesap.ToString();
                bahsis = 0;
                lbBahsis.Text = "Bahşiş : " + bahsis.ToString();
            }
            
        }

        private void txtYemek_TextChanged(object sender, EventArgs e)
        {
            yemek = 0.0;
            double adet = 0.0;
            try
            {
                adet = Convert.ToDouble(txtYemek.Text);
                yemek += adet * 12.0;
                lbYemekToplam.Text = "Toplam Fiyat : " + yemek.ToString();
                geneltoplam = corba + yemek + tatli;
                lbGenelToplam.Text = "Genel Toplam : " + geneltoplam.ToString();
                toplamhesap = geneltoplam + bahsis;
                lbToplam.Text = "Toplam Hesap : " + toplamhesap.ToString();
            }
            catch (Exception)
            {
            }
 
           
        }

        private void txtTatli_TextChanged(object sender, EventArgs e)
        {
            tatli = 0.0;
            double adet = 0.0;
            try
            {
                adet = Convert.ToDouble(txtTatli.Text);
                adet = Convert.ToDouble(txtTatli.Text);
                tatli += adet * 12.0;
                lbTatliToplam.Text = "Toplam Fiyat : " + tatli.ToString();
                geneltoplam = corba + yemek + tatli;
                lbGenelToplam.Text = "Genel Toplam : " + geneltoplam.ToString();
                toplamhesap = geneltoplam + bahsis;
                lbToplam.Text = "Toplam Hesap : " + toplamhesap.ToString();
            }
            catch (Exception)
            {
            }
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            corba = 0.0;
            double adet=0.0;
            try
            {
                adet = Convert.ToDouble(txtCorba.Text);
                corba += adet * 4.5;
                lbCorbaToplam.Text = "Toplam Fiyat : " + corba.ToString();
                geneltoplam = corba + yemek + tatli;
                lbGenelToplam.Text = "Genel Toplam : " + geneltoplam.ToString();
                toplamhesap = geneltoplam + bahsis;
                lbToplam.Text = "Toplam Hesap : " + toplamhesap.ToString();
            }
            catch (Exception)
            {

            }
            
          
            

        }
    }
}
