using MetotlarDenemem;

internal class Program
{
    private static void Main(string[] args)
    {
        Kimlik kimlik1 = new Kimlik();
        kimlik1.Adi = "Recep Tayyip";
        kimlik1.Soyadi = "Şenocak";
        kimlik1.Id = 18892685472;
        kimlik1.KanGrubu = "A+";

        Kimlik kimlik2 = new Kimlik();
        kimlik2.Adi = "Bilal";
        kimlik2.Soyadi = "Batıbey";
        kimlik2.Id = 11548563522;
        kimlik2.KanGrubu = "AB-";

        Kimlik kimlik3 = new Kimlik();
        kimlik3.Adi = "Polat";
        kimlik3.Soyadi = "Alemdar";
        kimlik3.Id = 59865329874;
        kimlik3.KanGrubu = "0+";

        Kimlik[] kimlikler = new Kimlik[] {kimlik1, kimlik2, kimlik3 };

        foreach (Kimlik kimlikKart in kimlikler)
        {
            Console.WriteLine("ADI: "+kimlikKart.Adi);
            Console.WriteLine("SOYADI: "+kimlikKart.Soyadi);
            Console.WriteLine("TC KİMLİK NO: "+kimlikKart.Id);
            Console.WriteLine("KAN GRUBU: "+kimlikKart.KanGrubu);
            Console.WriteLine("-----------------Bitti---------------------");
        }

        Console.WriteLine("-----------Metotlar-------------------");

        //s
        KimlikManager kimlikManager = new KimlikManager();
        kimlikManager.Ekle(kimlik1);
        kimlikManager.Ekle(kimlik2);
        kimlikManager.Ekle(kimlik3);


    }
}