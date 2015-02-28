using System;
using System.Collections.Generic;


class Gen<T>
{
    T ob;
    public Gen(T o)
{
    ob = o;
    Console.WriteLine(ob);
    }

    public T Show()
    {
        return ob;
    }
    public void showType()
    {
        Console.WriteLine("type is: "+typeof(T));
    }
}
class program
{
    public static void Main()
    {
        Gen<string> s;
        s = new Gen<string> ("All the man has their own worth");
        s.Show();
        s.showType();
       Console.ReadLine();
    }

}
