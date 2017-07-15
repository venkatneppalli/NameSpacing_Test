using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_project
{
    class Program
    {
      public  static void Main(string[] args)
        {

            ListInterface c = new ListInterface();
            //c.ListInt();
            // c.ListLong();
            c.ListString();
            //c.ListObject();

            //DictionaryCollections d = new DictionaryCollections();
            //d.DictionaryObj();


            Console.ReadKey();

        }
    }
}
