using System;
using System.Collections.Generic;

namespace SampleConApp
{
    class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return string.Format("----------\n Id = {0} \n Description = {1} \n Amount = {2} \n Date = {3}", Id, Description, Amount, Date);
        }
    }

    static class Crud
    {
        public static void Main(string[] args)
        {
            ExpenseCollections Exp = new ExpenseCollections();
            string stop = "";
            do
            {
                WriteMenu();
                int choice = MyConsole.GetInteger("Enter your choice");
                switch (choice)
                {
                    case 1:
                        Expense exp = SetValues();
                        Exp.AddtoCart(exp);
                        break;
                    case 2:
                        Exp.RemovetheProduct();
                        break;
                    case 3:
                        Expense exp2 = SetValues();
                        Exp.UpdatetheCart(exp2.Id, exp2);
                        break;
                    case 4:
                        Exp.FindtheProduct();
                        break;
                    case 5:
                        Exp.DisplayProducts();
                        break;
                    default:
                        return;
                }

                stop = MyConsole.GetString("Press Y to continue else n");
            } while (stop.ToUpper() == "Y");
        }

        public static Expense SetValues()
        {
            var id = MyConsole.GetInteger("Enter the id of the product");
            var description = MyConsole.GetString("Enter the description of the product");
            var amount = MyConsole.GetDouble("Enter the amount of the product");

            Console.WriteLine("Enter the date of the product (yyyy-MM-dd):");
            var date1 = Console.ReadLine();
            DateTime date;
            bool isValid = DateTime.TryParse(date1, out date);
            if (!isValid)
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
                return null;
            }

            var myExpense = new Expense { Id = id, Description = description, Amount = amount, Date = date };

            return myExpense;
        }

        public static void WriteMenu()
        {
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. Remove Expense");
            Console.WriteLine("3. Update Expense");
            Console.WriteLine("4. Find Expense");
            Console.WriteLine("5. Display Expenses");
        }
    }

    static class MyConsole
    {
        public static int GetInteger(string prompt)
        {
            Console.Write(prompt + ": ");
            return int.Parse(Console.ReadLine());
        }

        public static string GetString(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }

        public static double GetDouble(string prompt)
        {
            Console.Write(prompt + ": ");
            return double.Parse(Console.ReadLine());
        }
    }

    class ExpenseCollections
    {
        private Dictionary<int, Expense> Products = new Dictionary<int, Expense>();

        public void AddtoCart(Expense expense)
        {
            if (!Products.ContainsKey(expense.Id))
            {
                Products.Add(expense.Id, expense);
                Console.WriteLine("Expense added successfully.");
            }
            else
            {
                Console.WriteLine("An expense with this ID already exists.");
            }
        }

        public void RemovetheProduct()
        {
            int id = MyConsole.GetInteger("Enter the id of product to remove");
            if (Products.ContainsKey(id))
            {
                Products.Remove(id);
                Console.WriteLine("Expense removed successfully.");
            }
            else
            {
                Console.WriteLine("Expense not found.");
            }
        }

        public void UpdatetheCart(int id, Expense expense)
        {
            if (Products.ContainsKey(id))
            {
                Products[id] = expense;
                Console.WriteLine("Expense updated successfully.");
            }
            else
            {
                Console.WriteLine("Expense not found.");
            }
        }

        public void FindtheProduct()
        {
            int id = MyConsole.GetInteger("Enter the id of item to be searched");
            if (Products.ContainsKey(id))
            {
                Console.WriteLine(Products[id]);
            }
            else
            {
                Console.WriteLine("No product with the Id {0} exists", id);
            }
        }

        public void DisplayProducts()
        {
            foreach (var prod in Products.Values)
            {
                Console.WriteLine(prod);
                Console.WriteLine();
            }
        }
    }
}
