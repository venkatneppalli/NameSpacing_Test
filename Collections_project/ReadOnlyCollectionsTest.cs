using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_project
{
    public class ReadOnlyCollectionsTest
    {

        public void ReadOnlytest()
        {

            List<String> list = new List<String>();
            list.Add("test1");
            list.Add("test2");
            list.Add("test3");
            list.Add("test4");
            list.Add("test5");

            ReadOnlyCollection<String> rd = new ReadOnlyCollection<String>(list);
            //rd[0] = "ewtest";

        }

    }
}
