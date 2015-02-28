using System;

class Program
{

    static void Main(string[] args)
    {

        string str = Console.ReadLine();

        int length = str.Length;

        int index = length / 2;

        char convCh1 = Char.ToUpper(str[0]);

        char convCh2 = Char.ToUpper(str[index]);

        char[] chArray = str.ToCharArray();

        chArray[0] = convCh1;

        chArray[index] = convCh2;

        Console.WriteLine(chArray);

        Console.ReadLine();

    }

}