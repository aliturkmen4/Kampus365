namespace BreakContinueKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue; //kodu döngü kısmına atar o yüzden ekranda 2 yi görmeyiz!
                }

                Console.WriteLine("Sayaç: "+i);

                if (i == 5)
                {
                    break; //direkt olarak döngünün sonlanmasını sağlar!
                }
            }
        }
    }
}