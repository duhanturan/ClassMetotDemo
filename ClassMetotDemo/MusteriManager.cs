using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId+ " ID numaralı Musteri Eklendi!: " + musteri.MusteriAdi);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " ID numaralı Müşteri silinmiştir! : "+ musteri.MusteriAdi);
        }

        public void Listeleme (Musteri musteri)
        {
            
            Console.WriteLine(musteri.MusteriId + " ID numaralı " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            
        }
    }
}
