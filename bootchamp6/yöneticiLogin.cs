using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bootchamp6
{
    public partial class yöneticiLogin : Form
    {
        public yöneticiLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
     public   static string unvan1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM yoneticiLogin where y_Adı=@user AND y_Sifre=@pass";
            con = new SqlConnection("server=.; Initial Catalog=yoneticiLogin;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                unvan1 = button2.Text;
                AnaEkran ae = new AnaEkran();
                ae.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }

        private void yöneticiLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
