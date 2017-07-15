using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Test
{
   public class Class1
    {
        //Global Variable non-static
        private int Global_private_Class1=100;
        protected int Global_protect_Class1 = 200;

        //Non-Static method
        public void method1_class1()
        {
            Console.WriteLine("This is method1 in Class1");
        }

        public int method2_class1()
        {
            
            return Global_private_Class1;
        }

        public int method3_Class1()
        {

            return Global_protect_Class1;
        }



    }
}
