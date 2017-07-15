using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_project
{
    public class DictionaryCollections
    {

        public void DictionaryObj()
        {
            Dictionary<String, int> dicval = new Dictionary<string, int>();
            dicval.Add("CA", 123);
            dicval.Add("ST", 321);

            /* foreach(KeyValuePair<String,int> pair in dicval)
             {
                 Console.WriteLine(pair);
             }*/

            Console.WriteLine("Dictionary count:= "+dicval.Count);

            for(int i=0;i<dicval.Count;i++)
            {
                var item = dicval.ElementAt(i);
                var itemkey = item.Key;
                var itemvalue = item.Value;
                Console.WriteLine("key: {0},value: {1}",itemkey,itemvalue);

            }
        }

    }

    


}
