using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    class Shevrolet : MuscleCar
    {
        bool isCool;
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };

        public Shevrolet(double price, double speed, double probeg, string mark, int doors, int bakVolum, int hourses, bool isCool) : base(price, speed, probeg, mark, doors, bakVolum, hourses)
        {
            BookDidMount?.Invoke("Он родился");
            this.isCool = isCool;
        }
        public void Lomatsya()
        {
            Console.WriteLine("Oh, this car broke again!");
        }
    }
}
