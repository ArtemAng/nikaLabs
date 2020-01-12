using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    struct Student
    {
        public string name;
        public int [] marks;
        public int group;
        public Student(string name, int [] marks, int group)
        {
            this.name = name;
            this.marks = marks;
            this.group = group;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: "+name+" Group"+group+" \nMarks:");
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }
        }
        public double Reduce()
        {
            int sum = 0;
            foreach (var item in marks)
            {
                sum += item;
            }
            return sum / marks.Length;
        }
    }
}
