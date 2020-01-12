using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_2
{
    class Program
    {
        static int findRoute(List<Casher> c, string route)
        {
            int i = 0;
            foreach (var item in c)
            {
                if (item.Route == route)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        static Dictionary<int, Student> Remove(Dictionary<int, Student> ls)
        {
            int i = 100;
            Dictionary<int, Student> newLs = new Dictionary<int, Student>();
            foreach (var item in ls)
            {
                if (item.Value.Name[0] != 'A')
                {
                    newLs.Add(i++, item.Value);
                }
            }
            return newLs;
        }
        static void Main(string[] args)
        {
            //Queue<Client> clients = new Queue<Client>();
            //clients.Enqueue(new Client("aaa", "AAA", "AAA", 0));
            //clients.Enqueue(new Client("bbb", "BBB", "BBB", 0));
            //clients.Enqueue(new Client("CCC", "CCC", "CCC", 0));
            //clients.Enqueue(new Client("DDD", "DDD", "DDD", 0));
            //clients.Enqueue(new Client("FFF", "FFF", "FFF", 0));
            //clients.Enqueue(new Client("GGG", "GGG", "GGG", 0));
            //List<Casher> cashers = new List<Casher>()
            //{
            //    new Casher("AAA", 1),
            //    new Casher("BBB", 1),
            //    new Casher("CCC", 1),
            //    new Casher("DDD", 1),
            //    new Casher("FFF", 1),
            //    new Casher("GGG", 1)
            //};

            //Console.WriteLine(clients.Count);
            //Client temp;
            //while (clients.Count>0)
            //{
            //    temp = clients.Dequeue();
            //    cashers[findRoute(cashers, temp.Route)].Bilety--;
            //}
            //foreach (var item in cashers)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student("AAA", 4) },
                {2, new Student("BBB", 4)},
                {3, new Student("BBB", 4)},
                {4, new Student("AAA", 4)},
                {5, new Student("CCC", 4)},
                {6, new Student("AAA", 4)},
                {7, new Student("DDD", 4)},
                {9, new Student("AAA", 4)},
            };
            Console.WriteLine();
            students = Remove(students);
            foreach (var item in students)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
