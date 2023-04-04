using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucher
{
    class BinarySearch
    {
        static void Main()
        {
            var data = new List<string>() { "banana", "peach", "apple" };
            data.Sort();
            Console.WriteLine(string.Join(",", data));
            int i = data.BinarySearch("peach");
            Console.WriteLine(i);

            i = data.BinarySearch("banana");
            Console.WriteLine(i);

            i = data.BinarySearch("apple");
            Console.WriteLine(i);
        }
    }
}
