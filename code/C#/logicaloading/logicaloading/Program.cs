using System;


namespace logicaloading
{
    class twoDim
    {
        int x, y;
        public twoDim() { x = y = 0; }
        public twoDim(int i, int j) { x = i; y = j; }



        public static bool operator |(twoDim ob1, twoDim ob2)
        {
            if ((ob1.x != 0) || (ob1.y != 0) | (ob2.x != 0) || (ob2.y != 0))
                return true;
            else
                return false;
        }

        public void show_res()
        {
            Console.WriteLine(x + "x: " + y + "y: ");
        }

    }

    class res2D
    {
       static void Main()
        {
            twoDim a = new twoDim(3, 4);
            twoDim b = new twoDim(4, 0);
            a.show_res();
            Console.WriteLine("a is"+a);
            b.show_res();
            Console.WriteLine("b is"+b);
            if (a | b)
                Console.WriteLine("a or b is true");
            else
            { Console.WriteLine("a or b is false"); }
            Console.Read();


        }
    }
}