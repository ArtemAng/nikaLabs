using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        class BinaryNum
        {
            string num;

            public BinaryNum(int num)
            {
                this.num = Convert.ToString(num, 2);
            }

            public string Num { get => num; set => num = value; }

            public static BinaryNum operator +(BinaryNum n1, BinaryNum n2)
            {
                int a1 = Convert.ToInt32(n1.Num, 2);
                int a2 = Convert.ToInt32(n2.Num, 2);
                return new BinaryNum(a1 + a2);

            }
            public static BinaryNum operator -(BinaryNum n1, BinaryNum n2)
            {
                int a1 = Convert.ToInt32(n1.Num, 2);
                int a2 = Convert.ToInt32(n2.Num, 2);
                return new BinaryNum(a1 - a2);

            }

            public static BinaryNum operator *(BinaryNum n1, BinaryNum n2)
            {
                int a1 = Convert.ToInt32(n1.Num, 2);
                int a2 = Convert.ToInt32(n2.Num, 2);
                return new BinaryNum(a1 * a2);

            }
            public static BinaryNum operator /(BinaryNum n1, BinaryNum n2)
            {
                int a1 = Convert.ToInt32(n1.Num, 2);
                int a2 = Convert.ToInt32(n2.Num, 2);
                return new BinaryNum(a1 + a2);

            }



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1");
            BinaryNum n1 = new BinaryNum(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input number 2");
            BinaryNum n2 = new BinaryNum(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(n1.Num + " + " + n2.Num + " = " + (n1 + n2).Num);
            Console.WriteLine(n1.Num + " - " + n2.Num + " = " + (n1 - n2).Num);
            Console.WriteLine(n1.Num + " * " + n2.Num + " = " + (n1 * n2).Num);
            Console.WriteLine(n1.Num + " / " + n2.Num + " = " + (n1 / n2).Num);
        }
    }
}
