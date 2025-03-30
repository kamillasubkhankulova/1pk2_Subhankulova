using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_07
{
    internal class Lib
    {
        public static string FindFirstKey(Dictionary<string, int> dictionary, int value)
        {
            foreach (string key in dictionary.Keys)
            {
                int nowValue = dictionary[key];
                if (nowValue == value)
                {
                    return key;
                }
            }
            return null;
        }
    }
}

