using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Exp

{
    delegate int Incr(int val);
    delegate bool IsEven(int val);
   
     
    class LembdaExpDemo
    {
        static void Main(string[] args)
        {
            Incr incr = count => count + 2;
            int x = 10;
            while (x != 20)
            {
                x = incr(x);
                Console.WriteLine(x);
                Console.ReadLine();
            }
            IsEven isEven = n => n % 2 == 0;
            for (int i = 10; i < 22; i++)
            {
                  if(isEven(i))
                   Console.WriteLine(i);
               Console.ReadLine();
            }


        }
    }
}
