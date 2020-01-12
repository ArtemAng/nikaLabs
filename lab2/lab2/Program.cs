using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        public static void Task1()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            if (value > 0)
            {
                Console.WriteLine(value+1);
            }
            else
            {
                Console.WriteLine(value);
            }
        }

        public static void Task2()
        {
            string genre = Console.ReadLine();
            switch (genre.ToLower())
            {
                case "horror":
                    Console.WriteLine("HorrorBook");
                    Console.WriteLine("HorrorBook");
                    Console.WriteLine("HorrorBook");
                    Console.WriteLine("HorrorBook");
                    Console.WriteLine("HorrorBook");
                    break;
                case "adventure":
                    Console.WriteLine("AdventureBook");
                    Console.WriteLine("AdventureBook");
                    Console.WriteLine("AdventureBook");
                    Console.WriteLine("AdventureBook");
                    Console.WriteLine("AdventureBook");
                    break;
                case "detective":
                    Console.WriteLine("Detective");
                    Console.WriteLine("Detective");
                    Console.WriteLine("Detective");
                    Console.WriteLine("Detective");
                    Console.WriteLine("Detective");
                    break;
                case "science":
                    Console.WriteLine("ScienceBook");
                    Console.WriteLine("ScienceBook");
                    Console.WriteLine("ScienceBook");
                    Console.WriteLine("ScienceBook");
                    Console.WriteLine("ScienceBook");
                    break;
                case "Roman":
                    Console.WriteLine("RomanBook");
                    Console.WriteLine("RomanBook");
                    Console.WriteLine("RomanBook");
                    Console.WriteLine("RomanBook");
                    Console.WriteLine("RomanBook");
                    break;
                default:
                    Console.WriteLine($"Нет такой книги =(");
                    break;
            }
        }
        public static void Task3()
        {
            Console.WriteLine("С богом");

            Console.WriteLine("Введите f(x):\n sh(x) - 1\n x^2 - 2\n y^2 - 3");
            int func = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            double res;
            switch (func)
            {
                case 1:
                    if (x * y > 0)
                    {
                        res =Math.Pow(Math.Sinh(x) + y, 2) - Math.Pow(Math.Abs(Math.Sinh(x)), 1 / 3);
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
        
        public static double Task4()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double R = Convert.ToDouble(Console.ReadLine());
            if (x < -2 && x >= -3)
                return -x-2;

            if (x<-1 && x>=-2)
                return Math.Sqrt(R * R + x * x);

            if (x > -1 && x<=0)
                return 1;

            if (x > 0 && x <= 1)
                return -1;

            if (x > 1 && x <= 2)
                return 2 * x - 3;

            if (x > 2 && x <= 5)
                return 1;
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("N1");
            Task1();
            Console.WriteLine("N2");
            Task2();
            Console.WriteLine("N3");
            Task3();
            Console.WriteLine("N4");
            Console.WriteLine(Task4());
        }   
    }
}
