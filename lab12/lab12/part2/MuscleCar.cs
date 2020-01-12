using lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    class MuscleCar : Car
    {
        int hourses;
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };

        public MuscleCar(double price, double speed, double probeg, string mark, int doors, int bakVolum, int hourses) : base(price, speed, probeg, mark, doors, bakVolum)
        {
            BookDidMount?.Invoke("Он родился");
            this.hourses = hourses;
        }

        public override double NewProbeg(int range)
        {
            return range;
        }

        public int Maslo(int range)
        {
            return range / 2000;
        }
    }
}
