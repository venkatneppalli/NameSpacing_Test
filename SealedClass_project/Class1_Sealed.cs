using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_project
{
    sealed class Class1_Sealed : Class2
    {

        public void test_sealed_class()
        {
            Console.WriteLine("this is sealed class");
        }
    }
}
