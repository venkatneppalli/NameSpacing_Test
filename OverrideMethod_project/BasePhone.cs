using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod_project
{
   public class BasePhone : IMobile
    {
        public BasePhone()
        {
            Console.WriteLine("This is BasePhone Constructor");
        }

        public String model;
        public String brand;
           
        //Override
        public virtual void PrintPhoneInfo()
        {
            Console.WriteLine("Model: {0}, Brand:{1}",model,brand);
        }

        public void PowerOff()
        {
            Console.WriteLine("PowerOff");
        }

        public void PowerOn()
        {
            Console.WriteLine("PowerOn");
        }
    }
}
