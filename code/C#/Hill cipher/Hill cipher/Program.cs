using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Hill_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] parr = new int[2,1] { {1},{2}};
            int[,] key = new int[2, 2] { {2,3}, {3,2} };
            int[,] result = new int[2,2];
            for (int i = 0; i < 2 ; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    result[i, j] = (key[i, j] * parr[i, j])+(key[i,j+1]*parr[i+1,j]);
                    Console.WriteLine("result[{0}][{1}] = ", i, j);
                    Console.WriteLine(result[i, j]);
                   // Console.ReadLine();


                }

                
            }
           
            //// for adjoint
            // int[,] temp = new int[2,2];
            // temp[0, 1] = result[0, 1];
            // result[0, 1] = result[1, 0];
            // result[1, 0] = temp[0, 1];
            // result[0, 0] = result[0, 0] * -1;
            // result[1, 1] = result[1, 1] * -1;
            // //transopse;
            // temp[1,1] = result[0,1];
            // result[0,1] = result[1,0];
            // result[1, 0] = temp[1, 1];
            // Console.WriteLine(result[0,1]);
            // Console.WriteLine(result[1, 0]);
            ////for determinant;
            // int a = (result[0, 0] * result[1, 1]) - (result[0, 1] * result[1, 1]);
            // result[2,2] = (result[2,2] )/a;
            // int[,] plain = new int[2,2];
            // plain[2, 2] = key[2, 2] * result[2, 2];
            // Console.WriteLine(plain[0, 0]);
            // Console.WriteLine(plain[0, 1]);
            // Console.WriteLine(plain[1, 0]);
            // Console.WriteLine(plain[1, 1]);
             Console.ReadLine();

 
                    
                }
                
            }



        }
    

