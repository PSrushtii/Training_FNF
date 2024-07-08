using ClassLibrary1;
using ConsoleApp1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex11UsingDLL
    {
        static void Main(string[] args)
        {
            //simpleExample();
            //usingEmployeeComponent();
            usingEmployeeReading();
        }

        private static void usingEmployeeReading()
        {
            var empComponent = EmployeeFactory.CreateComponent("");
            var emp = empComponent.FindEmployee("Srushti");
            if (emp != null)
            {
                Console.WriteLine($" {emp.Name} from {emp.Address}");
            }
            
        }

        private static void usingEmployeeComponent()
        {
            AppSettings.Initialize();
            var dirName = AppSettings.Configuration["FileOptions:EmployeeFile"];
            var empComponent = EmployeeFactory.CreateComponent(dirName);
            empComponent.AddNewEmployee(123, "Srushti", "Sidnal");

            


            
        }

        private static void simpleExample()
        {
            MathComponent math = new MathComponent();
            var res = math.AddFunc(20, 30);
            Console.WriteLine(res);
        }
    }
}
