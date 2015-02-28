using System;


namespace typeoverloading
{
    class threeD
    {
        int x;
        public threeD() { x= 0; }
        public threeD(int i) { x = i; }

        public static implicit operator int(threeD obj)
        {
           return obj.x*2;

        }


        public void showit()
        {
            Console.WriteLine("X:"+x);
        }


    }   
    class Program
    {
        
  
        static void Main()
        {
            threeD a = new threeD(2);
            Console.WriteLine("value of a is:");
                a.showit();
            int i;
            i= a;
            Console.WriteLine(" value of i is:"+i);
            i =  a * 2;
            Console.WriteLine("value of i=a*2 is:"+i);
            Console.Read();


          
        }
    }
}
