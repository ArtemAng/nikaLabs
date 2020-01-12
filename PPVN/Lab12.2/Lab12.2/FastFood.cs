using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._2
{
    class FastFood : Food
    {
        double price;

        public FastFood(string name, int weight, int callories, int kollichestvoSoli, int kollichestvoSahara, double price) : base(name, weight, callories, kollichestvoSoli, kollichestvoSahara)
        {
            this.price = price;
        }
        public double Price { get => price; set => price = value; }

        public double RaschetCeni()
        {
            return price * Weight;
        }
    }
}
