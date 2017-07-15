using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test
{
    class Program
    {
       public static void Main(string[] args)
        {

            BasePhone b = new BasePhone();
            b.brandname = "Nokia";
            b.model = "3395";
            b.PowerOff();
            b.PowerOn();
            b.PrintPhoneInfo();


            ISmartPhone s = new ISmartPhone();

            //s.smartphone_brandname = "Lenovo";
            //s.smartphone_model = "a6000 pluse";

            s.brandname = "Lenovo";
            s.model = "a6000 pluse";
            s.FrontCamMP =8;
            s.PowerOff();
            s.PowerOn();
            s.PrintPhoneInfo();
            


            Console.ReadKey();
        }
        
    }
}
