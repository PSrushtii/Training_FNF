using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SimpleClass : IDisposable
    {
        public int Value { get; set; }
        public SimpleClass(int value)
        {
            this.Value = value;
            Console.WriteLine($"The Simple class is created with value {Value}");
        }

        ~SimpleClass()
        {
            Console.WriteLine($"This Simple class is destroyed using Destructor with value {this.Value}");

        }
        public void Dispose()
        {
            Console.WriteLine($"This Simple class is destroyed using dispose with value {this.Value}");
            GC.SuppressFinalize(this);
        }
    }

    class Ex10Destructors
    {
        static void Main(string[] args)
        {
            CreateAndDestroyObjects();//ctor
        }

        private static void CreateAndDestroyObjects()
        {
            for (int i = 0; i < 10; i++)
            {
                //SimpleClass cls = new SimpleClass(i);
                //GC.Collect();
                //GC.WaitForPendingFinalizers();
                //cls.Dispose();

                using (SimpleClass cls = new SimpleClass(i))
                {

                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}

