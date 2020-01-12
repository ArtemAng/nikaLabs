using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Car : Transport
    {
        string mark;
        int doors;
        public Car(double price, double speed, double range, string mark, int doors) : base(price, speed, range)
        {
            this.mark = mark;
            this.doors = doors;
        }
        override public void ShowInfo()
        {
            Console.WriteLine(price + " " + speed + " " + range + " " + mark + " " + doors);
        }
    }
}
