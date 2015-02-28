using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexers
{
class indexer
{
    public string[] mystring = new string[] { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
    public string this[int i]
    {
        set
        {
            mystring[i] = value;
        }
        get
        {
            return mystring[i];
        }
    }

}
    class Program
    {
        static void Main(string[] args)
        {
            indexer index = new indexer();
            for (int i = 0; i < index.mystring.Length ; i++)
            {
                Console.WriteLine("["+i+"]"+"="+index[i]);
                Console.ReadLine();
            }
            {
                
            }


            

        }
    }
}
