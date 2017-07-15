using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_test
{
    class Program : Class1
    {
       public static void Main(string[] args)
        {

            Program p = new Program();

            p.test2();
            

            Class1 c = new Class1();
            c.test2();

        }
    }
}
