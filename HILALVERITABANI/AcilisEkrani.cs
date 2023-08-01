using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HILALVERITABANI
{
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }

        [System.ComponentModel.Browsable(true)]
        public System.Windows.Forms.ProgressBarStyle Style { get; set; }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {    
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
                progressBar1.Value++;
            else
            {
                timer1.Stop();
                this.Hide();
                Giris girisformu = new Giris();
                girisformu.Show();
            }
        }
    }
}
