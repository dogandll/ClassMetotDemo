using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Tebrikler, müşteri eklendi :" + musteri.Ad + ' ' + musteri.Soyad);
            }
            
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} isimli müşteri silindi !", musteri.Ad);
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var item in musteriler)
            {
                Console.WriteLine(item.Ad);
            }

        }
    }
}
