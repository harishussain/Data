using System;


namespace logicaloading
{
    class twoDim
    {
        int x, y;
        public twoDim() { x = y = 0; }
        public twoDim(int i, int j) { x = i; y = j; }



        public static bool operator !(twoDim ob)
        {
            if ((ob.x != 0) || (ob.y != 0))
                return false;
            else
                return true;
        }

        public void show_res()
        {
            Console.WriteLine(x + "," + y);

        }

        class res2D
        {
            static void Main()
            {
                twoDim a = new twoDim(0, 0);
               // twoDim b = new twoDim(4, 6);

                Console.WriteLine("a is"); a.show_res();
                
               // Console.WriteLine("b is");
                //b.show_res();
                if (!a)
                    Console.WriteLine("a is false");
                else
                Console.WriteLine("a is true"); 
                Console.Read();


            }
        }
    }
}