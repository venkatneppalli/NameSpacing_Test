using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideConcept2
{
    public class BasePhone : iMobile
    {


        public BasePhone()
        {
            Console.WriteLine("BasePhone Constructor");
        }

        public String brand;
        public String model;

        public void PowerOff()
        {
            Console.WriteLine("PowerOff");
        }

        public void PowerOn()
        {
            Console.WriteLine("PowerOn");
        }

        //BaseClass Function
        public virtual void printPhoneInfo()
        {

            Console.WriteLine("model: {0}, brand:{1} ",model,brand);

        }

    }
}
