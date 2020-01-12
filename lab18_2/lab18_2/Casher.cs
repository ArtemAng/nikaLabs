using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_2
{
    class Casher
    {
        string route;
        int bilety;

        public Casher(string route, int bilety)
        {
            this.route = route;
            this.bilety = bilety;
        }

        public override string ToString()
        {
            return route + " " + bilety;
        }

        public string Route { get => route; set => route = value; }
        public int Bilety
        {
            get => bilety; set
            {
                if (value < 0)
                    throw new Exception();
                else
                bilety = value;
            }

        }
    }
}
