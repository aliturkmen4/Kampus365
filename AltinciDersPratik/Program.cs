namespace AltinciDersPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region replace ve datetime methodları kullanımı örneği
            //Sayın Ali Türkmen , 01.01,2022 tarihinde almış olduğunuz ürünlere ait sipariş numarası XXXX dir. Bu numara ile siparişinizi takip edebilirsiniz.

            //kullanıcıdan isim soyisim alınacak.
            //kullanıcıdan sipariş numarası alınacak.
            //ilgili değerleri değiştirerek yeni metni ekrana yazdıralım.

            string mailIcreigi = "Sayın {AdiSoyadi}, {Tarih} tarihinde almış olduğunuz ürünlere ait sipariş numarası {SiparisNo} dir.Bu numara ile siparişinizi takip edebilirsiniz.";

            Console.WriteLine("Adınız soyadınızı giriniz");
            string name = Console.ReadLine();

            Console.WriteLine("Sipariş numaranızı giriniz");
            string siparisNo = Console.ReadLine();

            mailIcreigi = mailIcreigi.Replace("{AdiSoyadi}", name.ToUpper());
            mailIcreigi = mailIcreigi.Replace("{SiparisNo}", siparisNo);
            mailIcreigi = mailIcreigi.Replace("{Tarih}", DateTime.Now.ToString("dd.MM.yyyy")); //sadece gün ay yıl formatında alıyorum!

            Console.WriteLine(mailIcreigi);
            #endregion


            #region dizi kullanım örneği
            //5 elemanlı bir dizi olacak
            //dizinin elemanlarını kullanıcı girecek
            //dizinin içindeki en uzun metni ekrana yazdıracak
            //en uzun metnin karakter sayısını yazacak
            //en uzun metnin dizideki index numarasını ekrana yazdıracak

            string[] dizi = new string[5];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine((i+1) + " . elemanı giriniz: ");
                dizi[i] = Console.ReadLine();
            }

            int enUzunMetinKarakterSayisi=0;
            string enUzunMetin="";
            int uzunluk=0;
            int indexNo = 0;

            for (int i = 0; i < dizi.Length; i++)
            {               
                if (dizi[i].Length > uzunluk)
                {
                    uzunluk = dizi[i].Length;
                    enUzunMetinKarakterSayisi = dizi[i].Length;
                    enUzunMetin = dizi[i];
                    indexNo = i;
                }               
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Dizinin içindeki en uzun metin: "+enUzunMetin);
            Console.WriteLine("Dizideki en uzun metnin karakter sayısı: "+ enUzunMetinKarakterSayisi.ToString());
            Console.WriteLine("Dizideki en uzun metin " + indexNo + ". indexte bulunuyor.");
            #endregion
        }
    }
}