namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilarim = new int[] { 3, 5, 9, 45 };
            int sonuc = Topla(sayilarim);
            Console.WriteLine("Sayıların toplamı: "+sonuc);

            int sonuc2 = Topla(12, 4, 67, 99);
            Console.WriteLine("Sayıların toplamı: "+sonuc2);
        }

        //params keywordunu arraylerde kullanarak çağırırken elle direkt sayı olarak vermeye olanak sağlarsın!


        static int Topla(params int[] sayilar)  //1den fazla parametre alıyorsa params alan sonda olmak zorunda!! params => dizi de olmak zorunda!!!
        {
            int toplam = 0;

            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }

            return toplam;
        }
    }
}