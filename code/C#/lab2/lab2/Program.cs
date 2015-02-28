/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TwoD
{
    public int sum=1;
    static void Main()
    {

 
 
       int[, ,] two = new int[3,3,3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int n = 1;
                 
                    two[i, j, k] = n++;
                    int sum = two[0, 0, 0] + two[1, 1, 1] + two[2, 2, 2];
                    Console.Write(sum);
                   
                }
            }

          
 
        }
        Console.WriteLine();
        Console.Read();
    }



}
   */
using System;
class ThreeDMatrix
{
    static void Main()
    
   
    {
        int[, ,] m = new int[3, 3, 3];
        int sum = 0;
        int n = 1;
        for (int x = 0; x < 3; x++)
            for (int y = 0; y < 3; y++)
                for (int z = 0; z < 3; z++)
                    m[x, y, z] = n++;
        sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
        Console.WriteLine("Sum of first diagonal: " + sum);
        Console.Read();
    }
}
    
    
    
    
    
    
    
    
   
