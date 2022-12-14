using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNo = "12345";
            musteri1.CustomerName = "Duhan";
            musteri1.CustomerSurname = "Turan";
            musteri1.Id = 1;
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CompanyName = "Şirinevler";
            musteri2.CustomerNo = "54321";
            musteri2.TaxNo = "123456";

            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
