using lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    class Vnedorojnik : Car
    {
        int collichestvoKoles;
        string juju;
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };
        public Vnedorojnik(double price, double speed, double probeg, string mark, int doors, int bakVolum, int collichestvoKoles, string juju) : base(price, speed, probeg, mark, doors, bakVolum)
        {
            BookDidMount?.Invoke("Он родился");
            this.collichestvoKoles = collichestvoKoles;
            this.juju = juju;
        }

        public override double NewProbeg(int range)
        {
            return range;
        }
        public int CountKoles()
        {
            int c = 0;
            for (int i = 0; i < collichestvoKoles; i++)
            {
                c++;
            }
            return c;
        }
        public string jujuj()
        {
            return juju + juju;
        }

    }
}
