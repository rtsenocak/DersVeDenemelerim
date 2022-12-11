internal class Program
{
    private static void Main(string[] args)
    {

        //array - dizi

        string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı",
            "programlamaya başlangıç için temel kurs", "java", "phyton","C#" };


        for (int i = 0; i < kurslar.Length; i++) 
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("for bitti");

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("sayfa sonu - footer");
    }
}