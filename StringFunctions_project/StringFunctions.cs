using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions_project
{
    public class StringFunctions
    {

        public void string_comparision()
        {
            String str1 = "Today it is going to rain heavly in our place";
            String str2 = "Today it is going to rain heavly in India";

            if(str1.Equals(str2))
            {
                Console.WriteLine("Both strings are same");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }

        }

        public void string_compare_fun()
        {
            String str1 = "Today it is going to rain heavly in our place";
            String str2 = "Today it is going to rain heavly in India";

            

            if (ReferenceEquals(str1,str2))
            {
                Console.WriteLine("Both strings are same");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }

        public void string_isNull_fun()
        {

            String str1 = "";
            String str2 = null;

            if(String.IsNullOrEmpty(str1))
            {
                Console.WriteLine("is null or empty");

            }
            else
            {
                Console.WriteLine("is not null or empty");
            }

        }

        public void string_isNullOrWhiteSpace()
        {
            String str1 = "null";
            if(String.IsNullOrWhiteSpace(str1))
            {
                Console.WriteLine("isnullorwhitespace");
            }
            else
            {
                Console.WriteLine("isNOTnullorwhitespace");
            }
        }
        public void string_stringformater()
        {
            String str1 = "selenium";

            String formatterstr = String.Format("my name is {0}", str1);

            Console.WriteLine(formatterstr);
        }
    }
}
