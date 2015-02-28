using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jagged
{
    class Program
    {
        static void Main()
        {
            int[][] jagged = new int[1][];
            jagged[0] = new int[4];
        
            int i;
       
            // Display values in first array.
            for (i = 0; i < 4; i++)
                jagged[0][i]=i;
                Console.Write(jagged[0][i] + " ");
            Console.WriteLine();
            Console.Read();
      
                
        }
       
    }

}