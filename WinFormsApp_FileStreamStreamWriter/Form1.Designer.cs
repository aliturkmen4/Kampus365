namespace WinFormsApp_FileStreamStreamWriter
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
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.btnDosyayaKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNotlar
            // 
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 20;
            this.lstNotlar.Location = new System.Drawing.Point(30, 61);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(342, 344);
            this.lstNotlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notlar";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(30, 418);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNot.Size = new System.Drawing.Size(342, 62);
            this.txtNot.TabIndex = 2;
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(278, 497);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(94, 29);
            this.btnYeniEkle.TabIndex = 3;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // btnDosyayaKaydet
            // 
            this.btnDosyayaKaydet.Location = new System.Drawing.Point(30, 497);
            this.btnDosyayaKaydet.Name = "btnDosyayaKaydet";
            this.btnDosyayaKaydet.Size = new System.Drawing.Size(124, 29);
            this.btnDosyayaKaydet.TabIndex = 4;
            this.btnDosyayaKaydet.Text = "Dosyaya Kaydet";
            this.btnDosyayaKaydet.UseVisualStyleBackColor = true;
            this.btnDosyayaKaydet.Click += new System.EventHandler(this.btnDosyayaKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 538);
            this.Controls.Add(this.btnDosyayaKaydet);
            this.Controls.Add(this.btnYeniEkle);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNotlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Not Kaydedici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstNotlar;
        private Label label1;
        private TextBox txtNot;
        private Button btnYeniEkle;
        private Button btnDosyayaKaydet;
    }
}