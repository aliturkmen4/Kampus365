using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorNotion
{
    static class Matematik
    {
        public static int Topla(int a,int b)
        {
            return a + b;
        }
        public static int Topla(params int[] sayilar)
        {
            int sonuc = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc = sonuc + sayilar[i];
            }

            return sonuc;
        }
        public static int Cikar(int a,int b)
        {
            return a - b;
        }
    }
}
