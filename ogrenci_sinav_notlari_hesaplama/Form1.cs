using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_sinav_notlari_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int sınav1 , sınav2 ,proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            sınav1 = Convert.ToInt16(textBox3.Text);
            sınav2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ortalama = (sınav1 + sınav2 + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " " + " ortalama: " + ortalama);
        }
    }
}
