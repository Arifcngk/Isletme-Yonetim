using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bootchamp6
{
    public partial class urunler : Form
    {
        public urunler()
        {
            InitializeComponent();
        }
        public static double menu1 = 94.99;
        public static double menu2 = 74.99;
        public static double menu3 = 54.99;
        public static double top=0;
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "BİG BURGER ";
            textBox2.Text = "1x Köfte Burger" +
                             "1x Büyük Boy İçecek " +
                             "1x Büyük Boy Patates Kızartması" +
                             "2x Seçmeli Tatlı" +
                             "5x Seçmeli Sos";
            label7.Text = menu1.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "KÖFTE BURGER ";
            textBox2.Text = "1x Köfte Burger" +
                             "1x Küçük Boy İçecek " +
                             "1x Orta Boy Patates Kızartması" +
                             "1x Seçmeli Tatlı" +
                             "2x Seçmeli Sos";
            label7.Text = menu2.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "TAVUK BURGER ";
            textBox2.Text = "1x Tavuk Burger" +
                             "1x Küçük Boy İçecek " +
                             "1x Orta Boy Patates Kızartması" +
                             "1x Seçmeli Tatlı" +
                             "2x Seçmeli Sos";
            label7.Text = menu3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "BİG BURGER ")
            {
                top = top + menu1;
                toplam.Text = top.ToString();
            }
            else if (textBox1.Text == "KÖFTE BURGER ")
            {
                top = top + menu2;
                toplam.Text = top.ToString();
            }
            else if (textBox1.Text == "TAVUK BURGER ")
            {

                top = top + menu3;
                toplam.Text = top.ToString();
            }
            toplam.Text = top.ToString(); 
            MessageBox.Show(textBox1.Text+" Menü Satıldı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Lütfen Hata Bildirimi için KARGAPLUS ile İletişime Geçiniz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
