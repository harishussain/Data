using System;
class program{
static void Main()
{
lion ob = new lion();
Ianimal obj1 = (Ianimal)ob;
Ianimal1 obj2 = (Ianimal1)ob;
obj1.sound();
obj2.sound();
obj1.listen();
   
Console.ReadLine();
}
}
public interface Ianimal
{
void sound();
void listen();
}
interface Ianimal1
{
void sound();
}
public class lion : Ianimal, Ianimal1
{
void Ianimal.sound()
{
Console.WriteLine("lion roars");
}
void Ianimal1.sound()
{
Console.WriteLine("lion roars loudly");
}
void Ianimal.listen()
{
    Console.WriteLine("all the animal listening the roar");
}
}

