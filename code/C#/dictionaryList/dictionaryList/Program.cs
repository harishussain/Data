// Example 11-8.cs
// ListDictionary collection
using System;
using System.Collections;
using System.Collections.Specialized;
public class LDClass
{
    public static void Main(string[] args)
    {
        // Create an empty ListDictionary object:
        ListDictionary myLD = new ListDictionary();
        string ob1 = Console.ReadLine();
        // Initialize the ListDictionary collection:
        myLD.Add("foundation","baseMent");
        ////myLD.Add("Learn Pascal in Three Days", "$19.95");
        ////myLD.Add("Learn C in Three Days", "$19.95");
        ////myLD.Add("Learn J#", "$35.95");
        ////myLD.Add("Learn C#", "$39.95");
        //// Display the contents:
        DisplayIt(myLD);
    }
    public static void DisplayIt(ListDictionary myLD)
    
        string s = "\t\t\t\t";
        Console.WriteLine("Book{0}Price\n", s);
        foreach (DictionaryEntry book in myLD)
            Console.WriteLine("{0,-32}{1}", book.Key,myLD.);
        Console.ReadLine();
    }

}