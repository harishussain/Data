using System;

class Program
{
    public class fish
    {
        public virtual void eat()
        { Console.WriteLine("fish can eat"); }
        public virtual void swim()
        { Console.WriteLine("fish can swim"); }
        public virtual void dive()
        { Console.WriteLine("fish can dive"); }

    }
    public  class Dolphin : fish
    {
       public abstract void eat(){Console.WriteLine("ff");
      }
    public class Shark : fish
    {
        public override void eat()
        { Console.WriteLine("Shark eats dead animal"); }
        public override void swim()
        { Console.WriteLine("Sharks swim fastest than Dolphin"); }
        public override void dive()
        { Console.WriteLine("Sharks Dive deeper than Dolphin"); }

        public void kill()
        { Console.WriteLine("Shark kills Others"); }

    }

    static void Main(string[] args)
    {
        fish f = new fish();
        f.eat();
        f.swim();
        f.dive();
        //Dolphin D = new Dolphin();
       
      Shark S = new Shark();
       S.kill();
        S.dive();
        S.eat();
       S.swim();
        Console.ReadLine();
    }
}
