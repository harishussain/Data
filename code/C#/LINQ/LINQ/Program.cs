using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1,-6,5,5,2,4,6 };
  
            var evennum = from n in nums
                         where n<0
                         select n;


                   
              foreach(int n in evennum)
              {
                  Console.WriteLine(n);
                  Console.ReadLine();
              }
        }
    }
}
