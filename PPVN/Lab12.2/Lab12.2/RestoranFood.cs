using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._2
{
    class RestoranFood : Food
    {
        double price;
        double chaevie;

        public RestoranFood(string name, int weight, int callories, int kollichestvoSoli, int kollichestvoSahara, double price, double chaevie) : base(name, weight, callories, kollichestvoSoli, kollichestvoSahara)
        {
            this.price = price;
            this.chaevie = chaevie;
        }

        public double Chaevie { get => chaevie; set => chaevie = value; }
        public double Price { get => price; set => price = value; }

        public double RaschetCeni()
        {
            return price * Weight+ chaevie;
        }

    }
}
