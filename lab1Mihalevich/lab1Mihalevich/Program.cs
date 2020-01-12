using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Mihalevich
{
    class Program
    {
        private static void task1()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\"Ближайший к нынешним дням пласт этих легенд - пласт, предшествовавший отмиранию и суеверия и боязни тесных контактов с жуткими местами, - составляли легенды, в которых рассказывалось об отшельниках и одиноких фермерах, проживавших обособленно и в какой-то момент испытавших психический надлом, трагический по последствиям: про таких говорили, что они \"продали себя\" этим странным созданиям. В одном из северо-восточных округов в начале XIX века была даже своеобразная мода - обвинять чудаковатых и нелюдимых в пособничестве ненавистным силам или дружбе с ними.\n\n Что же касается природы этих существ - то объяснения, само собой, варьировали.Как правило, их называли \"те\", или \"бывшие\", хотя в ходу в разные периоды и в разных местностях были и другие названия.Основная масса пуритан без всяких экивоков называла их близкими друзьями дьявола и превратила в предмет оживленных теологических рассуждений.Жители, которые по наследству получили кельтские легенды, -в основном шотландского и ирландского происхождения из Нью - Хэмпшира, а также их родня, поселившаяся в Вермонте, -связывали эти существа со злыми духами и \"маленьким народцем\" болот и лесов и защищались от них заклинаниями, передаваемыми от поколения к поколению.Но, несомненно, наиболее фантастическое объяснение природы этих созданий принадлежало индейцам.Хотя разные племена отличались своими легендами, но имелось согласие в определенных, существенных чертах:		 молчаливо  предполагалось, что эти создания не являются исконными жителями ");
        }
        private static void task2()
        {
            Console.WriteLine("T2");
            int a = Convert.ToInt32(Console.ReadLine());
            double r = a / 2;
            double R = a / Math.Sqrt(2);
            Console.WriteLine("r = {0}; R = {1}", r, R);
        }

        private static void task3()
        {
            Console.WriteLine("T3");
            int M = Convert.ToInt32(Console.ReadLine());
            int res = M / 1000;
            Console.WriteLine($"Result = {res}");
        }
        private static void task4()
        {
            Console.WriteLine("T4");

            int t1 = Convert.ToInt32(Console.ReadLine());
            int v1 = Convert.ToInt32(Console.ReadLine());
            int s1 = Convert.ToInt32(Console.ReadLine());
            double v2 = s1 / t1;
            double res = v1 - v2;
            Console.WriteLine($"Result = {res}");
        }

       
        private static double Task5()
        {
            Console.WriteLine("T5");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (Math.Truncate(Math.Log(a, b)) == Math.Log(a, b) || Math.Truncate(Math.Log(a, c)) == Math.Log(a, c))
                return a;
            if (Math.Truncate(Math.Log(b, a)) == Math.Log(b, a) || Math.Truncate(Math.Log(b, c)) == Math.Log(b, c))
                return b;
            if (Math.Truncate(Math.Log(c, a)) == Math.Log(c, a) || Math.Truncate(Math.Log(c, b)) == Math.Log(c, b))
                return c;
            return 0;

        }
        private static double Task6()
        {
            Console.WriteLine("T6");

            var x = Convert.ToDouble(Console.Read());

            return Math.Pow(Math.Cos(Math.Pow(Math.E, x)) + Math.Pow(Math.Log(1+x),2) + Math.Sqrt(Math.Pow(Math.E, Math.Cos(x)) + Math.Pow(Math.Sin(Math.PI*x),2)) + Math.Sqrt(1/x) + Math.Cos(Math.Pow(x,2)), Math.Sin(x));
        }
        private static bool Task7()
        {
            Console.WriteLine("T7");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            return (8 >= x + y && 4 <= x + y) || 
                    (-8 <= x+y && -4 >= x+y) ||
                    (-4 <= x - y && 8 >= x + y)||
                    (-8 <= x - y && 4 >= x + y);
        }
        private static (double, double) Task8()
        {
            Console.WriteLine("T8");

            double b = Convert.ToDouble(Console.ReadLine());
            double z1 = Math.Sqrt(2*b + 2 * Math.Sqrt(Math.Pow(b, 2)-4)) / (Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);
            double z2 = 1 / Math.Sqrt(b+2);
            return (z1, z2);
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    Console.WriteLine(Task5());
                    break;
                case 6:
                    Console.WriteLine(Task6());
                    break;
                case 7:
                    Console.WriteLine(Task7());
                    break;
                case 8:
                    Console.WriteLine(Task8());
                    break;
                default:

                    Console.WriteLine("=(");
                    break;
                    
            }
        }
    }
}
