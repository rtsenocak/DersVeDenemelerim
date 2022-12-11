using BankaOdevDeneme;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Adi = "Recep Tayyip";
        musteri1.Soyadi = "Şenocak";
        musteri1.Id = 115;
        musteri1.Yası = 26;

        Musteri musteri2 = new Musteri();
        musteri2.Adi = "Elon";
        musteri2.Soyadi = "Musk";
        musteri2.Id = 1616;
        musteri2.Yası = 32;
        
        
        Console.WriteLine(musteri1.Adi+ " " +musteri1.Soyadi);

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);


    }








}