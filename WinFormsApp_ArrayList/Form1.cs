using System.Collections;

namespace WinFormsApp_ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] sayilar = new int[3];
            //sayilar[0] = 3;
            //sayilar[1] = 4;

            //string[] kelimeler = new string[] { "Ali", "T�rkmen" };

            //Array.Resize(ref kelimeler, 3); //arrayimi yeniden boyutland�rd�m!


            //object[] dizi = new object[];
            ArrayList yeniArray = new ArrayList(); //i�erisine object t�r�nde veri alan dizilerdir!

            yeniArray.Add(10);
            yeniArray.Add("Ali");
            yeniArray.Add(true);
            yeniArray.Add(30m);

            MessageBox.Show("Capacity: " + yeniArray.Capacity); //dizinin kapasitesi ka�?
            MessageBox.Show("Count: " + yeniArray.Count); //i�erisinde ka� eleman var?

            yeniArray[0] = 16;

            MessageBox.Show((string)yeniArray[1]); //string tipini unboxing yapt�m!

            for (int i = 0; i < yeniArray.Count; i++)
            {

            }
            foreach (object item in yeniArray)
            {

            }

            yeniArray.Remove("Ali"); //i�erisine do�rudan de�eri vererek silinmesini sa�lar!
            yeniArray.RemoveAt(3); //i�erisine index numaras�n� vererek silinmesini sa�lar!
            yeniArray.RemoveRange(0, 2); //belli indexten ba�layarak belli adette silme yapar!

            yeniArray.Clear(); //t�m elemanlar� siler!

            yeniArray.Insert(1, "T�rkmen"); //araya eleman yerle�tirme!

            bool varMi = yeniArray.Contains("Ali"); //i�erisinde Ali de�eri var m� diye kontrol ederken kullan�l�r (bool sonu� d�nd�r�r!)

            int index = yeniArray.IndexOf("Ali"); //"Ali" ka��nc� indexte yer al�yor?

        }
    }
}