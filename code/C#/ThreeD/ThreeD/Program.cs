using System;

class threeDim
{
   private int x, y, z;
    public threeDim() { x = y = z = 0; }
    public threeDim(int i, int j, int k) { x = i; y = j; z = k; }

    public static threeDim operator +(threeDim ob1, threeDim ob2)
    {
        threeDim result = new threeDim();
        result.x = ob1.x + ob2.x;
        result.y = ob1.y + ob2.y;
        result.z = ob1.z + ob2.z;
        return result;
    }
   public static threeDim operator -(threeDim ob1, threeDim ob2)
    {
        threeDim result = new threeDim();
        result.x = ob1.x - ob2.x;
        result.y = ob1.y - ob2.y;
        result.z = ob1.z - ob2.z;
        return result;
    }


    public void show()
{
 Console.WriteLine(x + "," + y +"," + z);    
}

}


    class threeD
    {

        static void Main()
        {
         
            threeDim a = new threeDim(10,20,30);
            threeDim b = new threeDim(1,2,3);
            threeDim c = new threeDim();
            c = a + b;
            Console.WriteLine("here is c:");
            c.show();
            Console.WriteLine("here is a:");
            a.show();
            Console.WriteLine("here is b:");
            b.show();

          //for subtraction

            c = a - b;
            Console.WriteLine("here is c:");
            c.show();
            Console.WriteLine("here is a:");
            a.show();
            Console.WriteLine("here is b:");
            b.show();
            Console.ReadLine();
        }





        
    }
    
 
