using System;

namespace seyhan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("seyhan yandık");

            //Console.Write("Merhabalar");
            //string a;
            //a = "20";
            //string d = "Mehmet";
            //int b = 10;
            //int c = 30;
            //Console.WriteLine(a+" "+d);
            //Console.WriteLine(b+c);
            // toplam + çıkarma - çarpma * bölme /
            // > buyuk < kucuk >= be  <=ke !=eşit değil == eşit = atama
            // and ve or  && and   or ||
            //Console.WriteLine("Adınız girin");
            //string ad = Console.ReadLine();
            //Console.WriteLine("İsmi Girilen Kişi " + ad);
            // Console.WriteLine("İsmini Girilen Kişi {0}", ad);
            //Console.WriteLine("Yaşınız Girin");
            //int yas =Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Kişinin Yaşı {0}",yas);
            //Console.WriteLine("Yaşınızı Girin");
            //int yas = Convert.ToInt16(Console.ReadLine());
            //if(yas<6)
            //{
            //    Console.WriteLine("Bu Filmi 6 Yaşından Ufaklar seyredebilir");
            //}
            //else if(yas>=6 && yas<=10 )
            //{
            //    Console.WriteLine("Bu 6-10 filmi çocuklar seyredebilir ");
            //}
            //else if(yas>10 && yas<=18)
            //{
            //    Console.WriteLine("Bu 10-18 filmi ergenler seyredebilir ");
            //}
            //else if(yas>18 && yas<=45)
            //{
            //    Console.WriteLine("Bu 18-45 filmi Gençler seyredebilir ");
            //}
            //else
            //{
            //    Console.Write("Bu Filmi Seyredemezsiniz");
            //}
            //Console.WriteLine("Kullanıcı Adını girin");
            //string kul = Console.ReadLine();
            //Console.WriteLine("Şifrenizi girin");
            //string sifre = Console.ReadLine();
            //if(kul=="admin" || sifre=="1234")
            //{
            //    Console.WriteLine("Kullanıcı Kabul Edildi");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı kullanıcı adı ve şifre");
            //}
            //int a = 30;
            //switch (a)
            //{
            //    case 10:
            //        Console.WriteLine("10 Eşittir"); 
            //        break;
            //    case 20:
            //        Console.WriteLine("20 Eşittir");
            //        break;
            //    case 30:
            //        Console.WriteLine("30 Eşittir");
            //        break;

            //    default:
            //        break;
            //}
            //x=x+1 x++
            //x=x-1 x--
            // x = y + x;x+=y;
            //mod alma % işaretiyle gösterilir
            //int toplam = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i%2==0)
            //    {
            //        toplam = toplam + i;
            //    }

            //}
            int toplam = 0;
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine("Bir Sayı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            Console.WriteLine("Toplam Sayi{0}",toplam);
            Console.ReadKey();
        }
    }
}
