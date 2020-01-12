using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        public static void Task1()
        {
            string s = Console.ReadLine();
            //Console.WriteLine(Regex.Matches(s, @"[0-9]").Count);
            int count = 0;
            foreach (var item in s)
                if (Convert.ToInt32(item) > 47 && 58 > Convert.ToInt32(item))
                    count++;
            Console.WriteLine(count);
        }
        public static void Task2()
        {
            string s = Console.ReadLine();
            //Console.WriteLine(Regex.Matches(s, @"abc").Count);
            
            int count = 0;
            for(var i = 0; i< s.Length-2; i++)
                if (s[i]=='a' && s[i+1]=='b'&&s[i+2]=='c')
                    count++;
            Console.WriteLine(count);
        }
        public static void Task3()
        {
            string str = Console.ReadLine();
            string[] strs = str.Split(' ');
            string s = strs[0];
            foreach (var i in strs)
                if (i.Length > s.Length)
                    s = i;
            s = s.Replace('a', 'b');
            Console.WriteLine(s);

        }

        
        public static void Task4()
        {
            string str = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());
            string[] words = str.Split(' ');
            char[] temparr;
            for (int i = 0; i < words.Length; i++)
                if (k < words[i].Length)
                {
                    temparr = words[i].ToCharArray();
                    temparr[k] = c;
                    words[i] = new String(temparr);
                }
            string res = "";
            foreach (var item in words)
            {
                res += item + " ";
            }

            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.WriteLine(Convert.ToChar(97));
        }
    }
}
