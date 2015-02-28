using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convert
{
    class Program
    {
       
        static void Main()
        {
            int a;
            Console.WriteLine("enter date");
            a= Console.Read();
            Console.WriteLine(Convert.ToDateTime(DateTime.Now));
            Console.WriteLine(a);
         
         Console.Read();
        }
          //Console.ReadLine();
    }
} 
