using lab12.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    [Serializable]
    public abstract class Car: Interface1
    {
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };
        string mark;
        protected int doors;
        protected double price;
        protected double speed;
        protected double probeg;
        protected int bakVolum;
        public double Price { get { return price; } }
        public Car(double price, double speed, double probeg, string mark, int doors, int bakVolum)
        {
            BookDidMount?.Invoke("Он родился");
            this.mark = mark;
            this.price = price;
            this.probeg = probeg;
            this.speed = speed;
            this.doors = doors;
            this.bakVolum = bakVolum;
        }
        public Car(double price, string mark, int doors)
        {
            BookDidMount?.Invoke("Он родился");

            this.mark = mark;
            this.price = price;
            this.probeg = 0;
            this.speed = 0;
            this.doors = doors;
        }
        public Car()
        {
            BookDidMount?.Invoke("Он родился");

            this.mark = "";
            this.price = 0;
            this.probeg = 0;
            this.speed = 0;
            this.doors = 0;
        }
        public Car(double price)
        {
            BookDidMount?.Invoke("Он родился");

            this.mark = "";
            this.price = price;
            this.probeg = 0;
            this.speed = 0;
            this.doors = 0;
        }
        delegate void Mes(string message);
        public void InputInfo()
        {
            this.mark = Console.ReadLine();
            this.price = Convert.ToDouble(Console.ReadLine());
            this.probeg = Convert.ToDouble(Console.ReadLine());
            this.speed = Convert.ToDouble(Console.ReadLine());
            this.doors = Convert.ToInt32(Console.ReadLine());
            this.bakVolum = Convert.ToInt32(Console.ReadLine());
        }
        public double Time(int range)
        {
            return range / speed * 60;
        }
        public double Fuel(int range, int fuel)
        {
            return range / fuel;
        }
        public abstract double NewProbeg(int range);
        virtual public int Maslo(int range)
        {
            return range / 3000;
        }
        public int BakVolume(int range)
        {
            if (bakVolum==0)
            {
                return 0;
            }
            return range / bakVolum;
        }
        public int Omivaika(int range, int omivayka)
        {
            return range / omivayka;
        }


        public void ShowInfo()
        {
            Console.WriteLine(price + " " + speed + " " + probeg + " " + mark + " " + doors + " " + bakVolum + " " + price);
        }
    }
}
