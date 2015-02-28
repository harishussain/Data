using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 3;
                int[] numi = new int[] {2,4,5,6,8,14,16,18};
                int[] deno = new int[] { 1, 0, 4, 3, 0, 1 };
            for (int i = 0; i < numi.Length ; i++)
            {
                try
                {
                    try
                    {
                        t = numi[i] / deno[i];
                        Console.WriteLine(t);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("cannot divide to zero!!");
                    }
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index out of bound!!");
                }
                finally
                {
                    Console.WriteLine("Index out of bound");
                }
                Console.ReadLine();
            }
        }
    }
}

