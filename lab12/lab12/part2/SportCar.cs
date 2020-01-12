using lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    class SportCar : Car
    {
        int idvoditelya;
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };

        public SportCar(double price, double speed, double probeg, string mark, int doors, int bakVolum, int idvoditelya) : base(price, speed, probeg, mark, doors, bakVolum)
        {
            BookDidMount?.Invoke("Он родился");
            this.idvoditelya = idvoditelya;
        }

        public override double NewProbeg(int range)
        {
            return range * 2;
        }

        public void printVoditel()
        {
            Console.WriteLine(idvoditelya);
        }
    }
}
