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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelLogin pl=new personelLogin();
            pl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yöneticiLogin yl=new yöneticiLogin();
            yl.Show();
            this.Hide();
        }
    }
}
