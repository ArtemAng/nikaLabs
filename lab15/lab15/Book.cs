using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    class BookEventArgs : EventArgs
    {
        public BookEventArgs()
        {
            Console.WriteLine("I did mount");
        }
    }
    class Book
    {
        int sheets;
        public delegate void BookDel(string mes);
        public event BookDel BookDidMount = (message) => { Console.WriteLine(message); };
        public Book(int sheets)
        {
            BookDidMount?.Invoke("Он родился");
            BookEventArgs b = new BookEventArgs();
            this.sheets = sheets;
        }

        public void Add(int s)
        {
            sheets += s;
        }
        public void Del(int s)
        {
            if (sheets-s<0)
            {
                throw new Exception("Sheets<0");
            }
            sheets -= s;
        }
        public int Sheets { get => sheets; set => sheets = value; }
    }
}
