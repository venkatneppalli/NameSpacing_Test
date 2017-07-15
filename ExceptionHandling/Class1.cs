using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   public class Class1
    {
        public void throw_test()
        {
            try
            {
                int i = 10;
                int j = 0;
                int z = i / j;

            }
            catch (Exception)
            {
                throw new System.Exception("CAANOT DIVIDE BY ZERO");
                
            }

           
            //throw new System.DivideByZeroException("cannot divide with zero");

            /*
            if(i!=j)
            {
                throw new System.DivideByZeroException("Parameter cannot be null");
                
            }*/
            
        }

        public void test_stackflow()
        {

            try
            {

                int i = 10;
                int j = 0;
                int z = i / j;


            }catch(Exception e)

            {
                Console.WriteLine(e.StackTrace);
            }
          
        }
    }
}
