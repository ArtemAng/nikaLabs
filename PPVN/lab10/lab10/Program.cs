using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    struct Note
    {
        string name;
        string phoneNumber;
        int[] birthdate;

        public Note(string name, string phoneNumber, int day, int month, int year)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.birthdate = new int[] { day, month, year };
        }

        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int[] Birthdate { get => birthdate; set => birthdate = value; }
        public static Note InputInfo()
        {
            Console.WriteLine("Input name");
            string name = Console.ReadLine();
            Console.WriteLine("Input phonenumber");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Input day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input year");
            int year = Convert.ToInt32(Console.ReadLine());
            return new Note(name, phoneNumber, day, month, year);
        }
        public static Note[] SortNote(Note[] n)
        {
            Array.Sort(n, (a, b) => a.Name.CompareTo(b.Name));
            return n;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name + " " + phoneNumber + " " + birthdate[0] + "." + birthdate[1] + "." + birthdate[2]);
        }
        public static void GetNotesWithInputMOnth(Note[]n)
        {
            Console.WriteLine("Input month");
            int m = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in n)
            {
                if (item.birthdate[1] == m)
                {
                    item.ShowInfo();
                    
                }
            }
            if (count==0)
            {
                Console.WriteLine("Not found");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Note[] a =
            {
                Note.InputInfo(),
                Note.InputInfo(),
                Note.InputInfo(),
                Note.InputInfo(),
                Note.InputInfo()
            };
            a = Note.SortNote(a);
            foreach (var item in a)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
            Note.GetNotesWithInputMOnth(a);
        }
    }
}
