using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (x < 0)
            //{
            //    throw new Exception("x < 0");
            //}
            //double top = 50 * x + Math.Sqrt(x);
            //double bot = Math.Sqrt(x * x - 8 * x - 33);
            //if (bot == 0)
            //{
            //    throw new Exception("denum is num");
            //}
            //Console.WriteLine(top / bot);

            //top = Math.Log(196 - x * x);
            //bot = Math.Abs(12 - x);
            //if (bot == 0)
            //{
            //    throw new Exception("denum is num");
            //}
            //Console.WriteLine(top / bot);

            Student[] s =
                {
                Student.Add(),
            };

            foreach (var item in s)
            {
                item.ShowInfo();
            }
            Console.WriteLine(s[0].GetStepuha());

        }
    }
}
