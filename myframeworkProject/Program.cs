using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cl2=webdriver_framework.newclass;
using cl1=webdriver_framework;

namespace myframeworkProject
{
    public class Program
    {
        public static void Main(string[] args)
        {

            cl1.Class1 c = new cl1.Class1();
            c.webdriver_test();

            cl2.Class2 c2 = new cl2.Class2();
            c2.new_class();

            cl1.Class3 c3 = new cl1.Class3();
            c3.sample_class3();


        }
    }
}
