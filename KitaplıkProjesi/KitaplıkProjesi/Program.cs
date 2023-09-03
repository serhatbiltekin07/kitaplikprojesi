using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KitaplıkProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Projemizde yerli ve yabancı olmak üzere 2 kategoriden oluşan  kitap listesi bulunacak.
            Sistemi kullanan öğrenci kitap listesini görebilecek, yazarlar ile ilgili bilgi alabilecek.
            Öğrenci sistem üzerinden kitap alabilecek.
            Kendi bilgilerini sisteme kaydedebilecek.*/

            int toplamfiyat = 0;
            string secim;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi     **  Yabancı Kitaplar Kategorisi       **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri         **  7-Tuna Klavuzu: Jules Verne       **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri           **  8-Bir Kuzey Macerası: jack London **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip  **  9-Altıncı Koğuş: Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: Oğuz Atay **  10-Kumarbaz: Dostoyevski          **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günler : H.Yücel    **  11-İki Şehrin Hİkayesi: C.Dickens **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf : S.Ali      **  12-Vişne Bahçesi: Anton Çehov     **");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası:");
            char islem;
            islem= Convert.ToChar(Console.ReadLine());
            if(islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını girin:");
                string numara;
                numara= Console.ReadLine(); 
                switch (numara)
                {
                    case "1": Console.Write("Çalıkuşu: 12TL"); break;
                    case "2": Console.Write("Yaban: 14TL"); break;
                    case "3": Console.Write("Sinekli Bakkal: 16TL"); break;
                    case "4": Console.Write("Tehlikeli Oyunlar: 11TL"); break;
                    case "5": Console.Write("Geçtiğim Günler: 8TL"); break;
                    case "6": Console.Write("Kuyucaklı Yusuf: 13TL"); break;
                    case "7": Console.Write("Tuna Klavuzu: 17TL"); break;
                    case "8": Console.Write("Bir Kuzey Macerası: 4TL"); break;
                    case "9": Console.Write("Altıncı Koğuş: 5TL"); break;
                    case "10": Console.Write("Kumarbaz: 10TL"); break;
                    case "11": Console.Write("İki Şehrin Hİkayesi: 13TL"); break;
                    case "12": Console.Write("Vişne Bahçesi: 6TL"); break;
                    default: Console.WriteLine("Böyle bir kitap mevcut değil, numarayı kontrol edin"); break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız:");
                ad = Console.ReadLine();
                Console.Write("Soyadınız:");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz:");
                universite = Console.ReadLine();

                string dosya = "C:\\Users\\user\\Desktop\\kullanici.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız:" + ad);
                sw.WriteLine("Soyadınız:" + soyad);
                sw.WriteLine("Üniversiteniz:" + universite);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();

                Console.WriteLine("***** Bugünün Kitabı: Çalıkuşu *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                FileStream fs = new FileStream ("C:\\Users\\user\\Desktop\\kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close(); 
                //Burası kitap arşivi olacak
                Console.WriteLine();
                Console.WriteLine("************************************");
            }
            if (islem == '5')
            {
                for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarsı:");
                    secim = Console.ReadLine();
                    if(secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    else if(secim == "2")
                    {
                        toplamfiyat = toplamfiyat + 14;
                    }
                    else if(secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 17;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 4;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 5;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 10;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 6;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap numarası yok");
                        Console.WriteLine();
                        Console.Write("Başka bir kitap almak ister misiniz:");
                        string cevap = Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR")
                            break;

                    
                }
                Console.WriteLine("Toplam tutar: " + toplamfiyat);

            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while(sayi != tahmin)
                {
                    Console.WriteLine("Sayı giriniz:");
                    tahmin =Convert.ToInt16(Console.ReadLine());
                    if(tahmin > sayi)
                    {
                        Console.Write("Daha Küçük");
                    }
                    if (tahmin < sayi)
                    {
                        Console.Write("Daha Büyük");
                    }
                    if(tahmin == sayi)
                    {
                        Console.Write("Bildiniz");
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
