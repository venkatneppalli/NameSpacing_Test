using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractKeyword_project
{
   public abstract class Class1
    {

        //Class1 c = new Class1();
        //Compilation error message cannot create instance of abstract class


        public void test1()
        {
            Console.WriteLine("this is test1 in abstract class");
        }

        public static void test2()
        {
            Console.WriteLine("this is test2 in abstract class");
        }

    }
}
