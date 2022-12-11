internal class Program
{
    private static void Main(string[] args)
    {

        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.55;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış Oku");
        }

        else if (dolarDun<dolarBugun)
        {
            Console.WriteLine("Artış Oku");
        }

        else
        {
            Console.WriteLine("Değişmedi Butonu");
        }

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullancıcı Ayarları Butonu");
        }

        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }
    }
}