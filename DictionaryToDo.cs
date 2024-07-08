using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DictionaryToDo
    {
        private static Dictionary<string, int> dictionary = new Dictionary<string, int>();

        public static void ToDo(string sentence)
        {
            int size = sentence.Length;
            int occurance = 1;


            for (int i = 0; i < size; i++)
            {
                int j = i;
                while (sentence[i] != ' ')
                {
                    continue;
                }
                if (!dictionary.ContainsKey(sentence.Substring(j, i + 1)))
                {
                    dictionary.Add(sentence.Substring(j, i + 1), occurance);
                }
                else
                {
                    //increment the value of that key in dictionary
                    dictionary.Add(sentence.Substring(j, i + 1), occurance++);

                }
            }

            foreach (string s in dictionary.Keys)
            {
                if (dictionary[s] > 1)
                {
                    Console.WriteLine("{0} is Duplicate", s);
                }
                else
                {
                    Console.WriteLine("{0} is Duplicate", s);

                }
            }
        }
    }
}
