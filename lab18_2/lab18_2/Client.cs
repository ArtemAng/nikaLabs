using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18_2
{
    class Client
    {
        string name;
        string route;
        string date;
        int bilety;
        public Client(string name, string route, string date, int bilety)
        {
            this.name = name;
            this.route = route;
            this.date = date;
            this.bilety = bilety;
        }

        public string Name { get => name; set => name = value; }
        public string Route { get => route; set => route = value; }
        public string Date { get => date; set => date = value; }
        public int Bilety { get => bilety; set => bilety = value; }

        public void Pay()
        {
            bilety++;
        }
    }
}
