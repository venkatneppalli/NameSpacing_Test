using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod_project
{
    public class SmartPhone : BasePhone
    {
        public SmartPhone()
        {
            Console.WriteLine("This is SmartPhone Constructor");
        }

        public int FrontCamMp;

        //Override
        public override void PrintPhoneInfo()
        {
            base.PrintPhoneInfo();
            Console.WriteLine("FrontCamMP:{0}",FrontCamMp);
        }
    }
}
