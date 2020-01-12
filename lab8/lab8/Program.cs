using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static (int, double, double) Insert()
        {
            Console.WriteLine("Введите f(x):\n sh(x) - 1\n x^2 - 2\n y^2 - 3");
            int func = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            return (func, x, y);
        }
        public static void Task3()
        {
            Console.WriteLine("С богом");

            (int func, double x, double y) = Insert();
            double res;
            switch (func)
            {
                case 1:
                    if (x * y > 0)
                    {
                        res = Math.Pow(Math.Sinh(x) + y, 2) - Math.Pow(Math.Abs(Math.Sinh(x)), 1 / 3);
                        Console.WriteLine(res);
                    }
                    if (x * y < 0)
                    {
                        res = Math.Pow(Math.Sinh(x) + y, 2) + Math.Sin(x);
                        Console.WriteLine(res);
                    }
                    if (x * y == 0)
                    {
                        res = Math.Pow(Math.Sinh(x) + y, 2) - Math.Pow(y, 3);
                        Console.WriteLine(res);
                    }
                    break;
                case 2:
                    if (x * y > 0)
                    {
                        res = Math.Pow(Math.Pow(x, 2) + y, 2) - Math.Pow(Math.Abs(Math.Sinh(x)), 1 / 3);
                        Console.WriteLine(res);
                    }
                    if (x * y < 0)
                    {
                        res = Math.Pow(Math.Pow(x, 2) + y, 2) + Math.Sin(x);
                        Console.WriteLine(res);
                    }
                    if (x * y == 0)
                    {
                        res = Math.Pow(Math.Pow(x, 2) + y, 2) - Math.Pow(y, 3);
                        Console.WriteLine(res);
                    }
                    break;
                case 3:
                    if (x * y > 0)
                    {
                        res = Math.Pow(Math.Pow(Math.E, x) + y, 2) - Math.Pow(Math.Abs(Math.Sinh(x)), 1 / 3);
                        Console.WriteLine(res);
                    }
                    if (x * y < 0)
                    {
                        res = Math.Pow(Math.Pow(Math.E, x) + y, 2) + Math.Sin(x);
                        Console.WriteLine(res);
                    }
                    if (x * y == 0)
                    {
                        res = Math.Pow(Math.Pow(Math.E, x) + y, 2) - Math.Pow(y, 3);
                        Console.WriteLine(res);
                    }
                    break;
                default:
                    Console.WriteLine("=(");
                    break;
            }

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

        static int[] GetArr(int n)
        {
            int[] l = new int[n];
            int x;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine()); ;
                l[i] = x;
            }
            return l;
        }
        public static int Task6()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] l = GetArr(n);

            int q;
            int count = 1;
            for (int i = 1; i < l.Length - 1; i++)
            {
                q = l[i + 1] / l[i];
                if (l[i + 1] == l[i] * q && l[i - 1] * q == l[i])
                    count++;
            }
            return count;
        }
        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static int[] DeleteNotEvenId(int[] A)
        {
            int[] arr = new int[A.Length / 2 + 1];
            for (int i = 0, j = 0; i < A.Length; i += 2)
            {

                arr[j] = A[i];
                j++;

            }
            return arr;
        }
        static int Signx(double x)
        {
            if (x < 0)
                return -1;
            if (x == 0)
                return 0;
            return 1;
        }
        static bool isPrime(double x)
        {
            for (int i = 1; i < x; i++)
            {
                if (x%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        static int MasIsPrime(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (isPrime(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }
        static int fucktoreal(int a)
        {
            int tmp = 1;
            for (int i = 1; i <= a; i++)
            {
                tmp *= i;
            }
            return tmp;
        }
        static double RecursiveSum(double x, int n, double res, int i)
        {   
            if (n == 0)
                return res;
            res += Math.Pow(-1, i) * i * i * (i + 1) / fucktoreal(i);
            n--;
            i++;
            return RecursiveSum(x, n, res, i);
        }
        static string ToString(int[] x)
        {
            string res = "";
            for (int i = 0; i < x.Length; i++)
            {
                res += x[i];
            }
            return res;
        }
        static string FindMinMax(int [] x)
        {
            int max = x.Max();
            string strMass =ToString(x);
            string res = "";
            for (int i = 0; i < x.Length; i++)
            {

                if (x[i] != max)
                    strMass =strMass.Replace(x[i].ToString(), " ");

            }
            string[] arr = strMass.Split(' ');
            res = arr.Min();
            
            return res;
        }
        static void Main(string[] args)
        {
            for (int i = 1000; i < 25000; i+=100)
            {
            Console.Beep(i, 100);

            }
            double A = 0.1;
            double B = 0;
            Console.WriteLine(Signx(A)+Signx(B));
            int[] arr = { 6, 6, 6, 6, 5, 6,6,5,6 };
            Console.WriteLine(RecursiveSum(1,5,0,1));
            Console.WriteLine(FindMinMax(arr));
            Console.WriteLine("йцукенгшщзхъ");


        }
    }
}
