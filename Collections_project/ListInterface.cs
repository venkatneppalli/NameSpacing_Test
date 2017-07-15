using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_project
{
   public class ListInterface
    {

        public void ListInt()
        {
            List<int> list = new List<int>();

            list.Add(100);
            list.Add(101);
            list.Add(102);
            list.Add(103);
            list.Add(104);
            list.Add(104);


            foreach (int element in list)
            {

                Console.WriteLine("Print list int values:="+element);
            }
        }

        public void ListLong()
        {
            
            List<long> listlng = new List<long>();

            listlng.Add(1234567);
            listlng.Add(1234568);
            listlng.Add(1234569);
            listlng.Add(1234566);

            for(int i=0;i<listlng.Count;i++)
            {
                Console.WriteLine(listlng[i]);
            }

        }

        public void ListString()
        {
            List<String> listStr = new List<String>();

            listStr.Add("str1");
            listStr.Add(" ");
            listStr.Add("str1");

            Console.WriteLine("Size of List Before Remove:= "+listStr.Count);

            listStr.Insert(3, "mynewitem");
            //listStr.Remove("str1");

            listStr.RemoveRange(1, 2);


            listStr.AddRange(listStr);

            foreach(String s in listStr)
            {
                Console.WriteLine(s);
            }

            /*Console.WriteLine("Size of List After Remove:= " + listStr.Count);

            for (int i=0;i<listStr.Count;i++)
            {
                Console.WriteLine(listStr[i]);
            }*/

        }

        public void ListObject()
        {
            List<object> obj = new List<object>();

            obj.Add("testng");
            obj.Add(123);
            obj.Add(1234534543);
            obj.Add(1.123);
            obj.Add(1.123);
            obj.Add(1.123);
            obj.Add(" ");

            foreach(object ob in obj)
            {
                Console.WriteLine(ob);
            }
        }

    }
}
