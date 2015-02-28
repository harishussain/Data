using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            do
            {

                Console.WriteLine("enter the number b/w 2 and 20");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 1 && number < 21)
                {
           
                    while (count < 11)
                    {
                        int total;
                        total = number * count;
                        Console.WriteLine(number + "*" + count + "=" + total);
                        count++;
                     }
                   
                }
                Console.WriteLine("you enter a number that is out of range");
            }
            while(true);

        }
    }
}
               
           
                
              
                

 


