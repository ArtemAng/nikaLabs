using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{

    class Program
    {
        static int[] FillArr()
        {
            Console.WriteLine("Введите оценки");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите курс");
            return arr;
        }
        static void Main(string[] args)
        {
            Student[] s = new Student[2];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Введите имя");
                s[i] = new Student(Console.ReadLine(), FillArr(), Convert.ToInt32(Console.ReadLine()));
            }
            Array.Sort(s, (a, b) => a.group.CompareTo(b.group));
            foreach (var item in s)
            {
                if (item.Reduce() > 4)
                {
                    item.ShowInfo();
                }
            }

        }
    }
}
