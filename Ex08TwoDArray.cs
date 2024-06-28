using System;
namespace SampleConApp
{
    public class Ex08TwoDArray
    {
        static void Main(string[] args)
        {
            MultiDimensionalArray();
        }

         private static void MultiDimensionalArray()
        {
            int[,] TwoDArray = { 
                                { 1, 2, 3, 4 }, 
                                { 2, 3, 4, 5 }, 
                                { 3, 4, 5, 6 } 
                              };
            

            Console.WriteLine("Displaying in matrix format");
            for (int i = 0; i < TwoDArray.GetLength(0); i++) {
                for (int j = 0; j < TwoDArray.GetLength(1); j++) {
                    Console.Write(TwoDArray[i, j]);
                    if(j==(TwoDArray.GetLength(1)-1))
                    {
                        continue;
                    }
                    else{
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}