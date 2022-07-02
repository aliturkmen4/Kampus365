namespace WinFormsApp_DataSharingBetweenForms
{
    partial class Form2
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.btnBirlestirKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(43, 40);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(50, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "label1";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(43, 95);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "label2";
            // 
            // btnBirlestirKapat
            // 
            this.btnBirlestirKapat.Location = new System.Drawing.Point(166, 212);
            this.btnBirlestirKapat.Name = "btnBirlestirKapat";
            this.btnBirlestirKapat.Size = new System.Drawing.Size(120, 29);
            this.btnBirlestirKapat.TabIndex = 2;
            this.btnBirlestirKapat.Text = "Birleştir Kapat";
            this.btnBirlestirKapat.UseVisualStyleBackColor = true;
            this.btnBirlestirKapat.Click += new System.EventHandler(this.btnBirlestirKapat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 290);
            this.Controls.Add(this.btnBirlestirKapat);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Button btnBirlestirKapat;
    }
}