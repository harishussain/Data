using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace excprac
{
    class usefinally
    {

        public static void getexp(int num)
        {
            int[] arr = new int[2];
            int a;
            Console.WriteLine("passed number" + num);
            try
            {

                switch (num)
                {
                    case 0:
                        a = 10 / num;
                        break;
                    case 1:
                        arr[4] = 3;
                        break;
                    case 2:
                        return;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("denometer found zero");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally it should be execute after each catch");
            }
       


        }
          
    }
    public class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0;i < 3; i++)
            {
                usefinally.getexp(i);
                

            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

