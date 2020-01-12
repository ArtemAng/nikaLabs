using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Povozka : Transport
    {
        int hourses;
        public Povozka(double price, double speed, double range, int hourses) : base(price, speed, range)
        {
            this.hourses = hourses;
        }
        override public void ShowInfo()
        {
            Console.WriteLine(price + " " + speed + " " +range +" "+ hourses );
        }
    }
}
