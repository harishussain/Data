using System;

class threeDim
{
    private int x, y, z;
    public threeDim() { x = y = z = 0; }
    public threeDim(int i, int j, int k) { x = i; y = j; z = k; }

    public static  bool operator >(threeDim ob1, threeDim ob2)
    {
        threeDim result = new threeDim();
        if (Math.Sqrt(ob1.x * ob1.x + ob1.y * ob1.y + ob1.z * ob1.z) > Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.z * ob2.z))

            return true;
        else 
            return false;
    }


    public static bool operator <(threeDim ob1, threeDim ob2)
    {
        threeDim result = new threeDim();
        if (Math.Sqrt(ob1.x * ob1.x + ob1.y * ob1.y + ob1.z * ob1.z) < Math.Sqrt(ob2.x * ob2.x + ob2.y * ob2.y + ob2.z * ob2.z))

            return true;
        else
            return false;
    }
 

    public void show()
    {
        Console.WriteLine(x + "," + y + "," + z);
    }

}


class threeD
{

    static void Main()
    {

        threeDim a = new threeDim(10, 20, 30);
        threeDim b = new threeDim(5,9,26);
        threeDim c = new threeDim(11,4,1);
        threeDim d = new threeDim(10,20,30);


        Console.WriteLine("here is a:");
        a.show();
        Console.WriteLine("here is b:");
        b.show();
        Console.WriteLine("here is c:");
        c.show();
        Console.WriteLine("here is d:");
        d.show();


        //for subtraction
   if(a > c) Console.WriteLine("a > c is true");
if(a < c) Console.WriteLine("a < c is true");
if(a > b) Console.WriteLine("a > b is true");
if(a < b) Console.WriteLine("a < b is true");
if(a > d) Console.WriteLine("a > d is true");
else if(a < d) Console.WriteLine("a < d is true");
else Console.WriteLine("a and d are same distance from origin");

  
   
        Console.ReadLine();
    }






}


