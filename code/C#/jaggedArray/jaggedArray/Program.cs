using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jaggedArray
{
    class Program
    {
        static void Main()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[4];
            arr[2] = new int[5];
           for (int i = 0; i < 3; i++)
            {
                arr[0][i] = i;
                Console.Write(" " + arr[0][i]);
                Console.WriteLine();
       
            }
       
             for (int j = 0; j < 4; j++)
            {
                arr[0][j] = j;
                Console.Write(" " + arr[1][j]);
                   Console.WriteLine();
                Console.ReadLine();
        }
    }
}