namespace ConvertMethodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 12;
            string sayiString = "12";

            bool varmi = false;
            string varmiString = "false";

            Console.WriteLine(sayiString+2);

            int sonuc1 = Convert.ToInt32(sayiString);

            Console.WriteLine(sonuc1+2 );

            bool sonuc2 = Convert.ToBoolean(varmiString);
            Console.WriteLine(sonuc2);
        }
    }
}