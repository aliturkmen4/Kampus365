namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            //döngü her halkuarda 1 kere çalışır, her çalışmadan sonra while ın içini sağlayıp sağlamadığını kontrol eder!

            do
            {
                Console.WriteLine("Sayaç: "+sayac);
                sayac++;
            } while (sayac<10);
        }
    }
}