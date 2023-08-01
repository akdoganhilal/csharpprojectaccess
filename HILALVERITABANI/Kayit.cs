using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HILALVERITABANI
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris girisformu = new Giris();
            girisformu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TekrarEdenKullanici(kullaniciadiTB.Text) != 0)
            {
                MessageBox.Show("Bu bilgilere ait kayıt bulunmaktadır. Lütfen yeni bir kayıt oluşturunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kullaniciadiTB.Text == "" || parolaTB.Text == "" || telefonmtb.Text == "" || adresrtb.Text == "")
            {
                MessageBox.Show("Boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sorgu = "Insert into kayit (ID, Kullanici_Adi, Sifre, Telefon, Adres) values (@UyeKodu, @KullanıcıAdı, @Sifre, @Telefon, @Adres)";
                cmd = new OleDbCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@UyeKodu", idTB.Text);
                cmd.Parameters.AddWithValue("@KullanıcıAdı", kullaniciadiTB.Text);
                cmd.Parameters.AddWithValue("@Sifre", parolaTB.Text);
                cmd.Parameters.AddWithValue("@Telefon", telefonmtb.Text);
                cmd.Parameters.AddWithValue("@Adres", adresrtb.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random karistir = new Random();
            string iduyekodu = "";
            idTB.Clear();
            for (int i = 0; i < 10; i++)
            {
                iduyekodu += karakterler[karistir.Next(karakterler.Length)];
                idTB.Text = "#" + iduyekodu;
            }

            kullaniciadiTB.Clear();
            parolaTB.Clear();
            telefonmtb.Clear();
            adresrtb.Clear();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.SteelBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void kullaniciadiTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            kayitlar();

            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random karistir = new Random();
            string iduyekodu = "";
            idTB.Clear();

            for (int i = 0; i < 10; i++)
            {
                iduyekodu += karakterler[karistir.Next(karakterler.Length)];
                idTB.Text = "#" + iduyekodu;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int TekrarEdenKullanici(string aranan)
        {
            int sonuc;
            con = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=db1.accdb");
            string sorgu = "Select COUNT(Kullanici_Adi) from kayit WHERE Kullanici_Adi='" + aranan + "'";
            cmd = new OleDbCommand(sorgu, con);
            con.Open();
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }
    }
}
