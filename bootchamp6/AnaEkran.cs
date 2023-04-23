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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = personelLogin.unvan;
           
            if (label5.Text== personelLogin.unvan)
            {

                label5.Text = personelLogin.unvan;
                rsm1.Image = Image.FromFile(@"..\..\resim\1.png");
                rsm1.SizeMode = PictureBoxSizeMode.StretchImage;
                prsnEkle.Visible = false;
                lblprsnl.Visible = false;
                pictureBox7.Visible = true;
                label6.Visible = true;

            }
            else
            {
                label5.Text = yöneticiLogin.unvan1;
                rsm1.Image = Image.FromFile(@"..\..\resim\2.png");
                rsm1.SizeMode=PictureBoxSizeMode.StretchImage;
                prsnEkle.Visible=true;
                lblprsnl.Visible=true;
                pictureBox7.Visible = false;
                label6.Visible = false;
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            urunler urunler=new urunler();
            urunler.TopLevel = false;
            urunler.Dock = DockStyle.Fill;
            panel1.Controls.Add(urunler);
            urunler.BringToFront();
            urunler.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            salata  sa=new salata();
            sa.TopLevel = false;
            sa.Dock = DockStyle.Fill;
            panel1.Controls.Add(sa);
            sa.BringToFront();
            sa.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            mesrubat m=new mesrubat();
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            panel1.Controls.Add(m);
            m.BringToFront();
            m.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 form=new Form1();
            form.Show();
            this.Hide();

        }

        private void prsnEkle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            prsnBilgileri bilgi=new prsnBilgileri();
            bilgi.TopLevel=false;
            bilgi.Dock = DockStyle.Fill;
            panel1.Controls.Add((bilgi));
            bilgi.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            label8.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            mesaj mesaj=new mesaj();
            mesaj.Show();
        }
    }
}
