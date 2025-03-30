using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_08
{
    internal class Dictionary
    {
        public static string[] GetStrings(params string[] inputStrings)
        {
            SortedSet<string> uniqueStrings = new SortedSet<string>();
            foreach (string str in inputStrings)
            {
                uniqueStrings.Add(str);
            }
            return uniqueStrings.ToArray();
        }
    }
}
