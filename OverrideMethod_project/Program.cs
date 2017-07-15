using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod_project
{
    class Program : BasePhone
    {
       public static void Main(string[] args)
        {
            /*
            BasePhone b = new BasePhone();
            b.brand = "Nokai";
            b.model = "6611";
            b.PowerOff();
            b.PowerOn();
            b.PrintPhoneInfo();
            */
            /*
            SmartPhone s = new SmartPhone();
            s.brand = "Lenovo";
            s.model = "a6000 Pluse";
            s.FrontCamMp = 8;
            s.PowerOff();
            s.PowerOn();
            s.PrintPhoneInfo();
            */

            /*
            BasePhone b1 = new SmartPhone();
            b1.brand = "Lenovo";
            b1.model = "a6000 Pluse";
            //b1.FrontCamMp = 8;
            b1.PowerOff();
            b1.PowerOn();
            b1.PrintPhoneInfo();
            */

            IMobile bp = new BasePhone();
            IMobile isp = new SmartPhone();

            List<IMobile> allRunningDevices = new List<IMobile>();
            allRunningDevices.Add(bp);
            allRunningDevices.Add(isp);

            foreach(IMobile im in allRunningDevices)
            {
                im.PowerOff();
                im.PowerOn();
            }



            Console.ReadKey();
        }

        
    }
}
