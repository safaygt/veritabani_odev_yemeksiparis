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

namespace veritabani_odev
{
    public partial class Login : Form
    {
        
        SqlCommand komut;
        

        public Login()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=odev;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            if (baglanti.State.ToString() == "Closed")
            {
                baglanti.Open();
                MessageBox.Show("Bağlantı kuruldu!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txt_username.Text;
            password = txt_password.Text;

            string query = "SELECT Kullanıcı_İsim, Şifre FROM Kullanıcı_Ad where Kullanıcı_İsim = '" + txt_username.Text + "' AND  Şifre = '" + txt_password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if(dtable.Rows.Count > 0)
            {
                username = txt_username.Text;
                password = txt_password.Text;
                Kullanıcı_Panel form2 = new Kullanıcı_Panel();
                form2.Show();
                MessageBox.Show("Hoşgeldin "+username+"!","Başarılı!",MessageBoxButtons.OK,MessageBoxIcon.None);
                this.Hide();
            }

            else
            {
                MessageBox.Show("Yanlış Şifre veya Kullanıcı Adı girdiniz!","Hata!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();

                txt_username.Focus();
            }

        }
    }
}
