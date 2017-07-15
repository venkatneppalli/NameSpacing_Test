using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAPI_project
{
    class Program
    {
       public static void Main(string[] args)
        {

            Type t = typeof(MyConsole);
            MethodInfo[] mia = t.GetMethods();

            foreach(MethodInfo im in mia)
            {
                
                if(im.Name.Equals("my_method"))
                {
                    Console.WriteLine("Matching Method Found:= "+im.Name);
                }

                
            }

            Console.ReadKey();
        }
    }

    class MyConsole
    {

        public static void my_method(String msg)
        {
            Console.WriteLine(msg);
        }


        public static void my_method2(String msg2)
        {
            Console.WriteLine(msg2);
        }

    }
    
}
