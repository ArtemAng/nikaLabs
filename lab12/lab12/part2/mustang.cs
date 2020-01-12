using lab12.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.part2
{
    [Serializable]
    internal class Mustang : MuscleCar, IShowInfo, IAdd, IShort, IPolezniy
    {
        string color;
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };

        public Mustang(double price, double speed, double probeg, string mark, int doors, int bakVolum, int hourses, string color) : base(price, speed, probeg, mark, doors, bakVolum, hourses)
        {
            BookDidMount?.Invoke("Он родился");
            this.color = color;
        }

        public void Add()
        {
            color = Console.ReadLine();
        }

        public void GnatPod200()
        {
            Console.WriteLine("Your speed 200");
        }

        public void Polezniy1()
        {
            Console.WriteLine("Polezno");
        }

        public void Polezniy2()
        {
            Console.WriteLine("sho");
        }

        public void Polezniy3()
        {
            Console.WriteLine("Kapec");
        }

        public void Show()
        {
            Console.WriteLine(color);
        }

        public Mustang[] Soort(Mustang[] Arr)
        {
            Array.Sort(Arr, (a, b) => a.color.CompareTo(b.color));
            return Arr;
        }
    }
}
