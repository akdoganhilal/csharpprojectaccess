using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HILALVERITABANI
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void cikisBTN_Click(object sender, EventArgs e)
        {
            Form1 anafrm = new Form1();
            anafrm.Show();
            this.Close();
        }

        private void AdminPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris grsfrm = new Giris();
            grsfrm.Show();                
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db1.accdb");
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
              
        private void urunkoduTB_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("SElect *from urun where UrunKodu like '" + urunkoduTB.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            urunlerDataGV.DataSource = ds.Tables["urun"];
            con.Close();
        }

        private void uyekoduTB_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("SElect *from kayit where Kullanici_Adi like '" + uyekoduTB.Text + "%'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kayit");
            uyelerDataGV.DataSource = ds.Tables["kayit"];
            con.Close();
        }

        public void Uyeler()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("Select *From kayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kayit");
            uyelerDataGV.DataSource = ds.Tables["kayit"];
            con.Close();
        }
        public void Urunler()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=db1.accdb");
            da = new OleDbDataAdapter("Select *From urun", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            urunlerDataGV.DataSource = ds.Tables["urun"];
            con.Close();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            Uyeler();
            Urunler();
            Form1 anafrm = new Form1();
            anafrm.Hide();
        }

        public void uyesilBTN_Click(object sender, EventArgs e)
        {
            DialogResult dR1 = MessageBox.Show("Kayıt silinsin mi?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dR1 == DialogResult.Yes)
            {
                for (int i = 0; i < uyelerDataGV.SelectedRows.Count; i++)
                {
                    con.Open();
                    OleDbCommand uyekomut = new OleDbCommand("delete from kayit where Kullanici_Adi='" + uyelerDataGV.SelectedRows[i].Cells["Kullanici_Adi"].Value.ToString() + "'", con);
                    uyekomut.ExecuteNonQuery();
                    uyekomut.Dispose();
                    con.Close();
                    ds.Clear();
                    Uyeler();
                }

            }
            else
            {
                dR1 = DialogResult.No;
            }
        }

        private void uyelerDataGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = uyelerDataGV.CurrentRow.Cells[0].Value.ToString();
            Kullanici_Adi.Text = uyelerDataGV.CurrentRow.Cells[1].Value.ToString();
            Sifre.Text = uyelerDataGV.CurrentRow.Cells[2].Value.ToString();
            Telefon.Text = uyelerDataGV.CurrentRow.Cells[3].Value.ToString();
            Adres.Text = uyelerDataGV.CurrentRow.Cells[4].Value.ToString();

        }

        private void uyelerBTN_Click(object sender, EventArgs e)
        {
            Uyeler();

            UyeveurunPnl.Visible = true; 
            admngrsl.Visible = false;

            hesapkullaniciadiyazisi.Visible = true;
            hesapsifreyazisi.Visible = true;
            hesapuyenoyazisi.Visible = true;
            ID.Visible = true;
            Kullanici_Adi.Visible = true;
            Sifre.Visible = true;
            label2.Visible = true;
            Telefon.Visible = true;
            Adres.Visible = true;
            label3.Visible = true;
            uyebilgileri.Visible = true;
            uyesilBTN.Visible = true;
            
            urunresmi.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            urunsilbtn.Visible = false;
            gorselurl.Visible = false;
            urunkodu.Visible = false;
            urunadinigir.Visible = false;
            urunfiyatigir.Visible = false;
            urunkoduyazisi.Visible = false;
            urunadiyazisi.Visible = false;
            urunfiyatiyazisi.Visible = false; 
            urunbilgileri.Visible = false;

            uyelerDataGV.Visible = true;
            uyekoduLBL.Visible = true;
            urunlerDataGV.Visible = false;
            uyelerDataGV.Columns[0].Width = 110;
            Convert.ToString(uyelerDataGV.Columns[0].HeaderText = "Üye Kodu");
            Convert.ToString(uyelerDataGV.Columns[1].HeaderText = "Kullanıcı Adı");
            Convert.ToString(uyelerDataGV.Columns[2].HeaderText = "Şifre");

            UyeveurunPnl.Visible = true;
            uyekoduTB.Visible = true;
            urunkoduTB.Visible = false;
            urunkoduLBL.Visible = false;
            urunkontrolPNL.Visible = true;          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            urunfiyatigir.Enabled = true;
            urunadinigir.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false; 

            string degerler = "0123456789";
            Random karistir = new Random();
            string urunkodurnd = "";
            urunkodu.Clear();
            for (int i = 0; i < 4; i++)
            {
                urunkodurnd += degerler[karistir.Next(degerler.Length)];
                urunkodu.Text = urunkodurnd;
            }

            urunadinigir.Clear();
            urunfiyatigir.Clear();
        }

        public int TekrarEdenUrun(string aranan)
        {
            int sonuc;
            con = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=db1.accdb");
            string sorgu = "Select COUNT(Urun) from urun WHERE Urun='" + aranan + "'";
            cmd = new OleDbCommand(sorgu, con);
            con.Open();
            sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return sonuc;
        }

        private void urunkontrolBTN_Click(object sender, EventArgs e)
        {
            Urunler();

            admngrsl.Visible = false;
            uyelerDataGV.Visible = false;
            urunlerDataGV.Visible = true;
            uyekoduLBL.Visible = false;
            label2.Visible = false;
            Telefon.Visible = false;
            Adres.Visible = false;
            label3.Visible = false;
            uyebilgileri.Visible = false;
            uyesilBTN.Visible = false;

            hesapkullaniciadiyazisi.Visible = false;
            hesapsifreyazisi.Visible = false;
            hesapuyenoyazisi.Visible = false; 
            ID.Visible = false;
            Kullanici_Adi.Visible = false;
            Sifre.Visible = false;

            urunbilgileri.Visible = true;
            urunkontrolPNL.Visible = true;
            urunresmi.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            urunsilbtn.Visible = true;
            gorselurl.Visible = true;
            urunkodu.Visible = true;
            urunadinigir.Visible = true;
            urunfiyatigir.Visible = true;
            urunkoduyazisi.Visible = true;
            urunadiyazisi.Visible = true;
            urunfiyatiyazisi.Visible = true;

       

            /*urunlerDataGV.Columns[0].Width = 75;
            Convert.ToString(urunlerDataGV.Columns[0].HeaderText = "Ürün Kodu");
            Convert.ToString(urunlerDataGV.Columns[1].HeaderText = "Ürün Adı");
            Convert.ToString(urunlerDataGV.Columns[2].HeaderText = "Ürün Fiyatı");*/

            UyeveurunPnl.Visible = true;
            uyekoduTB.Visible = false;
            urunkoduTB.Visible = true;
            urunkoduLBL.Visible = true;
            urunkontrolPNL.Visible = true;

        }

        private void urunlerDataGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            urunkodu.Text = urunlerDataGV.CurrentRow.Cells[0].Value.ToString();
            urunadinigir.Text = urunlerDataGV.CurrentRow.Cells[1].Value.ToString();
            urunfiyatigir.Text = urunlerDataGV.CurrentRow.Cells[2].Value.ToString() + "₺";
            gorselurl.Text = urunlerDataGV.CurrentRow.Cells[3].Value.ToString();
            urunresmi.ImageLocation = urunlerDataGV.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urunfiyatigir.Enabled = true;
            urunadinigir.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = false; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = true;

            if (button4.Enabled == true)
            {
                if (urunadinigir.Text == "" || urunfiyatigir.Text == "")
                {
                    MessageBox.Show("Boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update urun set Urun='" + urunadinigir.Text + "',Fiyat='" + urunfiyatigir.Text + "',UrunGorseli='" + gorselurl.Text + "' where UrunKodu=" + urunkodu.Text + "";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Urunler();

                    urunadinigir.Enabled = false;
                    urunfiyatigir.Enabled = false;
                } 
            }
            else
            {
                if (TekrarEdenUrun(urunadinigir.Text) != 0)
                {
                    MessageBox.Show("Bu bilgilere ait kayıt bulunmaktadır. Lütfen yeni bir kayıt oluşturunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (urunadinigir.Text == "" || urunfiyatigir.Text == "")
                {
                    MessageBox.Show("Boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sorgu = "Insert into urun (UrunKodu, Urun, Fiyat, UrunGorseli) values (@UrunKodu, @Urun, @Fiyat, @UrunGorseli)";
                    cmd = new OleDbCommand(sorgu, con);
                    cmd.Parameters.AddWithValue("@UrunKodu", urunkodu.Text);
                    cmd.Parameters.AddWithValue("@Urun", urunadinigir.Text);
                    cmd.Parameters.AddWithValue("@Fiyat", urunfiyatigir.Text);
                    cmd.Parameters.AddWithValue("@UrunGorseli", gorselurl.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    urunfiyatigir.Enabled = false;
                    urunadinigir.Enabled = false;
                    button2.Enabled = false;
                }
            }

        }

        private void urunfiyatigir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)127)
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void urunfiyatigir_Leave(object sender, EventArgs e)
        {
            try
            {
                float para;
                para = float.Parse(urunfiyatigir.Text);
                urunfiyatigir.Text = para.ToString("N");
            }

            catch
            {
                float para;
                para = float.Parse(urunfiyatigir.Text);
                urunfiyatigir.Text = para.ToString("N");
            }

        }

        private void urunkoduTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08  && e.KeyChar != (char)127)
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;*.jpeg; |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            gorselurl.Text = dosyayolu;
            urunresmi.ImageLocation = dosyayolu;
        }

        public void urunsilbtn_Click(object sender, EventArgs e)
        {
            DialogResult dR1 = MessageBox.Show("Kayıt silinsin mi?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dR1 == DialogResult.Yes)
            {
                for (int i = 0; i < urunlerDataGV.SelectedRows.Count; i++)
                {
                    con.Open();
                    OleDbCommand komut = new OleDbCommand("delete from urun where Urun='" + urunlerDataGV.SelectedRows[i].Cells["Urun"].Value.ToString() + "'", con);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    con.Close();
                    ds.Clear();
                    Urunler();
                }

            }
            else
            {
                dR1 = DialogResult.No;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
