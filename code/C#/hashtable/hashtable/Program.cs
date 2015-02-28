using System;
using System.Collections;
public class MyClass
{
public static void Main()
{
// Creates a Hashtable object:
Hashtable AreaCodeHash = new Hashtable();
// Initializes the Hashtable.
AreaCodeHash.Add("201", "New Jersey");
AreaCodeHash.Add("337", "Louisiana");
AreaCodeHash.Add("425", "Washington");
AreaCodeHash.Add("415", "California");
AreaCodeHash.Add("503", "Oregon");
AreaCodeHash.Add("489", "Texas");
//AreaCodeHash.Clear();
// Displays the contents of the Hashtable.
//DisplayIt(AreaCodeHash);
// Display the number of elements:
Console.WriteLine("Number of elements: {0}", AreaCodeHash.Count);
}
public static void DisplayIt(Hashtable AreaCodeHash)
{
    Console.WriteLine("Area Code\tState");
    foreach (string k in AreaCodeHash.Keys)
        Console.WriteLine("{0, -16}{1}",k,AreaCodeHash[k]);
    Console.ReadLine();
}
}