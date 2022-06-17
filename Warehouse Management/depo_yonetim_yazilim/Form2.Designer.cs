
namespace depo_yonetim_uygulamasi
{
    partial class Form2
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTakip = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDepoTeslim = new System.Windows.Forms.Button();
            this.buttonDepoDurum = new System.Windows.Forms.Button();
            this.buttonDepo = new System.Windows.Forms.Button();
            this.buttonMalzeme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.userControlDepoTeslim1 = new depo_yonetim_uygulamasi.userControlDepoTeslim();
            this.userControlDepoDurum1 = new depo_yonetim_uygulamasi.userControlDepoDurum();
            this.userControlDepo1 = new depo_yonetim_uygulamasi.userControlDepo();
            this.userControlMalzeme1 = new depo_yonetim_uygulamasi.userControlMalzeme();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTakip)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelTakip);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonDepoTeslim);
            this.panel1.Controls.Add(this.buttonDepoDurum);
            this.panel1.Controls.Add(this.buttonDepo);
            this.panel1.Controls.Add(this.buttonMalzeme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 611);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(4, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 29);
            this.panel3.TabIndex = 16;
            // 
            // panelTakip
            // 
            this.panelTakip.Image = ((System.Drawing.Image)(resources.GetObject("panelTakip.Image")));
            this.panelTakip.Location = new System.Drawing.Point(162, 281);
            this.panelTakip.Name = "panelTakip";
            this.panelTakip.Size = new System.Drawing.Size(41, 55);
            this.panelTakip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelTakip.TabIndex = 15;
            this.panelTakip.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buttonGuncelle);
            this.panel2.Location = new System.Drawing.Point(1, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 46);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "DURUM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "SÜRÜM DURUMU";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(100, 20);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(97, 26);
            this.buttonGuncelle.TabIndex = 11;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 17.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(9, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 90);
            this.label4.TabIndex = 11;
            this.label4.Text = "LÜTFEN GÖRÜNTÜLEMEK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 17.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(27, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = "YAZILIM VERSİYONU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 17.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "v1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDepoTeslim
            // 
            this.buttonDepoTeslim.FlatAppearance.BorderSize = 0;
            this.buttonDepoTeslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepoTeslim.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDepoTeslim.ForeColor = System.Drawing.Color.White;
            this.buttonDepoTeslim.Image = ((System.Drawing.Image)(resources.GetObject("buttonDepoTeslim.Image")));
            this.buttonDepoTeslim.Location = new System.Drawing.Point(42, 497);
            this.buttonDepoTeslim.Name = "buttonDepoTeslim";
            this.buttonDepoTeslim.Size = new System.Drawing.Size(117, 82);
            this.buttonDepoTeslim.TabIndex = 1;
            this.buttonDepoTeslim.Text = "Ürün Teslim Durumları";
            this.buttonDepoTeslim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDepoTeslim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDepoTeslim.UseVisualStyleBackColor = true;
            this.buttonDepoTeslim.Click += new System.EventHandler(this.buttonDepoTeslim_Click);
            // 
            // buttonDepoDurum
            // 
            this.buttonDepoDurum.FlatAppearance.BorderSize = 0;
            this.buttonDepoDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepoDurum.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDepoDurum.ForeColor = System.Drawing.Color.White;
            this.buttonDepoDurum.Image = ((System.Drawing.Image)(resources.GetObject("buttonDepoDurum.Image")));
            this.buttonDepoDurum.Location = new System.Drawing.Point(42, 412);
            this.buttonDepoDurum.Name = "buttonDepoDurum";
            this.buttonDepoDurum.Size = new System.Drawing.Size(117, 79);
            this.buttonDepoDurum.TabIndex = 1;
            this.buttonDepoDurum.Text = "Depo Durumları";
            this.buttonDepoDurum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDepoDurum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDepoDurum.UseVisualStyleBackColor = true;
            this.buttonDepoDurum.Click += new System.EventHandler(this.buttonDepoDurum_Click);
            // 
            // buttonDepo
            // 
            this.buttonDepo.FlatAppearance.BorderSize = 0;
            this.buttonDepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDepo.ForeColor = System.Drawing.Color.White;
            this.buttonDepo.Image = ((System.Drawing.Image)(resources.GetObject("buttonDepo.Image")));
            this.buttonDepo.Location = new System.Drawing.Point(42, 342);
            this.buttonDepo.Name = "buttonDepo";
            this.buttonDepo.Size = new System.Drawing.Size(117, 64);
            this.buttonDepo.TabIndex = 1;
            this.buttonDepo.Text = "Depo(lar)";
            this.buttonDepo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDepo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDepo.UseVisualStyleBackColor = true;
            this.buttonDepo.Click += new System.EventHandler(this.buttonDepo_Click);
            // 
            // buttonMalzeme
            // 
            this.buttonMalzeme.FlatAppearance.BorderSize = 0;
            this.buttonMalzeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMalzeme.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMalzeme.ForeColor = System.Drawing.Color.White;
            this.buttonMalzeme.Image = ((System.Drawing.Image)(resources.GetObject("buttonMalzeme.Image")));
            this.buttonMalzeme.Location = new System.Drawing.Point(42, 272);
            this.buttonMalzeme.Name = "buttonMalzeme";
            this.buttonMalzeme.Size = new System.Drawing.Size(117, 64);
            this.buttonMalzeme.TabIndex = 1;
            this.buttonMalzeme.Text = "Dahili Ürünler";
            this.buttonMalzeme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMalzeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMalzeme.UseVisualStyleBackColor = true;
            this.buttonMalzeme.Click += new System.EventHandler(this.buttonMalzeme_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depo Yönetimi Uygulaması";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(763, 115);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(143, 149);
            this.webBrowser1.TabIndex = 15;
            this.webBrowser1.Visible = false;
            // 
            // userControlDepoTeslim1
            // 
            this.userControlDepoTeslim1.Location = new System.Drawing.Point(212, 84);
            this.userControlDepoTeslim1.Margin = new System.Windows.Forms.Padding(48, 66, 48, 66);
            this.userControlDepoTeslim1.Name = "userControlDepoTeslim1";
            this.userControlDepoTeslim1.Size = new System.Drawing.Size(1094, 849);
            this.userControlDepoTeslim1.TabIndex = 8;
            this.userControlDepoTeslim1.Load += new System.EventHandler(this.userControlDepoTeslim1_Load);
            // 
            // userControlDepoDurum1
            // 
            this.userControlDepoDurum1.Location = new System.Drawing.Point(212, 79);
            this.userControlDepoDurum1.Margin = new System.Windows.Forms.Padding(32, 43, 32, 43);
            this.userControlDepoDurum1.Name = "userControlDepoDurum1";
            this.userControlDepoDurum1.Size = new System.Drawing.Size(2092, 1520);
            this.userControlDepoDurum1.TabIndex = 7;
            // 
            // userControlDepo1
            // 
            this.userControlDepo1.Location = new System.Drawing.Point(212, 79);
            this.userControlDepo1.Margin = new System.Windows.Forms.Padding(32, 43, 32, 43);
            this.userControlDepo1.Name = "userControlDepo1";
            this.userControlDepo1.Size = new System.Drawing.Size(2092, 1520);
            this.userControlDepo1.TabIndex = 6;
            // 
            // userControlMalzeme1
            // 
            this.userControlMalzeme1.Location = new System.Drawing.Point(212, 79);
            this.userControlMalzeme1.Margin = new System.Windows.Forms.Padding(32, 43, 32, 43);
            this.userControlMalzeme1.Name = "userControlMalzeme1";
            this.userControlMalzeme1.Size = new System.Drawing.Size(2092, 1520);
            this.userControlMalzeme1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControlDepoTeslim1);
            this.Controls.Add(this.userControlDepoDurum1);
            this.Controls.Add(this.userControlDepo1);
            this.Controls.Add(this.userControlMalzeme1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPO YÖNETİM UYGULAMASI   v.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTakip)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMalzeme;
        private System.Windows.Forms.Button buttonDepoTeslim;
        private System.Windows.Forms.Button buttonDepoDurum;
        private System.Windows.Forms.Button buttonDepo;
        private userControlMalzeme userControlMalzeme1;
        private userControlDepo userControlDepo1;
        private userControlDepoDurum userControlDepoDurum1;
        private userControlDepoTeslim userControlDepoTeslim1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox panelTakip;
        private System.Windows.Forms.Panel panel3;
    }
}

