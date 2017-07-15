using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideConcept2
{
    class Program
    {
       public static void Main(string[] args)
        {
            /*
            BasePhone bp = new BasePhone();
            bp.brand = "Nokia";
            bp.model = "6611";
            bp.PowerOff();
            bp.PowerOn();
            bp.printPhoneInfo();
            

            ISmartPhone sp = new ISmartPhone();
            sp.PowerOff();
            sp.PowerOn();
            sp.FrontCamMP = 8;
            sp.brand = "Lenovo";
            sp.model = "a6000 pluse";
            sp.printPhoneInfo();
            */

            iMobile alldevices1 = new BasePhone();
            iMobile alldevices2 = new ISmartPhone();
            iMobile alldevices3 = new LaptopClass();

            List<iMobile> list = new List<iMobile>();
            list.Add(alldevices1);
            list.Add(alldevices2);


            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }
    }
}
