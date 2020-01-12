using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    abstract class Transport
    {
        double Price;
        double Speed;
        double Range;

        public double price { get { return Price; } }
        public double speed { get { return Speed; } }
        public double range { get { return Range; } }
        public Transport(double Price, double Speed, double Range)
        {
            this.Price = Price; 
            this.Speed = Speed; 
            this.Range = Range; 
        }
        public double GetPrice()
        {
            return Price * Range;
        }
        public double GetTime()
        {
            return Range / Speed;
        }
        abstract public void ShowInfo();
        
    }
}
