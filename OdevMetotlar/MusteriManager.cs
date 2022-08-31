using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevMetotlar
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi");

        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");

        }
    }
}
