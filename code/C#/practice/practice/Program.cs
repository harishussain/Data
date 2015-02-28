using System;
namespace practice
{
    class connect
    {
        public static void Main()
        {
            human a = new human();
            man b = new man();
            woman c = new woman();

            //a.eat();
            c.eat();
            b.eat();
            b.fight();
            c.talk();
            Console.ReadLine();

        }
    }

    public class human
    {
        public virtual void eat()
        {
            Console.WriteLine("all the humans eats");
        }

    }
    class man : human
    {
        public override void eat()
        {
           Console.WriteLine("all the man eats");

        }
        public void fight()
        {
            Console.WriteLine("man can fight by action");
        }
    }
    class woman : human
    {
        public override void eat()
        {
            Console.WriteLine("all the women eats");
        }

        public void talk()
        {
            Console.WriteLine("women talks by action");

        }
    }

}
    
        