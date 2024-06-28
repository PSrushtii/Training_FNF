using System;
using System.Collections.Generic;
namespace SampleConApp
{
    class Expense{
        public int Id{ get; set;}

        public string Description{get; set;}

        public double Amount{get; set;}

        public DateTime Date{get; set;}

        public override string ToString(){
            return string.Format("----------\n Id ={0} \n Description={1} \n Amount={2} \n Date = {3}",Id,Description,Amount, Date);
        }
    }
     static class Curd{
        public static void Main(string[] args)
        {
            ExpenseCollections Exp= new ExpenseCollections();
            string stop="";
            do{
                Menu.WriteMenu();
                int choice= MyConsole.GetInteger("Enter your choice"); 
                switch(choice){
                    case 1: Expense exp= setvalues();
                            Exp.AddtoCart(exp);
                            break;
                    case 2: Exp.RemovetheProduct();
                            break;
                    case 3: Expense exp2= setvalues();
                            Exp.UpdatetheCart(exp2.Id,exp2);
                            break;
                    case 4: Exp.FindtheProduct();
                            break;
                    case 5: Exp.DisplayProducts();
                            break;
                    default: return;
                }
                
                stop=MyConsole.GetString("Press Y to continue else n");
            }while(stop.ToUpper()=="Y");
            
            
        }

        public static Expense setvalues()
        {
        
            var id= MyConsole.GetInteger("Enter the id of the product");

            var description= MyConsole.GetString("Enter the description of the product");
            
            var amount= MyConsole.GetDouble("Enter the amount of the product");

            Console.WriteLine("Enter the date of the product");
            var date1= Console.ReadLine();
            DateTime date;
            bool isValid= DateTime.TryParse(date1, out date);

            var myExpense= new Expense{Id=id, Description= description, Amount= amount, Date=date };

            return myExpense;
        }

    }


        class ExpenseCollections{
            private List<Expense> Products = new List<Expense>();

            public void AddtoCart(Expense expense)
            {
                Products.Add(expense);
            }

            public void RemovetheProduct()
            {
                int id= MyConsole.GetInteger("Enter the id of product to remove");

                Expense expense = null;
                foreach(var i in Products)
                {
                    if(i.Id==id)
                    {
                        expense=i;
                    
                    }   
                }
                Products.Remove(expense);
            }

            public void UpdatetheCart(int id, Expense expense)
            {
                foreach(var i in Products)
                {
                    
                    if(i.Id==expense.Id)
                    {
                        i.Description= expense.Description;
                        i.Amount= expense.Amount;
                        i.Date=expense.Date;
                        break;
                    }
                }
                    
            }


            public void FindtheProduct()
            {
                int id=MyConsole.GetInteger("Enter the id of item to to searched");
                foreach(var i in Products)
                {
                    if(i.Id==id)
                    {
                        Console.WriteLine(i);
                        
                    }
                    else
                    {
                        Console.WriteLine("No product with the Id {0} exists",id);
                    }
                }
                
            }

            public void DisplayProducts()
            {
                foreach(var prod in Products)
                {
                    Console.WriteLine(prod);
                    Console.WriteLine();
                }
                
            }



        }
}