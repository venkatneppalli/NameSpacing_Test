using newelectronics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Test
{
    class Program : Class3
    {
        private int Global_private_prog = 200;
        protected int Global_protect_prog = 300;
        internal int sku=200;

        public static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.method1_class1();
            Console.WriteLine("This is private Global variable in class1:= "+c.method2_class1());
            Console.WriteLine("This is protected Global variable in class1:= "+c.method3_Class1());



            Program p = new Program();
            Console.WriteLine("This is Global variable from Program:= "+p.Global_private_prog);
            p.method1_programe();
            Console.WriteLine("This is protect variable from Program:= "+p.Global_protect_prog);
            Console.WriteLine("Access Internal access modifer:= "+p.sku);
            //Console.WriteLine(p.test_inter);
            

            laptop l = new laptop();
            //l.test_myinter;  internal access modifer are accessible only with the same assembly
            Console.WriteLine(l.test_public);
            l.test_return_pro();
            l.test_return_interal();
            l.test_return_private();
            l.public_method_electronics();


            Program p1 = new Program();
            p1.test_pro();
            p1.test_int();
            
            Class3 c1 = new Class3();
            c1.test_int();
            

            Console.ReadKey();

        }

        private void method1_programe()
        {
            Console.WriteLine("This is method1 from Program class");
        }


    }

class test_internal : Class3
    {

        public void test()
        {

            //Console.WriteLine(this.sku);
        }

        

    }

}
