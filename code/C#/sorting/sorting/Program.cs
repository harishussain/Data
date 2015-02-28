using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace sorting
{
    class Program
    {

        static void Main(string[] args)
        {   
            int[] input = new int[] {2,8,4,12,1,2,3,6,7,98,9,5};
            Console.WriteLine("Enter choice");
            Console.WriteLine("1 for descending sorting");
            Console.WriteLine("2 for assecending sorting");
            Console.WriteLine(" ");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            for (int j = 0; j < input.Length; j++)
                            {
                                if (input[i] < input[j])
                                {
                                    int temp;
                                    temp = input[i];
                                    input[i] = input[j];
                                    input[j] = temp;

                                }
                            }

                        }
                        int[] output = input.Distinct().ToArray();

                        foreach (int j in output)
                        {
                            Console.WriteLine(j);
                            Console.ReadLine();
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            for (int j = 0; j < input.Length; j++)
                            {
                                if (input[i] > input[j])
                                {
                                    int temp;
                                    temp = input[i];
                                    input[i] = input[j];
                                    input[j] = temp;

                                }
                            }

                        }
                        int[] output = input.Distinct().ToArray();

                        foreach (int j in output)
                        {
                            Console.WriteLine(j);
                            Console.ReadLine();
                        }
                    } break;
            }
           
            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = 0; j < input.Length; j++)

            //    {
            //        if (input[i] > input[j])
            //        {
            //            int temp;
            //            temp = input[i];
            //            input[i]=input[j];
            //            input[j] = temp;

            //        }
            //    }
                
            //}
            //int[] output = input.Distinct().ToArray();
            
            //    foreach (int j in output)
            //    {
            //        Console.WriteLine(j);
            //        Console.ReadLine();
            //    }

         



        }

    }
}
