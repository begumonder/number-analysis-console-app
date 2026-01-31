using System.Runtime.ConstrainedExecution;

namespace miniproje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Görev:

            //            Kullanıcıdan 5 adet sayı al

            //            Bu sayıları bir diziye kaydet

            //Aşağıdakileri ekrana yazdır:

            //            Girilen sayıların toplamı

            //            En büyük sayı

            //En küçük sayı

            //Çift sayı adedi

            //Tek sayı adedi

            //Bonus(isteğe bağlı):

            //Ortalama hesapla

            //Negatif sayı girilirse uyarı ver
            
            int []sayilar =new int[5];
            double toplam = 0;
            int enbuyuk = 0;
            int enkucuk = 0;
            int ciftsayi = 0;
            int teksayi = 0;
            double ortalama = 0;
            for (int i=0;i<sayilar.Length;i++)
            {
                Console.Write((i+ 1) + ".sayıyı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
                toplam = sayilar[i] + toplam;
              
                if (sayilar[i]%2==0)
                {
                    ciftsayi++;
                }
                else
                {
                    teksayi++;
                }
                if (i==0)
                {
                    enbuyuk = sayilar[i];
                    enkucuk = sayilar[i];
                }
                else
                {
                    if (sayilar[i] > enbuyuk)
                    {
                        enbuyuk = sayilar[i];
                    }
                    if (sayilar[i] < enkucuk)
                    {
                        enkucuk = sayilar[i];
                    }
                }
              
            }
            ortalama = toplam / sayilar.Length;
            Console.WriteLine("Girilen sayıların toplamı= "+ toplam);
            Console.WriteLine("Girilen sayıların ortalaması= " + ortalama);
            Console.WriteLine("Girilen sayıların en büyüğü= "+enbuyuk);
            Console.WriteLine("Girilen sayıların en küçüğü= "+enkucuk);
            Console.WriteLine(ciftsayi+" adet çift sayı vardır.");
            Console.WriteLine(teksayi+" adet tek sayı vardır.");
        } //Add initial version of number analysis console application
    }
}

