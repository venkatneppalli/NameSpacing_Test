using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test
{
    public class BasePhone : IMobile
    {

        public String brandname;
        public String model;

        public void PowerOff()
        {
            Console.WriteLine("PowerOff");
        }

        public void PowerOn()
        {
            Console.WriteLine("PowerOn");
        }
        

        public virtual void PrintPhoneInfo()
        {

            Console.WriteLine("Model: {0},Brand: {1}",model,brandname);
        }

    }
}
