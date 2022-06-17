using depo_yonetim_yazılımı;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depo_yonetim_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if(panel2.Width >= 800)
            {
                timer1.Stop();
                Form3 f1 = new Form3();
                f1.Show();
                this.Hide();
            }
        }

       
    }
}
