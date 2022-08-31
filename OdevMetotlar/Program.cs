using OdevMetotlar;

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.MusteriAdi = "Engin";
musteri1.TcNo = "1111111111";
musteri1.DogumYili = "11.12.2012";

musteri1.Id = 2;
musteri1.MusteriAdi = "Ali";
musteri1.TcNo = "222222222";
musteri1.DogumYili = "10.11.2011";

musteri1.Id = 3;
musteri1.MusteriAdi = "Mehmet";
musteri1.TcNo = "3333333333";
musteri1.DogumYili = "09.11.2010";


MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1);
musteriManager.Listeleme(musteri1);
musteriManager.Delete(musteri1);


