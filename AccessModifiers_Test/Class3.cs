using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Test
{
    class Class3
    {

        protected void test_pro()
        {

            Console.WriteLine("this is protected method");
        }

        private void test_priv()
        {

            Console.WriteLine("this is private method");
        }
        
        internal void test_int()
        {

            Console.WriteLine("this is internal method");
        }

    }
}
