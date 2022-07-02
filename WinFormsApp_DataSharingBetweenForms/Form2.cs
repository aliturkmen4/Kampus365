﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_DataSharingBetweenForms
{
    public partial class Form2 : Form
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string AdSoyad { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblAd.Text = Ad;
            lblSoyad.Text = Soyad;
        }

        private void btnBirlestirKapat_Click(object sender, EventArgs e) //FORM2 içerisinde sakın FORM1i newleme!!!
        {
            AdSoyad = Ad + " " + Soyad;
            this.Close();
        }
    }
}
