using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_1
{
    class Program
    {
        static List<double> RemoveNeg(List<double> l)
        {
            List<double> newList = new List<double>();
            foreach (var item in l)
            {
                if (item > 0)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
        static List<Person> RemoveMolodie(List<Person> l)
        {
            int age = l.Min((a) => a.Age);
            List<Person> newList = new List<Person>();
            foreach (var item in l)
            {
                if (item.Age != age)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
        static ArrayList FillRandomArrayList(int min, int max, int size)
        {
            Random rand = new Random();
            ArrayList ar = new ArrayList();
            for (int i = 0; i < size; i++)
            {
                ar.Add(rand.Next(min, max));
            }
            return ar;
        }
        static void RemoveSecondsArrayList(ArrayList ar)
        {
            ArrayList ar1 = new ArrayList();
            int i = 0;
            foreach (var item in ar)
            {
                if (i % 2 != 0)
                {
                    ar1.Add(item);
                }
                i++;
            }
            foreach (var item in ar1)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //List<double> l = new List<double>() { 1, 2, 3, 4, 5, -6, 7, 8 };
            //List<double> l1 = new List<double>(l);
            //foreach (var item in l)
            //{
            //    l1.Add(item / 2);
            //}
            //l1.Add(Convert.ToDouble(Console.ReadLine()));
            //l1 = RemoveNeg(l1);
            //Console.WriteLine(l1.LastIndexOf(l1.Last()) + 1);
            //foreach (var item in l1)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> lp = new List<Person>()
            //{
            //    new Person("AAA", "AAA", 3),
            //    new Person("BBB", "BBB", 2),
            //    new Person("CCC", "CCC", 10)
            //};
            //lp.Add(new Person(Console.ReadLine(), Console.ReadLine(), 7));
            //lp = RemoveMolodie(lp);
            //foreach (var item in lp)
            //{
            //    Console.WriteLine(item);
            //}

            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());

            ArrayList ar = FillRandomArrayList(min, max, 10);
            for (int i = 0; i < 5; i++)
            {
                ar.Add(Console.ReadLine());
            }
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            RemoveSecondsArrayList(ar);


        }
    }
}
