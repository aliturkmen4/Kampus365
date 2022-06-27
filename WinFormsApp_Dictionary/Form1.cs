using System.Collections.Generic;

namespace WinFormsApp_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string,int> list=new Dictionary<string,int>(); //key deðerleri unique olmak zorundadýr(sol taraftaki deðerler!)

            list.Add("masa", 10);
            list.Add("kitap", 5);
            list.Add("dolap", 15);

            int deger = list["kitap"];
            MessageBox.Show("Kitap adeti: " + deger);

            int yeniDeger=list["Kitap"] = 18;

            MessageBox.Show("Yeni Kitap Adeti: " + yeniDeger);
        }
    }
}