using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class Ex12MultiThreading
    {
        static void NormalFunction()
        {
            Console.WriteLine("The Normal function has begun");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Thread Beep #{i}");
                Console.Beep();
            }
            Console.WriteLine("The function has ended");
        }
        
        static void ParameterizedFunction(object arg)
        {
            int max = (int)arg;
            Console.WriteLine("The Normal function has begun");
            for (int i = 0; i < max; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Thread arg Beep #{i}");
                Console.Beep();
            }
            Console.WriteLine("The function has ended"); //Grepper

        }

        static void AsyncFunction()
        {

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Main has started to execute");
            
            //Invoke the NorrmalFunction as a seperate Thread, so that the main can continue to do its tasks.
            Thread th = new Thread(NormalFunction);
            Thread th2 = new Thread(new ParameterizedThreadStart(ParameterizedFunction));
            th.Start();
            th2.Start(5);
            for(int i= 0;i<10; i++)
            {
                Thread .Sleep(500);
                Console.WriteLine("Main is doing its job");
            }
            Console.WriteLine("Main has ended the functionalities, time to close");
        }
    }
}
