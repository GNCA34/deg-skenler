using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degisken_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 24;
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = 5;
            sayi2 = 4;
            toplam = sayi1 + sayi2;
            label2.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 4;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label3.Text = "alan:" + alan.ToString()+" cevre:"+cevre.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kısa_kenar, uzun_kenar,alan,cevre;
            kısa_kenar = 6;
            uzun_kenar = 4;
            alan = kısa_kenar * uzun_kenar;
            cevre = (kısa_kenar + uzun_kenar) * 2;
            label4.Text = "Alan:" + alan + " Cevre:" + cevre;

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3,ortalama;
            sinav1 = 90;
            sinav2 = 85;
            sinav3 = 95;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label5.Text = "Ortalamanız:" + ortalama;
        }
    }
}
//kısa:10 uzun:20 dikdörtgen
//3 sınav notu girilen öğrencinin ortalaması sonuçlar labela yazdır