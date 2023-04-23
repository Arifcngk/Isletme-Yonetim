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
    public partial class personelLogin : Form
    {
        public personelLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public static string unvan;
        public static string soyad;
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
            Form1 frm=new Form1();
            frm.Show();
            this.Hide();
        }

        private void personelLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM personelLogin where p_Adı=@user AND p_Sifre=@pass";
            con = new SqlConnection("server=.; Initial Catalog=personelLogin;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                unvan = textBox1.Text;
                AnaEkran ae=new AnaEkran(); 
                ae.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                textBox1.Clear();
                textBox2.Clear();
            }
            con.Close();
        }
    }
}
