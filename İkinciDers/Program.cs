namespace İkinciDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variable Types
            string metin = "14.3";
            double gercekSayi = double.Parse(metin);

            Console.WriteLine("5" + "5");
            Console.WriteLine("5" + 5 + 4);

            int sayi1 = 10;
            bool varmi = true;
            double sayi2 = 15.4;

            string sayi1Str = sayi1.ToString();
            string varmiStr = varmi.ToString();
            string sayi2Str = sayi2.ToString();

            string donenDeger1 = Convert.ToString(sayi1);
            string donenDeger2 = Convert.ToString("true");

            byte deger3 = 0;
            bool donenDeger3 = Convert.ToBoolean(deger3);

            Console.WriteLine(donenDeger3);

            object obj1 = "Murat"; //boxing (objecte değer atama)
            object obj2 = 4;
            object obj3 = true;
            object obj4 = 14.3;
            object obj5 = 'a';

            string ad = obj1.ToString();
            int yas = (int)obj2; //casting - unboxing (objectin içindeki değeri çıkarma işlemi)
            bool yasiyormu = (bool)obj3;
            #endregion

            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            #region Condition Statements
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayı tektir.");
            }


            if (sayi > 3)
            {
                Console.WriteLine("Sayi 3ten büyüktür.");
            }
            else if (sayi == 3)
            {
                Console.WriteLine("Sayi 3e eşittir.");
            }
            else
            {
                Console.WriteLine("Sayi 3ten küçüktür.");
            }

            if (sayi > 3 || sayi == 3) //nested-if
            {
                if (sayi == 3)
                {
                    Console.WriteLine("Sayi 3e eşittir.");
                }
                else
                {
                    Console.WriteLine("Sayi 3ten büyüktür.");
                }
            }
            else
            {
                Console.WriteLine("Sayi 3ten küçüktür.");
            }

            if (sayi > 3 && sayi < 9)
            {
                Console.WriteLine("Sayi 3 ile 9 arasındadır.");
            }
            else if (sayi == 3)
            {
                Console.WriteLine("Girdiğiniz sayi 3tür");
            }
            else if (sayi == 9)
            {
                Console.WriteLine("Girdiğiniz sayi 9dur.");
            }
            else
            {
                if (sayi > 9)
                {
                    Console.WriteLine("Girdiğiniz sayi 9dan büyüktür.");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayi 3ten küçüktür.");
                }
            }
            #endregion

            #region LoginExample
            Console.WriteLine("Kullanıcı adı giriniz: ");
            string username = Console.ReadLine();

            Console.WriteLine("Şire giriniz: ");
            string password = Console.ReadLine();

            if (username == "ali" && password == "123")
            {
                Console.WriteLine("Giriş başarılı yönlendiriliyorsunuz...");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı adı veya şifre!");
            } 
            #endregion

            #region Try/Catch
            try
            {
                int deger = 3;
                double sonuc = deger / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            //finally
            //{

            //}
            Console.WriteLine("Kod çalışmaya devam ediyor");
            #endregion

            #region Loops

            int sayac=0;
            sayac = sayac + 1;
            sayac += 3;
            sayac++;
            ++sayac;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World!");
            }
            #endregion
        }
    }
}