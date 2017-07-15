using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTest
{
    class SecondClass
    {

        public String str1 = "GlobalNewString";
        public static String str2 = "InstVarStaticString";

        public void newnon_static_Func()
        {
            String str3 = "NewLocalString";
            Console.WriteLine("This is New Non Static Function");
        }

        public static void newstatic_Func()
        {

            Console.WriteLine("This is New Static Function");
        }

    }
}
