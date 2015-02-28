using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conditinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a-b;
            if (c == 0)
            {
                Console.WriteLine("numbers are equal");
            }
            else
            
                if (c > 0)
                {
                    Console.WriteLine("a is greater than b");
                }
       
                else
                    if (c < 0)
                    {
                        Console.WriteLine("b is greater than a");
                    }
            for (int count = 0; count < 5; count++)
            {
                Console.WriteLine("this count:"+ count);              
            }
            Console.WriteLine("counts completed");
            Console.Read();
            
        }
    }
}
