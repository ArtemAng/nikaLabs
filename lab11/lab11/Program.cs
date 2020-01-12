using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        static Car[] SortMark(Car[] c)
        {
            Array.Sort(c, (a, b) => a.mark.CompareTo(b.mark));
            return c;
        }
        static Car[] SortBak(Car[] c)
        {
            Array.Sort(c, (a, b) => a.bakVolum.CompareTo(b.bakVolum));
            return c;
        }
        static Car[] SortDoors(Car[] c)
        {
            Array.Sort(c, (a, b) => a.doors.CompareTo(b.doors));
            return c;
        }
        static Car[] SortProbeg(Car[] c)
        {
            Array.Sort(c, (a, b) => a.probeg.CompareTo(b.probeg));
            return c;
        }
        static Car[] SortSpeed(Car[] c)
        {
            Array.Sort(c, (a, b) => a.speed.CompareTo(b.speed));
            return c;
        }
        static void Main(string[] args)
        {
            Counter c1 = new Counter(3, 6);
            c1.Inc();
            Console.WriteLine(c1.State);

            Car[] c = new Car[3];
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Car" + i);

                c[i] = new Car();
                c[i].InputInfo();
            }
            c = SortMark(c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Car" + i);
                //Console.WriteLine(c[i].Fuel(100,2));
                //Console.WriteLine(c[i].BakVolume(200));
                //Console.WriteLine(c[i].Time(100));
                //Console.WriteLine(c[i].NewProbeg(122));
                //Console.WriteLine(c[i].Maslo(100));
                //Console.WriteLine(c[i].Omivaika(100,2));
                c[i].ShowInfo();
            }
            c = SortProbeg(c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Car" + i);
                //Console.WriteLine(c[i].Fuel(100,2));
                //Console.WriteLine(c[i].BakVolume(200));
                //Console.WriteLine(c[i].Time(100));
                //Console.WriteLine(c[i].NewProbeg(122));
                //Console.WriteLine(c[i].Maslo(100));
                //Console.WriteLine(c[i].Omivaika(100,2));
                c[i].ShowInfo();
            }

            c = SortSpeed(c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Car" + i);
                //Console.WriteLine(c[i].Fuel(100,2));
                //Console.WriteLine(c[i].BakVolume(200));
                //Console.WriteLine(c[i].Time(100));
                //Console.WriteLine(c[i].NewProbeg(122));
                //Console.WriteLine(c[i].Maslo(100));
                //Console.WriteLine(c[i].Omivaika(100,2));
                c[i].ShowInfo();
            }
            c = SortDoors(c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Car" + i);
                //Console.WriteLine(c[i].Fuel(100,2));
                //Console.WriteLine(c[i].BakVolume(200));
                //Console.WriteLine(c[i].Time(100));
                //Console.WriteLine(c[i].NewProbeg(122));
                //Console.WriteLine(c[i].Maslo(100));
                //Console.WriteLine(c[i].Omivaika(100,2));
                c[i].ShowInfo();
            }
            c = SortBak(c);
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine("Car" + i);
                //Console.WriteLine(c[i].Fuel(100,2));
                //Console.WriteLine(c[i].BakVolume(200));
                //Console.WriteLine(c[i].Time(100));
                //Console.WriteLine(c[i].NewProbeg(122));
                //Console.WriteLine(c[i].Maslo(100));
                //Console.WriteLine(c[i].Omivaika(100,2));
                c[i].ShowInfo();
            }
        }
    }
}




/*
 
     */
