using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ass6
{
    //An interface to develop explicit interface object.
    interface IHuman
    {
        double getLength();
        double getSpeed();
    }
   
    class Box : IHuman // Box type constructor
    {
        double MeterDistance;
        double TimeSpeed;
     public Box(double Distance, double Speed)
        {
            MeterDistance = Distance;
            TimeSpeed = Speed;
      
        }
        // interface type implentation
        double IHuman.getLength()
        {
            return MeterDistance;
        }
        double IHuman.getSpeed()
        {
            return TimeSpeed;
        }

    }

    interface Human
    {
        void walk();
        void speak();

    }
        class User : Human
        {

            public void walk()
            {
                Console.WriteLine("All user can walk");
            }


            public void speak()
            {
                Console.WriteLine("All user can speak");
            }
            public void work()
            {
                Console.WriteLine("All user can work");
            }
        }
        class person : Human
        {
            public void walk()
            {
                Console.WriteLine("All person can walk");

            }
            public void speak()
            {
                Console.WriteLine("All person can speak");
            }
            public void behave()
            {
                Console.WriteLine("every person has its behavior");
            }
        }
        class program
        {

            public static void Main()
            {
                User myUser = new User();
                person NewPerson = new person();
                Human ob1 = (Human)myUser;//assiging User Type to Human Type
                Human ob2 = (Human)NewPerson;// assigning Person Type to Human Type
                Box Box1 = new Box(30.1,30.21);
                IHuman Ob = (IHuman)Box1; //the box object is assigned to interface object
                ob1.walk();
                ob1.speak();
                ob2.walk();
                ob2.speak();
                
                Console.WriteLine("Distance:" + Ob.getLength()+"meters");
                Console.WriteLine("speed:" +Ob.getSpeed()+"meters/seconds");
                Console.ReadLine();

            }
        }

    }

    

