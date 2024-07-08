using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    internal class ListwithDelegates
    {
        static void Main(string[] args) {
            List<Employee> items = new List<Employee>();

            items.Add(new Employee { Id = 11, Name = "Srushti", Address= "Banglore" });
            items.Add(new Employee { Id = 12, Name = "Srushtii" ,Address = "Belagavi" });
            items.Add(new Employee { Id = 13, Name = "Srushtiii", Address = "Banglore" });
            items.Add(new Employee { Id = 14, Name = "Srushtiiii" , Address = "Belagavi" });
            items.Add(new Employee{Id = 15, Name = "Srushtiiiii", Address = "Banglore" });

            Console.WriteLine("Enter what you want to search");
            var selected = Console.ReadLine();

           var found = items.Find(e => e.Id.ToString().StartsWith(selected));
            Console.WriteLine("The found item is "+ found);

            var foundd = items.Find(e => e.Name.StartsWith(selected));
            Console.WriteLine("The found item is " + found);

            var selecteditems = items.FindAll(item => item.Name.Contains(selected));
            Console.WriteLine(" others ");
            foreach (var item in selecteditems) { Console.WriteLine("{0} {1} {2} ", item.Id, item.Name, item.Address); }

            var selecteditemss = items.FindAll(item => item.Address.Contains(selected));
            Console.WriteLine(" others ");
            foreach (var item in selecteditemss) { Console.WriteLine("{0} {1} {2} ",item.Id ,item.Name ,item.Address); }
        }

    }
}
