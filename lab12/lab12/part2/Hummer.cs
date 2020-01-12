using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    class Hummer : Vnedorojnik
    {
        int pafos;
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };
        public Hummer(double price, double speed, double probeg, string mark, int doors, int bakVolum, int collichestvoKoles, string juju, int pafos) : base(price, speed, probeg, mark, doors, bakVolum, collichestvoKoles, juju)
        {
            BookDidMount?.Invoke("Он родился");
            this.pafos = pafos;
        }
        public void DavitLudey()
        {
            Console.WriteLine("Oh no, you are killer!!!!");
        }
    }
}
