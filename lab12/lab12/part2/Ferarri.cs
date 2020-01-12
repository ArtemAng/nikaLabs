using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    class Ferarri : SportCar
    {
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };
        int VmestimostPeperoni;
        public Ferarri(double price, double speed, double probeg, string mark, int doors, int bakVolum, int idvoditelya, int VmestimostPeperoni) : base(price, speed, probeg, mark, doors, bakVolum, idvoditelya)
        {
            BookDidMount?.Invoke("Он родился");
            this.VmestimostPeperoni = VmestimostPeperoni;
        }

        public void EstPeperoni()
        {
            Console.WriteLine("Vi sieli Peperoni");
        }
    }
}
