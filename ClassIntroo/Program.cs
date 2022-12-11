internal class Program
{
    private static void Main(string[] args)
    {

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demirog";
        kurs1.IzlenmeOranı = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "JAVA";
        kurs2.Egitmen = "Recep Tayyip Senocak";
        kurs2.IzlenmeOranı =  8;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "PHYTON";
        kurs3.Egitmen = "Muhammed";
        kurs3.IzlenmeOranı = 78;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C++";
        kurs4.Egitmen = "Ali";
        kurs4.IzlenmeOranı = 69;

        //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen + " = " + kurs.IzlenmeOranı);
        }


    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}