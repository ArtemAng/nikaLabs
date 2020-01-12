using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Bike : Transport
    {
        string mark;
        string type;
        public Bike(double price, double speed, double range, string mark, string type) : base(price, speed, range)
        {
            this.mark = mark;
            this.type = type;
        }
        override public void ShowInfo()
        {
            Console.WriteLine(price + " " + speed + " " + range + " " + mark +" "+ type);
        }
    }
}
