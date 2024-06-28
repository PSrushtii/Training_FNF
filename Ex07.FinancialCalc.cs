using System;

namespace SampleConApp
{
    class EMI{
        public double Amount { get; set;}

        public double InterestRate { get; set; }

        public int LoanTenure{ get; set;}
    }

    class RD{
        public double MonthlyDeposit {get; set;}

        public double InterestRate { get; set; }

        public int TenureMonths{ get; set;}

    }

    class ToCalculateEMI{
        public static void LoanEMI(EMI emi)
        {
            double monthlyIR= emi.InterestRate/12/100;
            double emivalue = emi.Amount*monthlyIR*Math.Pow(1+monthlyIR,emi.LoanTenure)/(Math.Pow(1+monthlyIR,emi.LoanTenure)-1);
            Console.WriteLine("EMI Value = {0}", emivalue);            
            
        }

        public static void TotalPayableAmount(EMI emi)
        {
            double monthlyIR= emi.InterestRate/12/100;
            double emivalue = emi.Amount*monthlyIR*Math.Pow(1+monthlyIR,emi.LoanTenure)/(Math.Pow(1+monthlyIR,emi.LoanTenure)-1);
            double totalpayamt= emivalue*emi.LoanTenure;
            Console.WriteLine("Total Payable Amount = {0}",totalpayamt); 
            
        }

        public static void TotalPayment(EMI emi)
        {
            double monthlyIR= emi.InterestRate/12/100;
            double emivalue = emi.Amount*monthlyIR*Math.Pow(1+monthlyIR,emi.LoanTenure)/(Math.Pow(1+monthlyIR,emi.LoanTenure)-1);
            double totalpayamt= emivalue*emi.LoanTenure;
            double totInt= totalpayamt-emi.Amount;
            Console.WriteLine("Total Payment = {0}",totInt); 
            
        }

        
    }

    class ToCalculateRDAmount{
        public static void CalcRD(RD rd)
        {
            double monthlyIR= rd.InterestRate/12/100;
            // double maturityamt= rd.MonthlyDeposit*(Math.Pow(1+monthlyIR, rd.TenureMonths) - 1)/(1-Math.Pow(1+monthlyIR, -1 / 3.0));

            double maturityamt=0;

            for(int i=0;i<rd.TenureMonths; i++)
            {
                maturityamt += rd.MonthlyDeposit*Math.Pow(1+monthlyIR, rd.TenureMonths-i);
            }
            Console.WriteLine("RD maturity amount= {0}", maturityamt);

        }
    }

    class Financialcalc
    {
        static void Main(string[] args)
        {
            string stop = "";

            ToCalculateEMI tocalcEMI = new ToCalculateEMI{};
            ToCalculateRDAmount tocalcRD= new ToCalculateRDAmount{};

            Console.WriteLine("CALCULATE THE LOAN");

            do{
                Menu.PrintMenu();
                int option = MyConsole.GetInteger("Enter the option");
                switch(option)
                {
                    case 1: EMI emi1 = readInput();
                            ToCalculateEMI.LoanEMI(emi1);
                            ToCalculateEMI.TotalPayableAmount(emi1);
                            ToCalculateEMI.TotalPayment(emi1);
                            break;

                    case 2: EMI emi2 = readInput();
                            ToCalculateEMI.LoanEMI(emi2);
                            ToCalculateEMI.TotalPayableAmount(emi2);
                            ToCalculateEMI.TotalPayment(emi2);
                            break;
                    case 3: RD rd1= readInput1();
                            ToCalculateRDAmount.CalcRD(rd1);
                            break;

                    default: return;
                            

                    

                }

                stop= MyConsole.GetString("Press y to continue else n");

            }while(stop.ToUpper()=="Y");
        }


        public static EMI readInput()
        {
            var amount= MyConsole.GetDouble("Enter the amount");

            var interestRate = MyConsole.GetDouble("Enter the Interest Rate");

            int loanTenure = MyConsole.GetInteger("Enter the loan Tenure");

            return new EMI{
                Amount = amount,
                InterestRate= interestRate,
                LoanTenure= loanTenure
            };
        }

        public static RD readInput1()
        {
            var mon = MyConsole.GetDouble("Enter the monthlyDeposit");

            var interestRate = MyConsole.GetDouble("Enter the Interest Rate");

            int tenureMonths = MyConsole.GetInteger("Enter the RD Tenure in months");

            return new RD{
                MonthlyDeposit = mon,
                InterestRate= interestRate,
                TenureMonths= tenureMonths
            };

        }
    }
    
}