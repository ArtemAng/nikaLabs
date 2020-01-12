using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._2
{
    class HomeFood: Food
    {
        int kollichestvoProductov;

        public HomeFood(string name, int weight, int callories, int kollichestvoSoli, int kollichestvoSahara, int kollichestvoProductov) : base(name, weight, callories, kollichestvoSoli, kollichestvoSahara)
        {
            this.kollichestvoProductov = kollichestvoProductov;
        }

        public int GetKolichestvo()
        {
            return kollichestvoProductov;
        }

        public int KollichestvoProductov { get => kollichestvoProductov; set => kollichestvoProductov = value; }
    }
}
