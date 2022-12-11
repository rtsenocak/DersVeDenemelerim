internal class Program
{
    private static void Main(string[] args)
    {

        Katagori katagori1 = new Katagori();
        katagori1.Katagoriismi = "Bilgisayar";
        katagori1.indirimOrani = 45;
        katagori1.yapilanAlisverisOrani = 76;


        Katagori katagori2 = new Katagori();
        katagori2.Katagoriismi = "Telefon";
        katagori2.indirimOrani = 69;
        katagori2.yapilanAlisverisOrani = 43;

        Katagori katagori3 = new Katagori();
        katagori3.Katagoriismi = "Kulaklıklar";
        katagori3.indirimOrani = 35;
        katagori3.yapilanAlisverisOrani = 41;

        Katagori katagori4 = new Katagori();
        katagori4.Katagoriismi = "Tablet";
        katagori4.indirimOrani = 71;
        katagori4.yapilanAlisverisOrani = 53;


        //Console.WriteLine(katagori1.Katagoriismi + " %" + katagori1.indirimOrani + "=" + katagori1.yapilanAlisverisOrani);

        Katagori[] katagoriler = new Katagori[] {katagori1, katagori2, katagori3, katagori4};

        foreach (var katagorik in katagoriler)
        {
            Console.WriteLine(katagorik.Katagoriismi+": %"+katagorik.indirimOrani+" İndirim = "+katagorik.yapilanAlisverisOrani+"  ADET SATILDI");
        }

    }




    class Katagori
    {
        public string Katagoriismi { get; set; }
        public int indirimOrani { get; set; }
        public int yapilanAlisverisOrani { get; set; }
    }
}

