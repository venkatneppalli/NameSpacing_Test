using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword_project
{
    class Program
    {

        /*
        
 The this keyword refers to the current instance of the class and is also 
 used as a modifier of the first parameter of an extension method
         
        */

       public static void Main(string[] args)
        {
            //Class2 c = new Class2();
            //c.this_variables();
            //c.this_method(30);
            //c.test_method2();
            //c.test2_class2();

            Class3 c3 = new Class3();
            Console.WriteLine(c3);
            c3.test_Class3();

            Console.ReadKey();
        }
    }
}
