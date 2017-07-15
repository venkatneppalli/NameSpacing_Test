using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
      public static void Main(string[] args)
        {
           
            Calculator_Class c = new Calculator_Class();
            //c.Div(10,0);


            Class1 c2 = new Class1();
           // c2.throw_test();
            c2.test_stackflow();

            Console.ReadKey();
                
        }
    }
}
