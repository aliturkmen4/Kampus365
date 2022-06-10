namespace DördüncüDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Magenta; //enum kullanarak

            //int[] sayilar = new int[3];

            //sayilar[0] = 5;
            //sayilar[1] = 6;
            //sayilar[2] = 7;
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[2]);

            //string[] metinler = new string[] { "Ali", "Türkmen", "Kampüs365" };

            //Console.WriteLine(metinler[0]);
            //Console.WriteLine(metinler[1]);
            //Console.WriteLine(metinler[2]);

            //Console.ResetColor();

            //Console.Title = "Diziler Konusu";
            //Console.WriteLine(Console.Title);

            //eylemler methodtur!

            //for (int i = 0; i < metinler.Length; i++)
            //{
            //    Console.WriteLine(metinler[i]);
            //}

            //#region Console Properties
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("hello world!");

            //Console.Beep(1000, 900);

            //Console.WriteLine(Console.WindowHeight);
            //Console.WriteLine(Console.WindowTop);
            //Console.WriteLine(Console.WindowLeft);
            //Console.ResetColor();
            //#endregion

            //Console.WriteLine("Depoya girilen ürün adedi: ");
            //int count = int.Parse(Console.ReadLine());

            //string[] products = new string[count];

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". Ürün Adı: ");
            //    string productName = Console.ReadLine();
            //    products[i] = productName;
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("ÜRÜNLER");
            //Console.WriteLine("=======");

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". Ürün: " + products[i]);
            //}

            //string[] products2 = new string[0];
            //string entry = " ";
            //int k = 0;

            //do
            //{
            //    Console.WriteLine((k + 1) + ". Ürün Adı: ");
            //    entry = Console.ReadLine();

            //    if (entry == " ")
            //    {
            //        break;
            //    }

            //    Array.Resize(ref products2, products.Length + 1); //dizi boyunu arttırmak için
            //    products2[k] = entry;

            //    k++;

            //} while (entry != " ");

            string[] degerler = new string[2];
            degerler[0] = "aaa";
            degerler[1] = "sss";

            //for (int i = 0; i < degerler.Length; i++)
            //{
            //    string deger = degerler[i];
            //    Console.WriteLine(deger);
            //}

            foreach (string deger in degerler)
            {
                int s = Array.IndexOf(degerler, deger);

                Console.WriteLine((s+1) + ". Değer: " +deger);
            }
        }
    }
}