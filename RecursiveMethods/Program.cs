namespace RecursiveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktöriyel Hesaplama");
            Console.WriteLine("********************");

            Console.WriteLine("");

            Console.WriteLine("Lütfen bir sayı giriniz");

            int sayi=int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine(sayi+"!= "+Faktoriyel(sayi));

        }
        //recursive => özyinelemeli
        static int Faktoriyel(int deger)
        {
            if (deger == 1)
            {
                return 1;
            }
            else
            {
                return deger * Faktoriyel(deger - 1); //methodun içinde aynı methodu kullandım (özyineleme)!!
            }          
        }
    }
}