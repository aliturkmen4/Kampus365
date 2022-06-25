namespace ClassConstructorNotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranIslemleri ei = new EkranIslemleri();
            ei.EkranaAltiCiziliBaslikYaz("ClassConstructorNotion");
            ei.EkranaMaddeOlarakYaz("Class Kavramı");
            ei.EkranaMaddeOlarakYaz("Classlar kullanılmadan önce new ile instance'ı üretilir!");
            ei.EkranaMaddeOlarakYaz("Ardından public methodları kullanılır!");

            int toplam=Matematik.Topla(5, 6, 7, 4);
            Console.WriteLine("Toplam: "+toplam);

            Console.WriteLine("Fark: "+Matematik.Cikar(10,4));
        }
    }
}