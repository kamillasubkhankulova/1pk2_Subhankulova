using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_06
{
    internal class List
    {
        public static List<int> Remove(List<int> list)
        {
            List<int> elements = new List<int>();
            SortedSet<int> seen = new SortedSet<int>();
            foreach (int el in list)
            {
                if (!seen.Contains(el))
                {
                    elements.Add(el);
                    seen.Add(el);
                }
            }
            return elements;
        }
    }
}

