using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Yılmaz";
            musteri1.MusteriId = 100;
            musteri1.MusteriYasi = 30;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriSoyadi = "Yılmaz";
            musteri2.MusteriId = musteri1.MusteriId + 1;
            musteri2.MusteriYasi = 30;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Cevdet";
            musteri3.MusteriSoyadi = "Yılmaz";
            musteri3.MusteriId = musteri2.MusteriId + 1;
            musteri3.MusteriYasi = 30;

            

            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("-------------Müşteri Ekleme------------");
            musterimanager.Ekleme(musteri1);
            musterimanager.Ekleme(musteri2);
            musterimanager.Ekleme(musteri3);
            Console.WriteLine("--------------Müşteri Silme------------");
            musterimanager.Silme(musteri1);
            musterimanager.Silme(musteri2);
            musterimanager.Silme(musteri3);
            Console.WriteLine("-----------Müşteri Listeleme------------");
            musterimanager.Listeleme(musteri1);
            musterimanager.Listeleme(musteri2);
            musterimanager.Listeleme(musteri3);

        }
    }
}
