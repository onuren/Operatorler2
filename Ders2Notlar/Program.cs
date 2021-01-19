using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2Notlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Özel Aritmetiksel Operatörler

            //int sayi1 = 15;
            ////sayi=+=5; -= /= *= olabilir
            //sayi1++; // ++ -- olabilir
            //Console.WriteLine(sayi1);
            #endregion

            #region Karşılaştırma Operatörleri

            //int sayi =5;
            //bool sonuc = sayi > 10;
            //Console.WriteLine(sonuc);
            ////>= <= 

            #endregion

            #region Mantıksal Operatörler

            //int sayi = 15;
            //Console.WriteLine(sayi >= 10 && sayi <= 20);//10 dan büyük ve 20 den küçük
            ////&& ve operatörü,  || veya operatörü
            #endregion

            #region Uygulama

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool sorgu = (sayi < 10 || sayi > 20);
            //Console.WriteLine(sorgu);

            /* 2. yol
            bool sonuc =sayi >10 && Sayi<20);
            Console.WriteLine(!sonuc);  ünlem işareti sonucun değilini gösterir
            */

            /* 3.yol
            Console.WriteLine(!(sayi>10 && sayi<20)); 
            */

            #endregion

        }
    }
}
