using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baseinvocation
{
    class InheritTest:test
    {
       public InheritTest(string name):base(ModifyChild(name))
        {
            _name = name;
        }

       private static string ModifyChild(string name)
       {
         name =name.ToUpper();
         return name;

           
       } 

    }
}
 