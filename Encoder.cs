using System.Runtime.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Encoder
    {

        public static int[] toadd = new int[252];
        public static void FirstIndex(string sentence)
        {
            
            int size = sentence.Length;
            
            int space = 0;
            for (int i = 0; i < size; i++)
            {
                char c = sentence[i];
                int Index = sentence.IndexOf(c);
                for( int j=0; j<Index; j++)
                {
                    if(c == ' ')
                    {
                        space++;
                    }
                }
                toadd[i]= space; ;
            }
            
            


        }

    

        public static void LastIndex(string sentence)
        {
            int size = sentence.Length;
            // int space = 0;
            List<string> words = new List<string>();
            for (int i = 0; i < size; i++)
            {
                int j = i;
                while(sentence[i] != ' ')
                {
                    continue;
                }
                words.Add(sentence.Substring(j, i + 1));

            }
            for (int i = 0; i < size; i++)
            {
                foreach (string s in words)
                {
                    int secondIndex = (s.IndexOf(sentence[i]));
                    toadd[i] = ((toadd[i] * 10) + secondIndex);
                }
            }    
        }

        public static void Encode(string sentence)
        {
            if (sentence.Length == 0) { throw new Exception("Null reference exception"); }
            else if (sentence == null) { throw new Exception("Argument exception"); }
            else { FirstIndex(sentence);
                LastIndex(sentence);
                DisplayArr(sentence); }
        }

        private static void DisplayArr(string sentence)
        {
            int size = sentence.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write(sentence[i] + ",");
            }
        }
    }

    
}
