using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static string findWord(string str)
        {
            string s = Regex.Match(str, @"<b>\w+<\\b>").Value;
            Regex reg = new Regex(@"[<b>|<\\b>]");
            return reg.Replace(s, "");
        }

        static List<string> findTel(string [] str)
        {
            List<string> strings = new List<string>();
            foreach (var item in str)
            {
                strings.Add(Regex.Match(item, @"[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]").Value);
            }
            List<string> els = new List<string>();

            int i = 1;
            foreach (var item in strings)
            {
                els.Add(item);
                //if (els[i]!=item || i>els.LastIndexOf(els.Last())&& els.LastIndexOf(els.Last())<0)
                //{
                //   break;
                //}
                i++;
            }
            return els;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(findWord("<b>cat<\\b>"));
            string[] s = { "aaa 111-11-11", "bbb 222-22-22", "ggg 222-22-22", "ccc 333-33-33" };
            List<string> l = findTel(s);
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
