using System.Collections;

namespace WinFormsApp_GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList listt = new ArrayList();

            listt.Add("Ali");
            listt.Add(10);
            listt.Add(false);
            listt.Add("Türkmen");
            listt.Add(55);

            int toplam = 0;

            foreach (object item in listt) //buradaki iþlemi tip güvenli yapmak için generic list'i kullanýlýrým!
            {
                if (item.GetType() == typeof(int))
                {
                    toplam += (int)item; //tip kontrolü yaptým ve tipi int olanlarýn deðerini toplam deðiþkenine attým!                 
                }
            }
            MessageBox.Show("Toplam: " + toplam);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list= new List<string>();
            list.Add("Ali");
            list.Add("Türkmen");

            foreach (string item in list)
            {
                //code..
            }
        }
    }
}