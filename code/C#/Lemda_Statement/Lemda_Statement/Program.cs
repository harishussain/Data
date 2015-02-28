using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lemda_Statement
{
    delegate int Factorial(int value);

    class Program
    {
        static void Main(string[] args)
        {
            Factorial fact= n =>
            {
                int r = 1;
                for (int i = 1; i <=n; i++)
                    r= r*i;
                return r;


            };
             
            int j=fact(3);
            Console.WriteLine("The factorial of 3 is: "+j);
            j = fact(4);
            Console.WriteLine("The factorial of 4 is: "+j);
            Console.ReadLine();
        }
    }
}
