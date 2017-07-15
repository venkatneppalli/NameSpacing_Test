using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideConcept2
{
    public class ISmartPhone : BasePhone
    {
        public int FrontCamMP;

        public ISmartPhone()
        {
            Console.WriteLine("SmartPhone Constructor");
        }

        public override void printPhoneInfo()
        {
            base.printPhoneInfo();
            Console.WriteLine("frontcam: {0} ", FrontCamMP);

        }
        /*
        public void PowerOff()
        {
            Console.WriteLine("SmartPhone PowerOff");
        }

        public void PowerOn()
        {
            Console.WriteLine("SmartPhone PowerOff");
        }*/
    }
}
