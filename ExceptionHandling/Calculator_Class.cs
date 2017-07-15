using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculator_Class
    {

        public void Div(int x,int y)
        {

            try
            {

                int result = x / y;
                Console.WriteLine("Division of two numbers:= " + result);

                int[] arr = { 1,2,3};

                for(int i=0;i<=arr.Length;i++)
                {

                    Console.WriteLine("Print array values:= "+arr[i]);
                }

            }

            catch(DivideByZeroException d)
            {

                Console.WriteLine(d.Message);

            }
            catch(IndexOutOfRangeException a)
            {

                Console.WriteLine(a.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

            
            

        }//method name


    }//class name

}//namespace
