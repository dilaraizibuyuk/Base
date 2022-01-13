using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Program
    {

        class Tanisma
        {
            protected void IsminizNe() //korumalı metot
            {
                Console.WriteLine("İsminiz Nedir?");
            }

        }
        class Tanisma1:Tanisma
        {
            public void YasKac()
            {
                base.IsminizNe();
                Console.WriteLine("Yaşınız Kaç Acaba?");
            }
        }

        class Tanisma2:Tanisma1
        {
            public void MeslekNe()
            {
                base.YasKac();
                Console.WriteLine("Mesleğiniz Nedir?");
            }
        }
        static void Main(string[] args)
        {
            Tanisma2 tanis = new Tanisma2();
            tanis.MeslekNe();

          //  Tanisma1 tani = new Tanisma1();
          //  tani.YasKac();
            Console.ReadKey();
        }
    }
}
