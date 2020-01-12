using lab12.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    public class Lamborginy
    {
        char class_;
        
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };
        public Lamborginy()
        {

        }
        public Lamborginy(double price, double speed, double probeg, string mark, int doors, int bakVolum, int idvoditelya, char class_)
        {
            BookDidMount?.Invoke("Он родился");
            this.class_ = class_;
        }
        public void GnatPoDoroge()
        {
            Console.WriteLine("Faster!!! Faster!!!!!");
        }
    }
}
