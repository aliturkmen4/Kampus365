namespace WinFormsApp_FileStreamStreamReader
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.btnDosyayaKaydet = new System.Windows.Forms.Button();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notlar";
            // 
            // lstNotlar
            // 
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 20;
            this.lstNotlar.Location = new System.Drawing.Point(26, 48);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(318, 344);
            this.lstNotlar.TabIndex = 1;
            // 
            // btnDosyayaKaydet
            // 
            this.btnDosyayaKaydet.Location = new System.Drawing.Point(26, 493);
            this.btnDosyayaKaydet.Name = "btnDosyayaKaydet";
            this.btnDosyayaKaydet.Size = new System.Drawing.Size(134, 29);
            this.btnDosyayaKaydet.TabIndex = 2;
            this.btnDosyayaKaydet.Text = "Dosyaya Kaydet";
            this.btnDosyayaKaydet.UseVisualStyleBackColor = true;
            this.btnDosyayaKaydet.Click += new System.EventHandler(this.btnDosyayaKaydet_Click);
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Location = new System.Drawing.Point(250, 493);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(94, 29);
            this.btnYeniEkle.TabIndex = 3;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(26, 412);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNot.Size = new System.Drawing.Size(318, 64);
            this.txtNot.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 558);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.btnYeniEkle);
            this.Controls.Add(this.btnDosyayaKaydet);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Not Kaydedici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstNotlar;
        private Button btnDosyayaKaydet;
        private Button btnYeniEkle;
        private TextBox txtNot;
    }
}