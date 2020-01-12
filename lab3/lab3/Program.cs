using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    class Program
    {
        public static void Task1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 0; Math.Pow(5, i) <= n; i++)
            {
                sum += Math.Pow(5, i);
            }
            Console.WriteLine(sum);
        }
        public static void Task2()
        {
            double x0 = 0.8;
            double xN = 2;
            double dx = 0.1;
            double a = 1.5;
            double res;
            for (double i = 0, xi = x0; xi < xN; i++, xi= x0 + i*dx)
            {
                if (xi < 1.3)
                {
                    res = Math.PI * xi * xi - 7 / xi * xi;
                    Console.Write(res + " 1 ветка");
                }
                if (xi == 1.3)
                {
                    res = a * xi * xi * xi + 7 * Math.Sqrt(xi);
                    Console.Write(res + " 2 ветка");
                }
                if (xi > 1.3)
                {
                    res = Math.Log(xi + 7 * Math.Sqrt(xi));
                    Console.Write(res + " 3 ветка");
                }
                Console.WriteLine();
            }

        }
        public static int nod (int a, int b)
        {
            int temp;
            while (b!=0)
            {
                temp = b;
                b = a % b;
                a = temp;

            }
            return a;
        }
        public static int nok(int a, int b)
        {
            return a * b / nod(a, b);
        }
        public static int sumOfNum(int n)
        {
            int sum = 0;
            while (n!=0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        public static void Task4()
        {
            int count = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 100; i < 1000; i++)
            {
                if (sumOfNum(i) == n)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(count);
        }

        public static void Task5()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    sum += Math.Pow(Math.Sin(x - 18), 2) / Fucktoreal(i-j);
                }
            }

            Console.WriteLine(sum);
        }

        private static double Fucktoreal(int v)
        {
            int res = 1;
            for (int i = 1; i <= v; i++)
            {
                res *= i;
            }
            return res;
        }

        public static void Task6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int [] l = new int [n];
            int x;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine()); ;
                l[i] = x;                
            }
            int q;
            int count = 1;
            for (int i = 1; i < l.Length-1; i++)
            {
                q = l[i+1] / l[i];
                if (l[i + 1] == l[i] * q && l[i-1]*q==l[i])
                    count++;
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(nok(5, 6));
            //Task1();
            //Task2();
            nok(3,5);
            //Task4();
            //Task5();
            Task6();
        }
    }
}
