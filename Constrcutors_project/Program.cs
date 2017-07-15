using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constrcutors_project
{
    class Program
    {


        public Program()
        {
            Console.WriteLine("this is public constrctor");           

        }

        

        private Program(int i)
        {

            Console.WriteLine("this is private constrctor:= "+i);
        }

        protected Program(string str)
        {
            Console.WriteLine("this is protected constrctor:= "+str);
        }

        internal Program(int x,string str)
        {
            
            Console.WriteLine("this is internal constrctor {0} {1}",x,str);
        }

        public static void Main(string[] args)
        {

            Program p1 = new Program();
            Program p2 = new Program(10);
            Program p3 = new Program("name");
            Program p4 = new Program(20,"test");

            Console.ReadKey();
        }
    }
}
