using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @break
{
    class Program
    {
        static void printi(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                if (i == 6)
                    break;
                printi(i);
                Console.ReadKey();


            }

        }
    }
}
