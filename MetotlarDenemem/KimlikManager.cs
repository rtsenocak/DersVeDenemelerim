using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarDenemem
{
    internal class KimlikManager
    {
        public void Ekle(Kimlik kimlik) 
        {
            Console.WriteLine("Tebrikler! Türk Vatandaşı Olduğunuz Doğrulandı : " + kimlik.Adi);
        }
    }
}
