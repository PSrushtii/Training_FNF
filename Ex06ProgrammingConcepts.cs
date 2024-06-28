using System;
namespace SampleConApp
{

    class Arithmetic{
        public double FirstValue{get; set;}

        public string Operation{get; set;}

        public double SecondValue{get; set;}

        public double PerformOperation(){
            switch(Operation)
                {
                    case "+":
                        return(FirstValue+SecondValue);
                        
                    case "-":
                        return(FirstValue-SecondValue);
                        
                    case "*":
                        return(FirstValue*SecondValue);
                        
                    case "/":
                        return(FirstValue/SecondValue);
                        
                    default:
                        throw new Exception("Invalid Choice");
                        
                }
        }
        
    }


    

    // class PerformOperation{

    //     Arithmetic arithmetic = new Arithmetic{};
    //     arithmetic.FirstValue= first;
    //     arithmetic.Operation= operation;
    //     arithmetic.SecondValue= second;
    //     return arithmetic.PerformOperation(); 
    // }
    
    class Programmingconcepts
    {

        static double PerformOperation(double first,double second, string operation){
            Arithmetic arithmetic = new Arithmetic{};
            arithmetic.FirstValue= first;
            arithmetic.Operation= operation;
            arithmetic.SecondValue= second;
            return arithmetic.PerformOperation();


        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator app");

            string stop ="";

            do{
                double first = MyConsole.GetDouble("Enter the first number");

                string operation= MyConsole.GetString("Enter the operation to be performed as +,-,*,/");

                double second = MyConsole.GetDouble("Enter the first number");

                try{
                    double result= PerformOperation(first, second, operation);

                    Console.WriteLine("The result is {0}", result);

                    stop= MyConsole.GetString("Press Y to continue else N");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }while(stop.ToUpper() =="Y");
   
        }
    }
    
}