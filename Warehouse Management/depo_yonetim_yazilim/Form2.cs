using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace depo_yonetim_uygulamasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //VERSİYON DURUMU
        int versiyon = 1;

        //GÜNCELLE BUTONU İŞLEVİ
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://becxsoft.xyz/proje/guncellemeTest.zip");
        }

        //GÜNCELLEME ZAMANLAYICISI
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (versiyon == 1) 
            {
                buttonGuncelle.Text = "GÜNCEL!";
                buttonGuncelle.Enabled = false;
            }
            else
            {
                buttonGuncelle.Text = "GÜNCELLE!";
                buttonGuncelle.Enabled = true;
                panel2.BackColor = Color.Red;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //GÜNCELLEME ALANI BAŞLANGIÇ
            timer1.Start();
            string hedef = "http://becxsoft.xyz/proje/versiyon.php";
            WebRequest istek = HttpWebRequest.Create(hedef);
            WebResponse yanit;
            yanit = istek.GetResponse();
            StreamReader gelenBilgiler = new StreamReader(yanit.GetResponseStream());
            string gelen = gelenBilgiler.ReadToEnd();
            int baslangic = gelen.IndexOf("<p>") + 3;
            int bitis = gelen.Substring(baslangic).IndexOf("</p>");
            string getirilenbilgiler = gelen.Substring(baslangic, bitis);
            versiyon = Convert.ToInt16(getirilenbilgiler);
            if (versiyon == 1)
            {
            }
            else
            {
                MessageBox.Show("Yeni Versiyon : " + versiyon + " -Yeni Sürüm Bulundu! Hemen GÜNCELLE Butonuna Tıklayarak Uygulamayı Güncelleyin!");
            }
            //GÜNCELLEME ALANI BİTİŞ




            userControlMalzeme1.Show();
            userControlDepo1.Hide();
            userControlDepoDurum1.Hide();
            userControlDepoTeslim1.Hide();
            MessageBoxManager.Yes = "Sil";
            MessageBoxManager.No = "Sıfırla";
            MessageBoxManager.Register();

            userControlMalzeme1.ComboTemizle();
            userControlMalzeme1.DepoCekme();

        }

        private void buttonMalzeme_Click(object sender, EventArgs e)
        {
            panelTakip.Height = buttonMalzeme.Height;
            panelTakip.Top = buttonMalzeme.Top;

            userControlMalzeme1.Show();
            userControlMalzeme1.BringToFront();
            userControlDepo1.Hide();
            userControlDepoDurum1.Hide();
            userControlDepoTeslim1.Hide();

            userControlMalzeme1.ComboTemizle();
            userControlMalzeme1.DepoCekme();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDepo_Click(object sender, EventArgs e)
        {
            panelTakip.Height = buttonDepo.Height;
            panelTakip.Top = buttonDepo.Top;

            userControlMalzeme1.Hide();
            userControlDepo1.BringToFront();
            userControlDepo1.Show();
            userControlDepoDurum1.Hide();
            userControlDepoTeslim1.Hide();
            
        }

        private void buttonDepoDurum_Click(object sender, EventArgs e)
        {
            panelTakip.Height = buttonDepoDurum.Height;
            panelTakip.Top = buttonDepoDurum.Top;

            userControlMalzeme1.Hide();
            userControlDepoTeslim1.BringToFront();
            userControlDepo1.Hide();
            userControlDepoDurum1.Show();
            userControlDepoTeslim1.Hide();

            userControlDepoDurum1.ComboTemizle();
            userControlDepoDurum1.DepoCekme();
            userControlDepoDurum1.KritikSeviye();
            userControlDepoDurum1.DepoDurumDoldur();
            userControlMalzeme1.MalzemeDoldur();
        }

        private void buttonDepoTeslim_Click(object sender, EventArgs e)
        {
            panelTakip.Height = buttonDepoTeslim.Height;
            panelTakip.Top = buttonDepoTeslim.Top;

            userControlMalzeme1.Hide();
            userControlDepoTeslim1.BringToFront();
            userControlDepo1.Hide();
            userControlDepoDurum1.Hide();
            userControlDepoTeslim1.Show();
            userControlDepoTeslim1.Temizle();
            userControlDepoTeslim1.DepoCekme();
            
        }

        private void userControlDepoTeslim1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Application.Exit();
        }
    }
}
