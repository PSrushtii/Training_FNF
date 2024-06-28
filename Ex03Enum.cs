using System;

namespace SampleConApp
{
    enum AccountType{
        SBAccount=1, //---------> if not specified then it takes 0 as its value, also can initialize to any integer number it then starts with the given number and the next in enum has a number incremented by 1
        RBAccount,
        FDAccount,
    }

    class Ex03Enum{
        static void Main(string[] args)
        {
            // AccountType acc= AccountType.FDAccount;
            // Console.WriteLine("The Account selected is "+ acc);
            // Console.WriteLine("The internal value of the enum is " + (int)acc);
            InputExample();
        }
        static void InputExample(){

            // Use the Enum.GetValues
            // Iterate through the array to display
            // Take input from the user
            // Convert to the Enum using Enum.Parse and unbox it
            // Display the value

            Array array= Enum.GetValues(typeof(AccountType));
            Console.WriteLine("Enter the account type");
            foreach( var item in array)
            {
                Console.WriteLine(item);
            }
            AccountType acc=(AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine(), true);//---------> this "true" makes the input case insensitive

            Console.WriteLine("The account choosen is {0} and its internal value is {1}", acc, (int)acc);


            // Console.WriteLine("1. SBAccount, 2. RBAccount, 3. FDAccount\n Enter the account type");
            // AccountType acc=(AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine());
            // Console.WriteLine("The account choosen is {0} and its internal value is {1}", acc, (int)acc);

            
            // AccountType acc = new AccountType();
            // acc= Enum.Parse(Console.ReadLine(), SampleConApp.AccountType);
            // Console.WriteLine("The account selected is {0} and its internal value is {1}", acc, (int)acc);
        
        }
    }

    
}