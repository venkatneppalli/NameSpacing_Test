using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_project
{
    class Program
    {
       public static void Main(string[] args)
        {

            Program p = new Program();
            p.for_loop();
            p.while_loop();
            p.do_loop();
            p.foreach_loop();

            Console.ReadKey();
        }

        public void for_loop()
        {

            for(int i=0;i<=10;i++)
            {
                Console.WriteLine("for loop values:= {0}",i);
            }
        }

        public void while_loop()
        {
            int i = 0;
            while(i<=10)
            {
                Console.WriteLine("while loop values:= {0} ",i);
                i++;
            }
        }

        public void do_loop()
        {
            int i = 0;
            do
            {
                Console.WriteLine("do while loop values:= {0}",i);
                i++;


            } while (i < 10);

        }

        public void foreach_loop()
        {

            int[] i = { 1,2,3};

            foreach(int element in i)
            {
                Console.WriteLine("foreach loop values:= {0}",element);
            }
        }

    }
}
