using System;
// This delegate returns int and takes an int argument.
delegate int CountIt(int end);
class VarCapture
{
    static CountIt Counter()
    {
        int sum = 0;
        // Here, a summation of the count is stored
        // in the captured variable sum.
        CountIt Countfn = delegate(int add)
        {
            for (int i = 0; i < add; i++)
            {
                Console.WriteLine(i);
                sum += i;

             
            }
            return sum;
        };
        return Countfn;


    }
    static void Main()
    {
        // Get a counter.
        CountIt count = Counter();
        int result;
        result = count(3);
        Console.WriteLine("Summation of 3 is " + result);
        result = count(5);
        Console.WriteLine("Summation of 5 is" + result);
        Console.ReadLine();
    }
}