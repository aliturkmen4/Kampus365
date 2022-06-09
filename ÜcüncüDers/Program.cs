namespace ÜcüncüDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sınav notunuzu giriniz: ");
            double not1 = double.Parse(Console.ReadLine());

            Console.WriteLine("2.Sınav notunuzu giriniz: ");
            double not2 = double.Parse(Console.ReadLine());

            Console.WriteLine("3.Sınav notunuzu giriniz: ");
            double not3 = double.Parse(Console.ReadLine());

            double ortalama;

            ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 60)
            {
                Console.WriteLine("Geçtiniz");
            }
            else
            {
                Console.WriteLine("Kaldınız");
            }

            Console.WriteLine("Trafik lambası rengini giriniz: ");
            string renk = Console.ReadLine();

            switch (renk)
            {
                case "yesil":
                    Console.WriteLine("Yeşil yandı geçebilirsin.");
                    break;
                case "sarı":
                    Console.WriteLine("Sarı yandı bekle.");
                    break;
                case "kırmızı":
                    Console.WriteLine("Kırmızı yandı dur.");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    break;
            }

            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i);
            }

            double toplam = 0;
            double toplam2 = 0;
            double sonuc = 0;
            Console.WriteLine("Kaça kadar toplama yapmak istiyorsunuz?");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                 toplam += i;
                if (i % 3 == 0)
                {
                    toplam2 += i;
                 }

                sonuc = toplam / toplam2;
            }
            Console.WriteLine(sonuc);        
        }
    }
}