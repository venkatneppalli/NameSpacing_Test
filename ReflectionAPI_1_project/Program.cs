using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAPI_1_project
{
    class Program
    {
       public static void Main(string[] args)
        {

            Type t = typeof(Class1);

            MethodInfo[] m = t.GetMethods();

            foreach(MethodInfo im in m)
            {
                if(im.Name.Equals("test_method"))
                {
                    Console.WriteLine("Matching method found test method");
                }
            }

            Console.ReadKey();

        }
    }
}
