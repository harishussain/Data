using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace stringVsString
{
    class Program
    {
        static void GetPath()
        {
            string tracker = Assembly.GetExecutingAssembly().Location;
            Console.WriteLine(Path.GetDirectoryName(tracker));
        }

        static void Main(string[] args)
        {
            GetPath();
            Console.WriteLine(typeof(string));
            Console.WriteLine(typeof(String));
            string name = "Demis";
            String name1 = "hassibas";
            Console.WriteLine(name);
            Console.WriteLine(name1);
            Console.WriteLine(string.Concat(name,name1));
            Console.WriteLine(String.Concat(name,name1));
            Console.ReadLine();
        }
    }
}


