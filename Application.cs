using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Application
    {
        static void Main(string[] args)
        {
            string sentence = "The Quick and brown lazy fox jumps over the lazy dog";


            Encoder.Encode(sentence);

            DictionaryToDo.ToDo(sentence);
        }
    }
}
