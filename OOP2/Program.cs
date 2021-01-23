using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {         
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123456789";

            //Kodlama.io girişi
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 3;
            musteri2.MusteriNo = "44123456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "7644853635";

            //Gerçek(Kişi) Müşteri - Tüzel(Şirket) Müşteri
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);



            //SOLID in L harfi bunun yanlış olduğunu söyler.

        }
    }
}
