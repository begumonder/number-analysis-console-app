using System.Runtime.ConstrainedExecution;

namespace miniproje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar= KullaniciGirisi();
        
            Console.WriteLine("Girilen sayıların toplamı= " + Toplam(sayilar));
            Console.WriteLine("Girilen sayıların ortalaması= " + Ortalama(sayilar));
            Console.WriteLine("Girilen sayıların en büyüğü= " + EnBuyukSayi(sayilar));
            Console.WriteLine("Girilen sayıların en küçüğü= " + EnKucukSayi(sayilar));
            Console.WriteLine(CiftSayi(sayilar) + " adet çift sayı vardır.");
            Console.WriteLine(TekSayi(sayilar) + " adet tek sayı vardır.");
        }
        //Kullanıcıdan girilen kapasite kadar sayı girişi alan metod
        static int[] KullaniciGirisi()
        {
            Console.Write("Kaç adet sayı girişi yapacaksınız: ");
            int kapasite = int.Parse(Console.ReadLine());
            int[] sayilar = new int[kapasite];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 1) + ".sayıyı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            return sayilar;
        }
        //dizideki saıların toplamını bulan metod 
        static int Toplam(int[] sayi)
        {
            int toplam = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                toplam = toplam + sayi[i];
            }
            return toplam;
        }
        //dizideki sayılardan en büyüğünü bulan metod
        static int EnBuyukSayi(int[] sayi)
        {
            int enbuyuk = sayi[0];
            for (int i=0;i<sayi.Length;i++)
            {
                
                if (sayi[i]>enbuyuk)
                {
                    enbuyuk=sayi[i];
                }
                
            }
            return enbuyuk;
        }
        //dizideki sayılardan en küçüğünü bulan metod
        static int EnKucukSayi(int[]sayi)
        {
            int enkucuk = sayi[0];
            for(int i=0; i<sayi.Length;i++)
            {
                if(sayi[i]<enkucuk)
                {
                    enkucuk=sayi[i];
                }
            }
            return enkucuk;
        }
        //dizideki sayiların ortalmasını bulan metod 
        static double Ortalama(int[] sayi)
        {

            double ortalama = (double)Toplam(sayi) / sayi.Length;
            return ortalama;
        }
        //dizideki çift sayiların adedini bula metod
        static int CiftSayi(int[] sayi)
        {
            int ciftsayi = 0;
            for (int i =0;i<sayi.Length;i++)
            {
                if (sayi[i]%2==0)
                {
                    ciftsayi++;
                }
            }
            return ciftsayi;
        }
         //dizideki tek sayıarın adedini bula metod
        static int TekSayi(int[] sayi)
        {
            int teksayi = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] % 2 !=0)
                {
                    teksayi++;
                }
            }
            return teksayi;
        }
    }
}

