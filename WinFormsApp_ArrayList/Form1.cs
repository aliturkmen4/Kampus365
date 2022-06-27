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

            //string[] kelimeler = new string[] { "Ali", "Türkmen" };

            //Array.Resize(ref kelimeler, 3); //arrayimi yeniden boyutlandýrdým!


            //object[] dizi = new object[];
            ArrayList yeniArray = new ArrayList(); //içerisine object türünde veri alan dizilerdir!

            yeniArray.Add(10);
            yeniArray.Add("Ali");
            yeniArray.Add(true);
            yeniArray.Add(30m);

            MessageBox.Show("Capacity: " + yeniArray.Capacity); //dizinin kapasitesi kaç?
            MessageBox.Show("Count: " + yeniArray.Count); //içerisinde kaç eleman var?

            yeniArray[0] = 16;

            MessageBox.Show((string)yeniArray[1]); //string tipini unboxing yaptým!

            for (int i = 0; i < yeniArray.Count; i++)
            {

            }
            foreach (object item in yeniArray)
            {

            }

            yeniArray.Remove("Ali"); //içerisine doðrudan deðeri vererek silinmesini saðlar!
            yeniArray.RemoveAt(3); //içerisine index numarasýný vererek silinmesini saðlar!
            yeniArray.RemoveRange(0, 2); //belli indexten baþlayarak belli adette silme yapar!

            yeniArray.Clear(); //tüm elemanlarý siler!

            yeniArray.Insert(1, "Türkmen"); //araya eleman yerleþtirme!

            bool varMi = yeniArray.Contains("Ali"); //içerisinde Ali deðeri var mý diye kontrol ederken kullanýlýr (bool sonuç döndürür!)

            int index = yeniArray.IndexOf("Ali"); //"Ali" kaçýncý indexte yer alýyor?

        }
    }
}