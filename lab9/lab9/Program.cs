using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void NumbersToFile(double a, double b, double h)
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream("Task_1.dat", FileMode.Create)))
            {
                try
                {
                    for (var i = a; i < b; i += h)
                    {
                        writer.Write(i);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            using (BinaryReader reader = new BinaryReader(new FileStream("Task_1.dat", FileMode.Open)))
            {
                double[] arr = new double[reader.BaseStream.Length];
                int i1 = 0;
                string str = "";
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    //Console.WriteLine(reader.BaseStream.Seek(i1, SeekOrigin.Begin));
                    //i1 += 2;
                    //Console.WriteLine(reader.ReadDouble());
                    str += reader.ReadDouble()+" ";
                }
                Console.WriteLine(str);
                string[] strs = str.Split(' ');
                for (int i = 1; i < strs.Length-1; i+=2)
                {
                    Console.WriteLine(strs[i]);
                }
            }
        }

        static int StrsFromFile(char c)
        {

            string str = "";
            using (StreamReader sr = new StreamReader("text1.txt"))
            {
                str = sr.ReadToEnd();
            }
            string[] strs = str.Split('\n');
            int count = 0;
            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (strs[i][0] == c)
                    count++;
            }
            return count;
        }
        static void Rewrite()
        {
            StreamReader reader1 = new StreamReader(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t1.txt");
            StreamReader reader2 = new StreamReader(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t2.txt");
            StreamWriter writer = new StreamWriter(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k2\t3.txt", true);
            writer.Write(reader1.ReadToEnd());
            writer.Write(reader2.ReadToEnd());
            reader1.Close();
            reader2.Close();
            writer.Close();
        }
        static void FileINF()
        {
            FileInfo t1 = new FileInfo(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t1.txt");
            FileInfo t2 = new FileInfo(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t2.txt");
            FileInfo t3 = new FileInfo(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k2\t3.txt");
            GetInfo(t1);
            GetInfo(t2);
            GetInfo(t3);
            File.Move(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t2.txt", @"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k2\t2.txt");
            File.Copy(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t1.txt", @"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k2\t1.txt");
        }
        static void GetInfo(FileInfo file)
        {
            Console.WriteLine("=====Информация о Файле======");
            Console.WriteLine("Полное Имя" + file.FullName);
            Console.WriteLine("Имя:" + file.Name);
            Console.WriteLine("Создано:" + file.CreationTime);
            Console.WriteLine("" + file.Attributes);
            Console.WriteLine("Дириктория Именни: " + file.DirectoryName);
            Console.WriteLine("=*****************************=");
        }
        static void DeleteDir()
        {
            Directory.Move(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k2", @"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\all");
            Directory.Delete(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1", true);
        }
        static void ShowInfo()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\all");
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo el in files)
                GetInfo(el);
        }
        static void StreamWrite()
        {
            string str1 = "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов ";
            string str2 = "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс";
            StreamWriter writer1 = new StreamWriter(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t1.txt", true);
            StreamWriter writer2 = new StreamWriter(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1\t2.txt", true);
            writer1.Write(str1);
            writer2.Write(str2);
            writer2.Close();
            writer1.Close();
        }
        static void CreatDir()
        {
            Directory.CreateDirectory(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp");
            Directory.CreateDirectory(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k1");
            Directory.CreateDirectory(@"C:\\Users\\Mi\\Desktop\\Лаба9\\temp\k2");
        }

        static void Main(string[] args)
        {
            NumbersToFile(10.3, 14, 0.7);
            Console.WriteLine(StrsFromFile('a'));

            CreatDir();
            StreamWrite();
            Rewrite();
            FileINF();
            DeleteDir();
            ShowInfo();
        }

    }
}
