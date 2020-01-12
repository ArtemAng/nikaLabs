using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    class Program
    {
        static int[] sortArrayEven(int[] arr)
        {
            int count = 0;
            List<int> evens = new List<int>();
            List<int> notEvens = new List<int>();
            foreach (var i in arr)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else notEvens.Add(i);
            }
            evens.Sort();
            notEvens.Sort((a, b) => b - a);
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i>evens.LastIndexOf(evens.Last()))
                {
                    arr[i] = notEvens[j];
                    j++;
                }
                else
                arr[i] = evens[i];
            }
            return arr;
        }
        static int[] sortArrayNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= -1;
            }
            Array.Sort(arr);
            
            return arr;
        }
        delegate bool Div(int a, int b);
        delegate double Mat(double a);

        static void Interval(Mat m1, Mat m2)
        {
            for (double i = -10; i < 11; i+=0.2)
            {
                Console.WriteLine(m1(i) + " " + m2(i));
            }
        }
        static void Main(string[] args)
        {
            //int[] arr = { 1, 6, 2, 3, 5, 7, 12, 4 };
            //int key = Convert.ToInt32(Console.ReadLine());
            //switch (key)
            //{
            //    case 1:
            //        arr=sortArrayNegative(arr); break;
            //    case 2:
            //        arr=sortArrayEven(arr); break;
            //    default:
            //        Console.WriteLine("Go out!"); break;
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int a1 = Convert.ToInt32(Console.ReadLine());
            //int b1 = Convert.ToInt32(Console.ReadLine());

            //Div d = (a, b) => a % b == 0;

            //Console.WriteLine(d(a1, b1) + " " + d(a1, 3) + " " + d(b1, 3));

            //Interval(Math.Cos, Math.Sin);

            Book book = new Book(5);
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    book.Add(Convert.ToInt32(Console.ReadLine())); break;
                case 2:
                    book.Del(Convert.ToInt32(Console.ReadLine())); break;
                default:
                    Console.WriteLine("Go out!"); break;
            }
        }
    }
}
