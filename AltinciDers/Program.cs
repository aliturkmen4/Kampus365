namespace AltinciDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region eleman sayısı kullanıcı tarafından belirlenen ve içini doldurduğu bir dizi örneği
            //Console.WriteLine("Öğrenci Sayısını Giriniz: ");
            //int ogrenciSayisi = int.Parse(Console.ReadLine());

            //string[] ogrenciListesi = new string[ogrenciSayisi];

            //for (int i = 0; i < ogrenciSayisi; i++)
            //{
            //    Console.WriteLine((i+1)+" . Öğrenci Adını Giriniz: ");
            //    ogrenciListesi[i] = Console.ReadLine();
            //}
            ////ogrenciListesi.Reverse();

            //foreach (var ogrenci in ogrenciListesi)
            //{
            //    Console.WriteLine(ogrenci);
            //} 
            #endregion

            #region girilen kelimeyi tersten yazdırma
            //Console.WriteLine("Tersini almak istediğiniz kelimeyi giriniz: ");
            //string kelime = Console.ReadLine();

            //char[] harfler = kelime.ToCharArray(); //kelime elemanlarını char arrayine çevirdim!

            //char[] yeniHarfSirasi = harfler.Reverse().ToArray(); //reverse IEnumarable döndürdüğü için onu da array'e çevirdim!

            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    Console.Write(yeniHarfSirasi[i]);
            //} 
            #endregion

            //TrimStart() => baştaki boşluğu kaldırır!

            //TrimEnd() => sondaki boşluğu siler!

            //Trim() => değişkenin içindeki boşlukları kaldırır (başı ve sonu)!!

            //ToUpper() => kelimedeki bütün harfleri büyültür!

            //ToLower() => kelimedeki bütün harfleri küçültür!

            //PadLeft(5,'0') => bu kelimenin değeri 1 olsun ben bunu 5 haneli tutmak istiyorum char olarak da 0 kullanmak istiyorum solunda dedim yani artık 00001 olarak tutulacak!!!!!!!!! (fatura ve sipariş no vs oluştururken kullanılabilir!)

            //Substring(i,1) => i.indexten başla 1 er 1 er böl!!!

            #region hesap makinesi

            int secim;
            do
            {
                MenuyuOlustur();

                secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    BaslikOlustur("Toplama İşlemi");

                    Toplamaİslemi();

                    break;
                }
                else if (secim == 2)
                {
                    BaslikOlustur("Çıkarma İşlemi");

                    Cikarmaİslemi();

                    break;
                }
                else if (secim == 3)
                {
                    BaslikOlustur("Çarpma İşlemi");

                    Carpmaİslemi();

                    break;
                }
                else if (secim == 4)
                {
                    BaslikOlustur("Bölme İşlemi");

                    Bolmeİslemi();

                    break;
                }
                else
                {
                    break;
                }
            } while (secim != 0);
            #endregion
        }

        //public static void DevamUyariCikar()
        //{
        //    Console.WriteLine("");
        //    Console.WriteLine("Lütfen devam etmek için bir tuşa basın..");
        //    Console.ReadKey();
        //}

        public static void BaslikOlustur(string baslik)
        {
            Console.Clear();
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void BaslikOlustur()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void Bolmeİslemi()
        {
            Console.WriteLine("Bölme işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Bölme işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            double sayi2 = double.Parse(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                double result = sayi1 / sayi2;
                Console.WriteLine("Sonuç: " + result);
            }
            else if (sayi1 < sayi2)
            {
                double result = sayi2 / sayi1;
                Console.WriteLine("Sonuç: " + result);
            }
            else
            {
                double result = 1;
                Console.WriteLine("Sonuç: " + result);
            }

            //DevamUyariCikar();
        }

        public static void Carpmaİslemi()
        {
            Console.WriteLine("Çarpma işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Çarpma işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int result = sayi1 * sayi2;

            Console.WriteLine("Sonuç: " + result);

            //DevamUyariCikar();
        }

        public static void Cikarmaİslemi()
        {
            Console.WriteLine("Çıkarma işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Çıkarma işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int result = sayi1 - sayi2;

            Console.WriteLine("Sonuç: " + result);

            //DevamUyariCikar();
        }
        public static void Toplamaİslemi()
        {
            Console.WriteLine("Toplama işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplama işlemi yapmak istedğiniz ilk sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int result = sayi1 + sayi2;

            Console.WriteLine("Sonuç: " + result);

            //DevamUyariCikar();
        }

        public static void MenuyuOlustur()
        {
            Console.Clear();
            Console.WriteLine("İşlem Menüsü");
            Console.WriteLine("=============");
            Console.WriteLine("1-Toplama İşlemi Yap \n2-Çıkarma İşlemi Yap \n3-Çarpma İşlemi Yap \n4-Bölme İşlemi Yap \n0-Çıkış");
        }

    }
}