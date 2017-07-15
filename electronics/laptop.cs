using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newelectronics
{
    public class laptop
    {

        internal int test_myinter = 300;
        protected int test_protected = 200;
        private int test_private = 100;
        public int test_public = 99;
        public void RAM_SIZE()
        {
            Console.WriteLine("this is my laptop name space ramsize method");
        }


       public int test_return_pro()
        {


            return test_protected;
        }

        public int test_return_interal()
        {

            return test_myinter;
        }

        public int test_return_private()
        {

            return test_private;
        }

        protected void protected_method_electroics()
        {

            Console.WriteLine("protected_method_electroics");
        }


        internal void internal_method_electroics()
        {

            Console.WriteLine("internal_method_electroics");
        }

        public void public_method_electronics()
        {

            Console.WriteLine("public_method_electronics");
        }
    }
}
