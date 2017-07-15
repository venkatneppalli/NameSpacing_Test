using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newelectronics.desktopComp;
using electronics;


namespace newelectronics
{
    class Program
    {
       public static void Main(string[] args)
        {

            desktopcomp d = new desktopcomp();
            d.keyboard_desktop();
            d.mouse_desktop();

            TEST t = new TEST();
            t.test_test();

        }
    }
}
