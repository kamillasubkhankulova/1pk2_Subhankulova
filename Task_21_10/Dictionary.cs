using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_10
{
    //Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммировать их значения.
    internal class Dictionary
    {
        public static Dictionary<string, int> MergeDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            Dictionary<string, int> mergedDictionary = new Dictionary<string, int>(dict1);
            foreach (var el in dict2)
            {
                string key = el.Key;
                int value = el.Value;
                if (mergedDictionary.ContainsKey(key))
                {
                    mergedDictionary[key] += value;
                }
                else
                {
                    mergedDictionary.Add(key, value);
                }
            }
            return mergedDictionary;
        }
    }

}

