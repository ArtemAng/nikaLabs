using lab13.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Piramide : IParams, ISumNum, IShowInfo
    {
        int rebroNijA;
        int rebroNijB;
        int rebroNijC;
        int rebroVerhA;
        int rebroVerhC;
        int rebroVerhD;
        int hVerhOsn;
        int hNijOsn;
        int h;

        public Piramide(int rebroNijA, int rebroNijB, int rebroNijC, int rebroVerhA, int rebroVerhC, int rebroVerhD, int hVerhOsn, int hNijOsn, int h)
        {
            this.rebroNijA = rebroNijA;
            this.rebroNijB = rebroNijB;
            this.rebroNijC = rebroNijC;
            this.rebroVerhA = rebroVerhA;
            this.rebroVerhC = rebroVerhC;
            this.rebroVerhD = rebroVerhD;
            this.hVerhOsn = hVerhOsn;
            this.hNijOsn = hNijOsn;
            this.h = h;
        }

        public int RebroNijA { get => rebroNijA; set => rebroNijA = value; }
        public int RebroNijB { get => rebroNijB; set => rebroNijB = value; }
        public int RebroNijC { get => rebroNijC; set => rebroNijC = value; }
        public int RebroVerhA { get => rebroVerhA; set => rebroVerhA = value; }
        public int RebroVerhC { get => rebroVerhC; set => rebroVerhC = value; }
        public int RebroVerhD { get => rebroVerhD; set => rebroVerhD = value; }
        public int HVerhOsn { get => hVerhOsn; set => hVerhOsn = value; }
        public int HNijOsn { get => hNijOsn; set => hNijOsn = value; }
        public int H { get => h; set => h = value; }

        public int PerimetrOsn(int rebroA, int rebroB, int rebroC)
        {
            return rebroA + rebroB + rebroC;
        }

        public void ShowInfo()
        {
            Console.WriteLine(RebroNijA + " " + rebroNijB + " " + RebroNijC + " " + RebroVerhA + " " + RebroVerhC + " " + rebroVerhD + " " + HNijOsn + " " + H);
        }

        public double Square(int hOsn,int rebro)
        {
            return 1 / 2.0 * hOsn * rebro;
        }

        public int SumNum(int num)
        {
            int sum = 0;
            for (;  num!=0; num/=10)
            {
                sum += num % 10;
            }
            return sum;
        }

        public double Volume()
        {
            return 1 / 3.0 * h * (Square(hNijOsn, rebroNijA) + Math.Sqrt(Square(hNijOsn, rebroNijA) * Square(hVerhOsn, rebroVerhA)) + Square(hVerhOsn, rebroVerhA));
        }
    }
}
