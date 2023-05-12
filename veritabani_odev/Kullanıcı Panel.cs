using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabani_odev
{
    public partial class Kullanıcı_Panel : Form
    {
        public Kullanıcı_Panel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=odev;Integrated Security=True");
        private void lbl_encokpara_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            string query = "exec procedure1";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();

        }

        private void Kullanıcı_Panel_Load(object sender, EventArgs e)
        {

        }

        private void lbl_müsteriler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            string query = "select * from view1";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();
        }

        private void lbl_restoranlar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            string query = "select * from view2";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();
        }

        private void btn_restorangetir_Click(object sender, EventArgs e)
        {
            string restoran_ad;
            restoran_ad = txt_restorangetir.Text;
            baglanti.Open();
            string query = "SELECT R.ID, R.Restoran_Ad, R.Restoran_Puan, S.Şehir_Ad, i.İlçe_Ad, So.Sokak_Ad, A.Bina_No FROM   Restoran AS R INNER JOIN  Adres AS A ON R.Adres_ID = A.ID INNER JOIN   Sehir AS S ON S.ID = A.Şehir_ID INNER JOIN    ilce AS i ON i.ID = A.İlçe_ID INNER JOIN    Mahalle AS M ON M.ID = A.Mahalle_ID INNER JOIN   Sokak AS So ON So.ID = A.Sokak_ID where Restoran_Ad = '" + restoran_ad + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();


            if (dtable.Rows.Count == 0)
            {
                MessageBox.Show("Sonuç bulunamadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
