using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Doğan";
            musteri1.Soyad = "Dellal";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "İnci Sare";
            musteri2.Soyad = "Dellal";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "İmge Deniz";
            musteri3.Soyad = "Dellal";

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("--------------- Müşteri Ekleme ---------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Ekle(musteriler);

            Console.WriteLine("--------------- Müşteri Listeleme ---------------");
            
            musteriManager.Listele(musteriler);

            Console.WriteLine("--------------- Müşteri Silme ! ---------------");
            musteriManager.Sil(musteri3);

            Console.ReadKey();

        }
    }
}
