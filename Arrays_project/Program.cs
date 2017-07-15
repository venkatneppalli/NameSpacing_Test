using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_project
{
    class Program
    {
       public static void Main(string[] args)
        {
            Program p = new Program();
            //p.single_array1();
            //p.single_array2();
            p.foreach_test();
            Console.ReadKey();

        }

        public void single_array1()
        {
            
            int[] arr = { 1,2,3};

            for(int i=0;i<arr.Length;i++)
            {

                Console.WriteLine(arr[i]);
                
            }
        }

        public void single_array2()
        {

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            for(int i=0;i<arr.Length;i++)
            {

                Console.WriteLine(arr[i]);
            }


        }

        public void foreach_test()
        {

            string[] str = new string[3];

            str[0] = "Sai";
            str[1] = "Satish";
            str[2] = "Venkat";

            foreach(string var in str)
            {

                Console.WriteLine(var);

            }
        }
        


    }
}
