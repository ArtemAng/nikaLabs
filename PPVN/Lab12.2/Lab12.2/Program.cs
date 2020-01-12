using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._2
{
    abstract class Food
    {
        string name;
        int weight;
        int callories;
        int kollichestvoSoli;
        int kollichestvoSahara;

        public Food(string name, int weight, int callories, int kollichestvoSoli, int kollichestvoSahara)
        {
            this.name = name;
            this.weight = weight;
            this.callories = callories;
            this.kollichestvoSoli = kollichestvoSoli;
            this.kollichestvoSahara = kollichestvoSahara;
        }
        public Food(int callories, int kollichestvoSoli, int kollichestvoSahara)
        {
            this.callories = callories;
            this.kollichestvoSoli = kollichestvoSoli;
            this.kollichestvoSahara = kollichestvoSahara;
        }
        public Food(string name, int weight, int kollichestvoSahara)
        {
            this.name = name;
            this.weight = weight;
            this.kollichestvoSahara = kollichestvoSahara;
        }

        public string Name { get => name; set => name = value; }
        public int Weight
        {
            get => weight; set
            {
                if (value < 0)
                {
                    throw new Exception("Negative weight");
                }
                weight = value;
            }
        }
        public int Callories
        {
            get => callories; set
            {
                if (value < 0)
                {
                    throw new Exception("Negative callories");
                }
                callories = value;
            }
        }
        public int KollichestvoSoli
        {
            get => kollichestvoSoli; set
            {
                if (value < 0)
                {
                    throw new Exception("Negative sol");
                }
                kollichestvoSoli = value;
            }
        }
        public int KollichestvoSahara
        {
            get => kollichestvoSahara; set
            {
                if (value < 0)
                {
                    throw new Exception("Negative sahar");
                }
                kollichestvoSahara = value;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name + " " + Weight + " " + callories + " " + KollichestvoSoli + " " + kollichestvoSahara);
        }
        public static Food InputInfo()
        {
            string name = Console.ReadLine();
            int weight = Convert.ToInt32(Console.ReadLine());
            int callories = Convert.ToInt32(Console.ReadLine());
            int kollichestvoSoli = Convert.ToInt32(Console.ReadLine());
            int kollichestvoSahara = Convert.ToInt32(Console.ReadLine());
            return new Food(name, weight, callories, kollichestvoSoli, kollichestvoSahara);
        }

        public Food[] SortByName(Food[] arr)
        {
            Array.Sort(arr, (a, b) => a.Name.CompareTo(b.Name));
            return arr;
        }
        public Food[] SortByCallories(Food[] arr)
        {
            Array.Sort(arr, (a, b) => a.Callories.CompareTo(b.Callories));
            return arr;
        }
        public Food[] SortByWeight(Food[] arr)
        {
            Array.Sort(arr, (a, b) => a.Weight.CompareTo(b.Weight));
            return arr;
        }
        public Food[] SortBySol(Food[] arr)
        {
            Array.Sort(arr, (a, b) => a.KollichestvoSoli.CompareTo(b.KollichestvoSoli));
            return arr;
        }
        public Food[] SortBySahar(Food[] arr)
        {
            Array.Sort(arr, (a, b) => a.KollichestvoSahara.CompareTo(b.KollichestvoSahara));
            return arr;
        }

        public static void PrintArr(Food[] arr)
        {
            foreach (var item in arr)
            {
                item.ShowInfo();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
