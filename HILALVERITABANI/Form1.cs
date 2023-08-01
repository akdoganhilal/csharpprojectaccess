using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using System.Security.Policy;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace HILALVERITABANI
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con; 
        OleDbDataAdapter da, da2;
        DataSet ds;
        void Urunler()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("Select *From urun", con);
            da2 = new OleDbDataAdapter("Select *From urun", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            urunlerDGV.DataSource = ds.Tables["urun"];
            con.Close();
        }
        void Kayitlar()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("SElect *from kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kayit");
            uyelerDataGV.DataSource = ds.Tables["kayit"];
            con.Close();
        }
        private void urununadiTB_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("SElect *from urun where Urun like '" + urununadiTB.Text + "%'", con);
            da2 = new OleDbDataAdapter("SElect *from urun where Fiyat like '" + urununadiTB.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            da2.Fill(ds, "urun");
            urunlerDGV.DataSource = ds.Tables["urun"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ustPANEL.Visible = false;
            panel1.Visible = false;
            urunlerDGV.Visible = false;
            hosgeldiniz.Visible = false;
            oynckbulLBL.Visible = false;
            urununadiTB.Visible = false;
            groupBox1.Visible = false;
            hosgeldiniz.Visible = true;
            nesnelerPANEL.Visible = true;
            Kayitlar();
        }
        private void anasayfaBTN_Click(object sender, EventArgs e)
        {
            ustPANEL.Visible = false;
            panel1.Visible = false;
            urunlerDGV.Visible = false;
            hosgeldiniz.Visible = false;
            oynckbulLBL.Visible = false;
            urununadiTB.Visible = false;
            groupBox1.Visible = false;
            hosgeldiniz.Visible = true;
            nesnelerPANEL.Visible = true;
        }    
        private void uyecikisBTN_Click(object sender, EventArgs e)
        {
            hesapMENU.Visible = false;
            uyecikisBTN.Visible = false;
            hesapMENU.Visible = false;
            uyecikisBTN.Visible = false;
            toolStripSeparator2.Visible = false;
            groupBox1.Visible = false;           
            
            Giris grsfrm = new Giris();
            grsfrm.Show();
            this.Hide(); 
        }
        private void urunlerDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            urunkodu.Text = "Ürün Kodu: " + urunlerDGV.CurrentRow.Cells[0].Value.ToString();
            urunadi.Text = urunlerDGV.CurrentRow.Cells[1].Value.ToString();
            urunfiyati.Text = urunlerDGV.CurrentRow.Cells[2].Value.ToString() + "₺";
            UrununResmi.ImageLocation = urunlerDGV.CurrentRow.Cells[3].Value.ToString();
        }  
        private void hesapMENU_Click(object sender, EventArgs e)
        {
            nesnelerPANEL.Visible = true;
            groupBox1.Visible = true;
            ustPANEL.Visible = false;
            panel1.Visible = false;
            urunlerDGV.Visible = false;
            hosgeldiniz.Visible = false;         
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=db1.accdb");

        private void sfrgorCB_CheckedChanged(object sender, EventArgs e)
        {
            if (tbSIFRE.UseSystemPasswordChar == false)
            {
                tbSIFRE.UseSystemPasswordChar = true;
            }
            else if (tbSIFRE.UseSystemPasswordChar == true)
            {
                tbSIFRE.UseSystemPasswordChar = false;
            }
        }
        private void uyelerDataGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {         
            tbID.Text = uyelerDataGV.CurrentRow.Cells[0].Value.ToString();
            tbKULLANICI.Text = uyelerDataGV.CurrentRow.Cells[1].Value.ToString();
            tbSIFRE.Text = uyelerDataGV.CurrentRow.Cells[2].Value.ToString();
            tbTELEFON.Text = uyelerDataGV.CurrentRow.Cells[3].Value.ToString();
            tbADRES.Text = uyelerDataGV.CurrentRow.Cells[4].Value.ToString();
        }
        private void satisBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satın Alındı. Teşekkürler!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris grs = new Giris();    
            grs.Show();
            this.Hide();
        }

        private void kayitlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.Show();
            this.Hide();
        }

        private void girislink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            this.Hide();
        }

        private void urunlerBTN_Click(object sender, EventArgs e)
        {
            Urunler();
            Convert.ToString(urunlerDGV.Columns[0].HeaderText = "Ürün Kodu");
            Convert.ToString(urunlerDGV.Columns[1].HeaderText = "");
            Convert.ToString(urunlerDGV.Columns[2].HeaderText = "");

            ustPANEL.Visible = true;
            nesnelerPANEL.Visible = true;
            panel1.Visible = true;
            urunlerDGV.Visible = true;
            oynckbulLBL.Visible = true;
            urununadiTB.Visible = true;

            groupBox1.Visible = false;
            hosgeldiniz.Visible = false;
        }
    }
}
