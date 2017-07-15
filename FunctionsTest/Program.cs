using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTest
{
    class Program : SecondClass
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.non_staticFunc();
            p.newnon_static_Func();
                       
            staticFunc();
            newstatic_Func();

            Console.WriteLine(p.str1);
            Console.WriteLine(str2);

            Console.ReadKey();

        }


        public void non_staticFunc()
        {
            Console.WriteLine("This is non static function");
        }

        public static void staticFunc()
        {

            Console.WriteLine("This is static function");

        }

        

    }
}
