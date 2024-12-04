using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace double_degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 4.25;
            label1.Text = sayi.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sayi3,ortalama;
            sayi1 = 60;
            sayi2 = 70;
            sayi3 = 79;
            ortalama = (sayi3 + sayi2 + sayi1)/3;
            label2.Text = ortalama.ToString("0.000");//virgülden sonraki 3 bas

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi4 = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi4.ToString();

        }
    }
}
