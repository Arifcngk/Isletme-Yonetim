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
    public partial class prsnBilgileri : Form
    {
        public prsnBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglan=new SqlConnection("Data Source=DESKTOP-PCF41GC;Initial Catalog=personelLogin;Integrated Security=True");
        SqlConnection baglan1 = new SqlConnection("Data Source=DESKTOP-PCF41GC;Initial Catalog=mesaj;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public void Listele()
        {
            // baglan.Open();
            SqlCommand komut = new SqlCommand("select *from personelLogin where ID like '" + prsID.Text + "'", baglan);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                prsAd.Text = dr["p_Adı"].ToString();
                prsSoyad.Text = dr["p_soyadı"].ToString();
                personelTel.Text = dr["p_tel"].ToString();
                prsCinsiyet.Text = dr["p_cinsiyet"].ToString();
                prsnMaas.Text = dr["p_maas"].ToString();
                prsSifre.Text = dr["p_Sifre"].ToString();
            }
            baglan.Close();

        }
        private void prsnBilgileri_Load(object sender, EventArgs e)
        {
           // prsID.Text=prsID.Items[0].ToString();
       //     msjID.Text=msjID.Items[0].ToString();   
            prsID.Items.Clear();
            SqlDataReader oku;
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "select * from personelLogin";
            oku=cmd.ExecuteReader();
            while (oku.Read())
            {
                prsID.Items.Add(oku[0].ToString());
            }
            baglan.Close();




            msjID.Items.Clear();
            SqlDataReader oku1;
            baglan1.Open();
            cmd.Connection = baglan1;
            cmd.CommandText = "select * from mesaj";
            oku1 = cmd.ExecuteReader();
            while (oku1.Read())
            {      
                msjID.Items.Add(oku1[0].ToString());
              

            }
            baglan1.Close();



        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from personelLogin where ID like '" + prsID.Text + "'", baglan);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                prsAd.Text = dr["p_Adı"].ToString();
                prsSoyad.Text = dr["p_soyadı"].ToString();
                personelTel.Text = dr["p_tel"].ToString();
                prsCinsiyet.Text = dr["p_cinsiyet"].ToString();
                prsnMaas.Text = dr["p_maas"].ToString();
                prsSifre.Text = dr["p_Sifre"].ToString();
            }
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand delete = new SqlCommand("Delete From personelLogin where ID=@p1",baglan);
            delete.Parameters.AddWithValue("@p1",prsID.Text);
            delete.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Personel Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = prsAd.Text;
            string soyad = prsSoyad.Text;
            int tel = Convert.ToInt32(personelTel);
            string cinsiyet = prsCinsiyet.Text;
            int maas = Convert.ToInt32(prsnMaas.Text);
            string sifre = prsSifre.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into personelLogin (p_Adı,p_soyadı,p_tel,p_cinsiyet,p_maas,p_Sifre) values ('" + ad + "','" + soyad + "'," + tel + ",'" + cinsiyet + "'," + maas + ",'" + sifre + "')";
            cmd.Connection = baglan;

            baglan.Open();

            int etk = cmd.ExecuteNonQuery();
            if (etk > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenirken Hata Oluştu");
            }
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string update = "UPDATE personelLogin SET p_Adı=@Adı,p_soyadı=@Soyadı,p_tel=@Tel,p_cinsiyet=@Cinsiyet,p_maas=@Maas,p_Sifre=@Sifre WHERE ID=@ID";
            cmd = new SqlCommand(update, baglan);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(prsID.Text));
            cmd.Parameters.AddWithValue("@Adı", prsAd.Text);
            cmd.Parameters.AddWithValue("@Soyadı", prsSoyad.Text);
            cmd.Parameters.AddWithValue("@Tel", personelTel.Text);
            cmd.Parameters.AddWithValue("@Cinsiyet", prsCinsiyet.Text);
            cmd.Parameters.AddWithValue("@Maas", prsnMaas.Text);
            cmd.Parameters.AddWithValue("@Sifre", prsSifre.Text);


            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            Listele();
        }

        private void msjKutusu_Click(object sender, EventArgs e)
        {
            baglan1.Open();
            SqlCommand komut = new SqlCommand("select *from mesaj where p_adı like '" + msjID.Text + "'", baglan1);
            SqlDataReader dr1;
            dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {

                msjKonu.Text = dr1["p_mesaj"].ToString();
                
               
            }
            baglan1.Close();
        }
    }
}
