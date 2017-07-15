using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword_project
{
   public class Class1
    {

        public int i = 10;


        public Class1()
        {
            Console.WriteLine("Class1");
        }

        
        public void this_variables()
        {
            int i = 20;

            Console.WriteLine("Print i value:= "+this.i);
        }

        public void this_method(int i)
        {

            i = 40;
           this.i = i;

            Console.WriteLine("Print i value method:= "+i);

        }

    }
}
