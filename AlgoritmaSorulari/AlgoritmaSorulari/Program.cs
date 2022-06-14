using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Soru1

            /*Console.Write("Lütfen pozitif bir sayı giriniz:");
            string girilenDeger = Console.ReadLine();
            Console.Write($"Lütfen {girilenDeger} adet pozitif sayıyı aralarında boşluk olacak şekilde giriniz: ");
            string[] alinanDegerler = Console.ReadLine().Split(' ');
            string ciftSayilar = "";
            foreach (string i in alinanDegerler)
            {
                int ciftSayiKontrol = Convert.ToInt32(i);                
                if (ciftSayiKontrol % 2 == 0)
                    ciftSayilar += ciftSayiKontrol + " ";
            }
            Console.WriteLine(ciftSayilar);
            Console.ReadLine();*/

            #endregion

            #region Soru2

            /*Console.Write("Lütfen aralarında boşluk bırakarak 2 adet pozitif sayı giriniz: ");
            string[] ilkGirilenDegerler = Console.ReadLine().Split(' ');
            int y = Convert.ToInt32(ilkGirilenDegerler[1]);
            Console.Write($"Lütfen aralarında boşluk bırakarak {ilkGirilenDegerler[0]} adet pozitif sayı giriniz: ");
            string[] sonGirilenDegerler= Console.ReadLine().Split(' ');
            string sonSayilar = "";
            foreach (string item in sonGirilenDegerler)
            {
                int x = Convert.ToInt32(item);
                if (x % y == 0)
                    sonSayilar += x + " ";
            }
            Console.WriteLine(sonSayilar);
            Console.ReadLine();
            */

            #endregion

            #region Soru3

            /*Console.Write("Lütfen pozitif bir sayı giriniz: ");
            string girilenDeger = Console.ReadLine();
            Console.Write($"Lütfen {girilenDeger} adet kelimeyi aralarında boşluk olacak şekilde giriniz: ");
            string[] kelimeler = Console.ReadLine().Split(' ');
            Array.Reverse(kelimeler);            
            string tersKelimeler = "";
            /*foreach (var item in kelimeler)
            {
                tersKelimeler += item + " ";
            }
            tersKelimeler=String.Join(" ", kelimeler);
            Console.WriteLine(tersKelimeler);
            Console.ReadLine();*/

            #endregion

            #region Soru4

            //Console.Write("Lütfen bir cümle yazınız: ");           
            //string kelimeler = Console.ReadLine();
            //string[] kelimelerArr = kelimeler.Split(' ');
            //int kelimeSayisi = kelimelerArr.Length;
            //char[] harfler = kelimeler.ToCharArray();
            //harfler = Array.FindAll(harfler, i => i != ' ');            
            //int harfSayisi = harfler.Length;
            //Console.WriteLine($"Kelime sayısı= {kelimeSayisi} \nHarf sayısı= {harfSayisi}");
            //Console.ReadLine();

            #endregion
        }
    }
}
