namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //geriye değer döndürmeyen methodlar => void
            WriteTitle("Hello World!!!");
            WriteTitle("Merhaba Dünya!!!");
            Sum(2,9);
            Console.WriteLine(Sum(2,9));

            Console.WriteLine();

            int[] sayilar = new int[] { 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(Sum(sayilar));

            WriteTitle("Concat Methodu Kullanımı");

            string[] names = new string[] { "Kadir", "Murat", "Başeren" };

            Console.WriteLine(Concat(names));

        }
        static void WriteTitle(string title)
            {
                Console.WriteLine(title);

                for (int i = 0; i < title.Length; i++)
                {
                    Console.Write("=");
                }

                Console.WriteLine();
                Console.WriteLine();          
        }

        //Method Overloading

        //method imzası => methodun adına ve aldığı parametrelere bakar!

        static int Sum(int a,int b=0) //b ye değer vermezsem 0 atayacak(opsiyonel)
        {
            return a + b;
        }

        static int Sum(int[] numbers)
        {
            int result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }

        static string Concat(string[] metinler)
        {
            string result = "";
            foreach (string m in metinler)
            {
                int i = Array.IndexOf(metinler, m);
                if (i == metinler.Length - 1)
                {
                    result += m;
                }
                else
                {
                    result += m + ",";
                }
                /*result = result.TrimEnd(','); */ //yukarıdaki if/else ile aynı işi yapar!!!               
            }

            return result;
        }
    }
}