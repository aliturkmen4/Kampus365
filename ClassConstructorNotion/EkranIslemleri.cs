using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorNotion
{
    internal class EkranIslemleri
    {
        string _cizgiKarakteri;
        string _maddeImiKarakteri;
        public EkranIslemleri(string cizgiKarakteri,string maddeImiKarakteri) //bu class new lenirse burası tetiklenir!
        {
            this._cizgiKarakteri = cizgiKarakteri;
            this._maddeImiKarakteri = maddeImiKarakteri;
        }
        public EkranIslemleri() //ctor larda imzaya göre overload yapılabilir!
        {
            _cizgiKarakteri = "-";
            _maddeImiKarakteri = "=>";
        }
        public void EkranaAltiCiziliBaslikYaz(string baslik)
        {
            Console.Clear();
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write(_cizgiKarakteri);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void EkranaMaddeOlarakYaz(string metin)
        {
            Console.WriteLine(_maddeImiKarakteri+" "+metin);
        }
    }
}
