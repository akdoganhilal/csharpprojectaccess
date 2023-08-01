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
using System.Windows.Forms.VisualStyles;


namespace HILALVERITABANI
{
    public partial class Giris : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        OleDbDataReader dr;
        DataSet ds;
        public Giris()
        {
            InitializeComponent();
        }


        void kayitlar()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("SElect *from kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kayit");
            uyelerDataGV.DataSource = ds.Tables["kayit"];
            con.Close();
        }

           private void Giris_Load(object sender, EventArgs e)
        {
            kayitlar();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kayit where Kullanici_Adi='" + kullaniciadiTB.Text + "' AND Sifre='" + parolaTB.Text + "'";
            dr = cmd.ExecuteReader();

            if (kullaniciadiTB.Text == "admin" && parolaTB.Text == "12345")
            {
                AdminPaneli adminfrm = new AdminPaneli();
                adminfrm.Show();               
                this.Hide();
            }
            
            else if (dr.Read() && (!(kullaniciadiTB.Text == "admin")))
            {
                Form1 anafrm = new Form1();
                anafrm.Show();
                this.Hide();


                 if (BilgiAktar(kullaniciadiTB.Text) != 0)
                 {
                       anafrm.tbKULLANICI.Text = kullaniciadiTB.Text; 
                       anafrm.tbSIFRE.Text = parolaTB.Text;                   
                 }

                anafrm.tbTELEFON.Text = telTB.Text;
                anafrm.tbADRES.Text = adresTB.Text;
                anafrm.tbID.Text = idTB.Text;

            }
            else if (kullaniciadiTB.Text=="" || parolaTB.Text=="")
            {
                MessageBox.Show("Boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kullaniciadiTB.Clear();
                parolaTB.Clear();
            }

            else         
            {
                MessageBox.Show("Kullanıcı Adı/Şifre Yanlış!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kullaniciadiTB.Clear();
                parolaTB.Clear();
            }
            con.Close();


        }

        public int BilgiAktar(string bilgi)
        {
            int sonuc;
            con = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=db1.accdb");
            string sorgu = "Select COUNT(Kullanici_Adi) from kayit WHERE Kullanici_Adi='" + bilgi + "'";
            cmd = new OleDbCommand(sorgu, con);
            con.Open();
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (parolaTB.UseSystemPasswordChar == true)
           {
                parolaTB.UseSystemPasswordChar = false;
           }
           else if (parolaTB.UseSystemPasswordChar == false)
           {
                parolaTB.UseSystemPasswordChar = true;
           }

        }

        private void kullaniciadiTB_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("SElect *from kayit where Kullanici_Adi like '" + kullaniciadiTB.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kayit");
            uyelerDataGV.DataSource = ds.Tables["kayit"];
            con.Close();
        }

        private void uyelerDataGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = uyelerDataGV.CurrentRow.Cells[0].Value.ToString();
            telTB.Text = uyelerDataGV.CurrentRow.Cells[3].Value.ToString();
            adresTB.Text = uyelerDataGV.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            Application.Exit();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
        }
    }
}
