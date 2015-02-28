using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Collections;

namespace Dictionsorting
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, string> dictionlist = new Dictionary<string,string>();
            dictionlist.Add("05", "five");
            dictionlist.Add("03", "three");
            dictionlist.Add("01", "one");
            dictionlist.Add("2","two");
            dictionlist.Add("4","four");

            List<KeyValuePair<string, string>> sortList = dictionlist.ToList();
          
            var getter = from entry in sortList
                         orderby entry.Value ascending
                         select entry;
            Console.WriteLine(getter);
            Console.ReadLine();
                         


         
        }
    }
}
