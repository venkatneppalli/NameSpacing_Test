using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test
{
    public class ISmartPhone : BasePhone
    {
        public int FrontCamMP;

        public override void PrintPhoneInfo()
        {

            Console.WriteLine("Model: {0},Brand: {1},FrontCam: {2}", model, brandname,FrontCamMP);
        }

        /*
        public String smartphone_brandname;
        public String smartphone_model;

        
        public void PowerOff()
        {
            Console.WriteLine("SmartPhone PowerOff");
        }

        public void PowerOn()
        {
            Console.WriteLine("SmartPhone PowerOn");
        }

        public void PrintSmartPhoneInfo()
        {
            Console.WriteLine("Model: {0}, Brand: {1}",smartphone_model,smartphone_brandname);
        }*/
    }
}
