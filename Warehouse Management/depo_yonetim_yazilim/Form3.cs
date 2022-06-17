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
using depo_yonetim_uygulamasi;

namespace depo_yonetim_yazılımı
{
    public partial class Form3 : Form
    {

    
        public Form3()
        {
            InitializeComponent();
            
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=depo_yonetim;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kullanici WHERE kullanici_adi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'", baglanti);

            da.Fill(dt);
            if (dt.Rows.Count==1)
            {
                MessageBox.Show("Giriş Başarılı, Yönlendiriliyorsunuz...", "Giriş Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form2 f1 = new Form2();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış bilgi girişi yaptınız. Tekrar deneyin.", "Geçersiz Giriş Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
