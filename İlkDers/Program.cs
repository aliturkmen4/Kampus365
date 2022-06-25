using System;

namespace İlkDers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Kenar uzunluğu giriniz: ");
            int kenar = int.Parse(Console.ReadLine());

            int alan = kenar * kenar;

            Console.WriteLine("Karenin alanı: "+alan);

            int cevre = 4 * kenar;

            Console.WriteLine("Karenin çevresi: "+cevre);


        }
    }
}