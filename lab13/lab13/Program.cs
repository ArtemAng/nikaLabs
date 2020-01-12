using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите нижнее ребро А: ");
            int rebroNijA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижнее ребро B: ");
            int rebroNijB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижнее ребро C: ");
            int rebroNijC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнее ребро A: ");
            int rebroVerhA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнее ребро B: ");
            int rebroVerhB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнее ребро C: ");
            int rebroVerhC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту ерхнего основания: ");
            int hVerhOsn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижнего ерхнего основания: ");
            int hNijOsn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Piramide p = new Piramide(rebroNijA, rebroNijB, rebroNijC, rebroVerhA, rebroVerhB, rebroVerhC, hVerhOsn, hNijOsn, h);
            Console.WriteLine("Square: " + p.Square(p.HNijOsn, p.RebroNijA) + p.Square(hVerhOsn, rebroVerhA));
            Console.WriteLine("Volume: " + p.Volume());
            p.ShowInfo();
        }
    }
}
