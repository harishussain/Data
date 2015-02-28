using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add(2);
            mylist.Add(1);
            mylist.Remove(2);
            foreach (int i in mylist)
            {
                Console.Write(i);
                Console.ReadLine();
            }

        }
    }
}
