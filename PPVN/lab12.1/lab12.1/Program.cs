using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12._1
{
    abstract class Shape
    {
        public abstract double GetSquare();
        public abstract double GetPerimetr();
        public abstract void ShowInfo();
        public abstract void MoveLeft(int range);
        public abstract void MoveRight(int range);
        public abstract void MoveUp(int range);
        public abstract void MoveDown(int range);
    }

    class Square : Shape
    {
        int x;
        int y;
        int length;

        public Square(int x, int y, int length)
        {
            this.x = x;
            this.y = y;
            this.length = length;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Length { get => length; set => length = value; }

        public override double GetPerimetr()
        {
            return length * 4;
        }

        public override double GetSquare()
        {
            return length * length;
        }

        public override void MoveDown(int range)
        {
            y -= range;
        }

        public override void MoveLeft(int range)
        {
            x -= range;
        }

        public override void MoveRight(int range)
        {
            x += range;
        }

        public override void MoveUp(int range)
        {
            y += range;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(X + " " + Y + " " + Length);
        }
    }
    class Circle : Shape
    {
        int x;
        int y;
        int r;

        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int R { get => r; set => r = value; }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * r;
        }

        public override double GetSquare()
        {
            return Math.PI * r * r;
        }

        public override void MoveDown(int range)
        {
            y -= range;
        }

        public override void MoveLeft(int range)
        {
            x -= range;
        }

        public override void MoveRight(int range)
        {
            x += range;
        }

        public override void MoveUp(int range)
        {
            y += range;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(X + " " + Y + " " + R);
        }
    }
    class Ellipse : Shape
    {
        int x1;
        int y1;
        int x2;
        int y2;
        int x3;
        int y3;
        int x4;
        int y4;

        int a;
        int b;

        public Ellipse(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int a, int b)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
            this.a = a;
            this.b = b;
        }

        public int X1 { get => x1; set => x1 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y2 { get => y2; set => y2 = value; }
        public int X3 { get => x3; set => x3 = value; }
        public int Y3 { get => y3; set => y3 = value; }
        public int X4 { get => x4; set => x4 = value; }
        public int Y4 { get => y4; set => y4 = value; }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * Math.Sqrt((a * a + b * b)/8);
        }

        public override double GetSquare()
        {
            return Math.PI * a * b;
        }

        public override void MoveDown(int range)
        {
            Y1 -= range;
            Y2 -= range;
            Y3 -= range;
            Y4 -= range;

        }

        public override void MoveLeft(int range)
        {
            X1 -= range;
            X2 -= range;
            X3 -= range;
            X4 -= range;
        }

        public override void MoveRight(int range)
        {
            X1 += range;
            X2 += range;
            X3 += range;
            X4 += range;
        }

        public override void MoveUp(int range)
        {
            Y1 += range;
            Y2 += range;
            Y3 += range;
            Y4 += range;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(X1 + " " + Y1 + " " + X1 + " " + Y2 + " " + X3 + " " + Y3 + " " + X4 + " " + Y4);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
