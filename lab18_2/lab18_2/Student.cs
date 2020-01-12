using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_2
{
    class Student
    {
        string name;
        int mark;

        public Student(string name, int mark)
        {
            this.name = name;
            this.mark = mark;
        }

        public override string ToString()
        {
            return name + " " + mark;
        }

        public string Name { get => name; set => name = value; }
        public int Mark { get => mark; set => mark = value; }
    }
}
