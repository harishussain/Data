using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aggregation
{
    class board
    {
        public string Name;
        public int rollno;
        public int Regno;
        public school school;
    
    
    }

    class school
    {
        public string  stname;
        public int strollno;
        public int regno;
    }


   class student 
   {
        static void Main(string[] args)
        {
            school ob1 = new school();
            ob1.stname="danish";
            ob1.strollno=4525;
           school  name1 = new school();
           name1.stname = "ahmad";
           name1.strollno = 61;
           name1.regno = 110061;
           school name2 = new school();
           name2.stname = "amjad";
           name2.strollno = 51;
           name2.regno = 110051;
      
          boaroperation myschool = new boaroperation();
          board mystd = myschool.boardret("zeeshan",name2,name2);
           Console.WriteLine(mystd.school.regno.ToString());
           Console.WriteLine();
           Console.ReadLine();
        }
        class boaroperation
        {
            public board boardret(string name, school schooltype,school schooltrace)
            {
                board newschool = new board();
                newschool.Name = name;
                newschool.school = schooltype;
                newschool.school = schooltrace;
                return newschool;
            }
        }
    }
}
