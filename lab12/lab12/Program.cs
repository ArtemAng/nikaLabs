using lab11;
using lab12.interfaces;
using lab12.part2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            //    SportCar a = new SportCar(1, 2, 2, "1", 2, 1, 1);
            //    Console.WriteLine(a.BakVolume(1));
            //    Console.WriteLine(a.Fuel(1, 1));
            //    Console.WriteLine(a.Maslo(1));
            //    Console.WriteLine(a.Omivaika(1, 2));
            //    Console.WriteLine(a.Time(2));
            //    a.printVoditel();
            //    MuscleCar m = new MuscleCar(1, 1, 1, "232", 2, 1, 1);
            //    Console.WriteLine(m.Maslo(1));
            //    Vnedorojnik v = new Vnedorojnik(1, 1, 1, "11", 1, 1, 1, "juju");
            //    Console.WriteLine(v.jujuj());
            //    Console.WriteLine(v.Maslo(1));
            //    Ferarri f = new Ferarri(1, 1, 1, "11", 1, 1, 1, 1);
            //    f.EstPeperoni();
            //    Lamborginy l = new Lamborginy(1, 1, 1, "111", 1, 1, 1, 's');
            //    l.GnatPoDoroge();
            //    Shevrolet s = new Shevrolet(1, 1, 1, " asd", 1, 1, 1, false);
            //    s.Lomatsya();
            //    Hummer h = new Hummer(1, 1, 1, "111", 1, 1, 1, "sad", 1);
            //1//////////////////////////////////////
            //Mustang[] ms =
            //{
            //    new Mustang(7, 7, 7, "7", 7, 7, 7, "7"),
            //    new Mustang(6, 6, 6, "6", 6, 6, 6, "6")
            //};
            //Mustang m1 = new Mustang(0, 0, 0, "", 0, 0, 0, "0");
            //ms = m1.Soort(ms);

            //foreach (var item in ms)
            //{
            //    item.Show();
            //}

            //m1.Add();
            //m1.Show();
            //m1.Polezniy1();
            //m1.Polezniy2();
            //m1.Polezniy3();
            // 2///////////////////////////////////////
            SportCar a = new SportCar(1, 2, 2, "1", 2, 1, 1);
            MuscleCar m = new MuscleCar(1, 1, 1, "232", 2, 1, 1);
            Vnedorojnik v = new Vnedorojnik(1, 1, 1, "11", 1, 1, 1, "juju");
            Ferarri f = new Ferarri(1, 1, 1, "11", 1, 1, 1, 1);
            Lamborginy l = new Lamborginy(1, 1, 1, "111", 1, 1, 1, 's');
            Shevrolet s = new Shevrolet(1, 1, 1, " asd", 1, 1, 1, false);
            Hummer h = new Hummer(1, 1, 1, "111", 1, 1, 1, "sad", 1);

            SoapFormatter soapformatter = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("cars.soap", FileMode.OpenOrCreate))
            {
                soapformatter.Serialize(fs, a);
                soapformatter.Serialize(fs, m);
                soapformatter.Serialize(fs, f);
                soapformatter.Serialize(fs, l);
                soapformatter.Serialize(fs, s);
                soapformatter.Serialize(fs, h);
                soapformatter.Serialize(fs, v);
                Console.WriteLine("Объект сериализован");
            }

            //XmlSerializer xmlformatter = new XmlSerializer(typeof(Lamborginy));
            //using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            //{
            //    xmlformatter.Serialize(fs, l);
            //    Console.WriteLine("Объект сериализован");
            //}

            BinaryFormatter Binformatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                Binformatter.Serialize(fs, l);
                Binformatter.Serialize(fs, m);
                Binformatter.Serialize(fs, f);
                Binformatter.Serialize(fs, l);
                Binformatter.Serialize(fs, h);
                Binformatter.Serialize(fs, h);
                Binformatter.Serialize(fs, v);

                Console.WriteLine("Объект сериализован");
            }

        }
    }
}
