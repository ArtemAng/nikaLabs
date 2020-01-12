using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Counter
    {
        int min;
        int max;
        int state;
        public int State { get { return state; } }
        public Counter(int min, int max)
        {
            this.min = min;
            this.max = max;
            this.state = min;
        }
        public void Inc()
        {
            if(state+1>max)
                Console.WriteLine("error");
            else state++;
        }
        public void Dec()
        {
            if (state - 1 < min)
                Console.WriteLine("error");
            else state--;
        }
    }
}
