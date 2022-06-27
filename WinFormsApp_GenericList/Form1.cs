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
            listt.Add("T�rkmen");
            listt.Add(55);

            int toplam = 0;

            foreach (object item in listt) //buradaki i�lemi tip g�venli yapmak i�in generic list'i kullan�l�r�m!
            {
                if (item.GetType() == typeof(int))
                {
                    toplam += (int)item; //tip kontrol� yapt�m ve tipi int olanlar�n de�erini toplam de�i�kenine att�m!                 
                }
            }
            MessageBox.Show("Toplam: " + toplam);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list= new List<string>();
            list.Add("Ali");
            list.Add("T�rkmen");

            foreach (string item in list)
            {
                //code..
            }
        }
    }
}