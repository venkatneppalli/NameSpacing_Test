using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword_project
{
    public class Class2 : Class1
    {

        public Class2()
        {
            
            //this.i = i;
            Console.WriteLine("Class2");

        }

         //this keyword can be passed as an argument in the method.
        public void test_class2(Class2 x)
        {
            
            Console.WriteLine("This is class2 method");
        }

        public void test_method2()
        {
            
            test_class2(this);
            Console.WriteLine("this is method2 in class2");
        }

        //The this keyword can be used to invoke current class method (implicitly).
        public void test1_class2()
        {
            
            Console.WriteLine("this is test1 class2");
        }

        public void test2_class2()
        {
            this.test1_class2();
            
            Console.WriteLine("this is test2 class2");
        }


    }
}
