using ConsoleUI;
//musteri tanımlamaları database simulasyon


Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.Ad = "Zeynep";
musteri1.Soyad = "Şengül";
musteri1.TcNo = "12345678910";

Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.Ad = "Demet";
musteri2.Soyad = "Demir";
musteri2.TcNo = "12345678910";

//musterileri listelemek için müsteri listesi oluştur
Musteri[] musteriler =  new Musteri[] { musteri1, musteri2 };

//musteri kontrol işlemleri yaptır
MusteriManager musteriManager = new MusteriManager();

musteriManager.Listele(musteriler);
Console.WriteLine("");
musteriManager.Add(musteri1);
Console.WriteLine("");
musteriManager.Delete(musteri2);
Console.WriteLine("");
musteriManager.Update(musteri1);

Console.ReadLine();