using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class MusteriManager
    { 
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi"+musteri.Ad);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi" + musteri.Ad);
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Musteri Güncellendi" + musteri.Ad);

        }
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Musteriler listelendi");
            Console.WriteLine("");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }
        }
    }
}
