using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexers1
{
    class demo<T>
    {
        private T[] arr= new T[100];
        public T this[int i]
        {
            get
        {
            return arr[i];
        }
            set
        {
            arr[i]= value;
        }
        }
       
    }
    class Program
    {
       
        static void Main()
        {
            int i = 0;
            demo<string> stringCollection = new demo<string>();

            stringCollection[0] = "hello world";
            stringCollection[1] = "hello heaven";
           Console.WriteLine(stringCollection[i]);
             i++;
           Console.WriteLine(stringCollection[i]);
           Console.Read();
        }

    }
    
}
