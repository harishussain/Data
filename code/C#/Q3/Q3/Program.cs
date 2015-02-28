using System;



class User
{
public int add(int a, int b)
{
return a + b;
}
protected int sub(int a, int b)
{
    return a - b;
}

//friend int mul(int a, int b)     // Friend is not a defined access specifier in c#
//{return a*b; }			 // this will raise an error in program
}

//Adding reference to this library in the following class
class Program:User
{
    static void Main(string[] args)
{
User ob=new User();
Program ob1 = new Program();
int num1 = 7;
int num2 = 5;
      
Console.WriteLine(ob.add(num1, num2));
Console.WriteLine(ob1.sub(num1, num2));
Console.ReadLine();


//Since the method is declared as public,it is allowed
					       //To call
 // since sub method is declared as a protected method,it will only be accessible in class inherited from class User 
}
}