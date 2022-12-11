using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.urunAdi = "Elma";
        urun1.fiyati = 15;
        urun1.aciklama = "Amasya Elması";


        Urun urun2 = new Urun();
        urun2.urunAdi = "Karpuz";
        urun2.fiyati = 80;
        urun2.aciklama = "Diyarbakır Karpuzu";

        Urun[] urunler = new Urun[] {urun1, urun2 };

        //tip güvenli- type-safe
        
        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.urunAdi);
            Console.WriteLine(urun.fiyati);
            Console.WriteLine(urun.aciklama);
            Console.WriteLine("------------------------");

        }

        Console.WriteLine("------------------------METOTLAR----------------------------");

        //instance - örnek
        //encapsulation

        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("Armut","Yeşil Armut", 12,10);
        sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
        sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);



    }
}


//dont rpeat yourself=kendini tekrar etme