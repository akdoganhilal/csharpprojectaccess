namespace HILALVERITABANI
{
    partial class Kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciadiTB = new System.Windows.Forms.TextBox();
            this.parolaTB = new System.Windows.Forms.TextBox();
            this.telefonmtb = new System.Windows.Forms.MaskedTextBox();
            this.adresrtb = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.idTB = new System.Windows.Forms.TextBox();
            this.uyelerDataGV = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(57)))), ((int)(((byte)(104)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Location = new System.Drawing.Point(134, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYIT OL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // kullaniciadiTB
            // 
            this.kullaniciadiTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.kullaniciadiTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciadiTB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.kullaniciadiTB.Location = new System.Drawing.Point(90, 218);
            this.kullaniciadiTB.Name = "kullaniciadiTB";
            this.kullaniciadiTB.Size = new System.Drawing.Size(170, 14);
            this.kullaniciadiTB.TabIndex = 0;
            this.kullaniciadiTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciadiTB_KeyPress);
            // 
            // parolaTB
            // 
            this.parolaTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.parolaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parolaTB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.parolaTB.Location = new System.Drawing.Point(90, 269);
            this.parolaTB.Name = "parolaTB";
            this.parolaTB.Size = new System.Drawing.Size(170, 14);
            this.parolaTB.TabIndex = 1;
            this.parolaTB.UseSystemPasswordChar = true;
            // 
            // telefonmtb
            // 
            this.telefonmtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.telefonmtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonmtb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.telefonmtb.Location = new System.Drawing.Point(90, 321);
            this.telefonmtb.Mask = "(999) 000-0000";
            this.telefonmtb.Name = "telefonmtb";
            this.telefonmtb.Size = new System.Drawing.Size(170, 14);
            this.telefonmtb.TabIndex = 3;
            // 
            // adresrtb
            // 
            this.adresrtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(249)))));
            this.adresrtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresrtb.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.adresrtb.Location = new System.Drawing.Point(90, 370);
            this.adresrtb.Name = "adresrtb";
            this.adresrtb.Size = new System.Drawing.Size(170, 74);
            this.adresrtb.TabIndex = 4;
            this.adresrtb.Text = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.Thistle;
            this.linkLabel1.Location = new System.Drawing.Point(102, 552);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Zaten bir hesabım var ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // idTB
            // 
            this.idTB.Enabled = false;
            this.idTB.Location = new System.Drawing.Point(349, 36);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(36, 20);
            this.idTB.TabIndex = 9;
            // 
            // uyelerDataGV
            // 
            this.uyelerDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyelerDataGV.Location = new System.Drawing.Point(391, 38);
            this.uyelerDataGV.Name = "uyelerDataGV";
            this.uyelerDataGV.Size = new System.Drawing.Size(13, 18);
            this.uyelerDataGV.TabIndex = 61;
            this.uyelerDataGV.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(57)))), ((int)(((byte)(104)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(270, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 15);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(297, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 35);
            this.button3.TabIndex = 66;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(350, 600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uyelerDataGV);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.adresrtb);
            this.Controls.Add(this.telefonmtb);
            this.Controls.Add(this.parolaTB);
            this.Controls.Add(this.kullaniciadiTB);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OYUNCAKLAR | HİLAL AKDOĞAN";
            this.Load += new System.EventHandler(this.Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyelerDataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kullaniciadiTB;
        private System.Windows.Forms.TextBox parolaTB;
        private System.Windows.Forms.MaskedTextBox telefonmtb;
        private System.Windows.Forms.RichTextBox adresrtb;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.DataGridView uyelerDataGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}