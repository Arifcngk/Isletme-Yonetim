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
    public partial class mesaj : Form
    {
        public mesaj()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PCF41GC;Initial Catalog=mesaj;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
           baglan.Open();
            SqlCommand ekle=new SqlCommand("insert into mesaj (p_adı,p_mesaj) values (@1,@2)",baglan);
            ekle.Parameters.AddWithValue("@1",textBox1.Text);
            ekle.Parameters.AddWithValue("@2",richTextBox1.Text);
            ekle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Mesaj Gönderildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();


        }

        private void mesaj_Load(object sender, EventArgs e)
        {
            textBox1.Text = personelLogin.unvan;
        }
    }
}
