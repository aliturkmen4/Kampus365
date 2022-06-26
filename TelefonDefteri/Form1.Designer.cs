namespace TelefonDefteri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişiler";
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 20;
            this.lstKisiler.Location = new System.Drawing.Point(12, 32);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(247, 404);
            this.lstKisiler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniEkle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbGrup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtxtTelefon);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(281, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 404);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ekle / Düzenle /Sil";
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(51, 369);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(94, 29);
            this.btnYeniEkle.TabIndex = 14;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(151, 369);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 29);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(251, 369);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(118, 197);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PlaceholderText = "Buraya kişi hakkında bazı detayları yazabilirsiniz.";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(227, 87);
            this.txtAciklama.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Grup:";
            // 
            // cmbGrup
            // 
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Items.AddRange(new object[] {
            "Arkadaş",
            "Aile",
            "Dost",
            "İş Arkadaşı"});
            this.cmbGrup.Location = new System.Drawing.Point(118, 163);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(227, 28);
            this.cmbGrup.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon:";
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(118, 130);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(227, 27);
            this.mtxtTelefon.TabIndex = 6;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(118, 97);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.PlaceholderText = "johndoe@mail.com";
            this.txtEposta.Size = new System.Drawing.Size(227, 27);
            this.txtEposta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-posta:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(118, 64);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PlaceholderText = "Doe";
            this.txtSoyad.Size = new System.Drawing.Size(227, 27);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(118, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.PlaceholderText = "John";
            this.txtAd.Size = new System.Drawing.Size(227, 27);
            this.txtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Defterim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstKisiler;
        private GroupBox groupBox1;
        private Button btnYeniEkle;
        private Button btnKaydet;
        private Button btnSil;
        private TextBox txtAciklama;
        private Label label7;
        private Label label6;
        private ComboBox cmbGrup;
        private Label label5;
        private MaskedTextBox mtxtTelefon;
        private TextBox txtEposta;
        private Label label4;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
    }
}