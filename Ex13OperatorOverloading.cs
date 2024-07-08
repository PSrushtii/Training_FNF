using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employeee
    {
        public int EmpId {  get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

        //NOT ALL OPERATORS CAN BE OVERLOADED eg: =, & etc

        public static Employeee operator +(Employeee lhs, int rhs)
        {
            lhs.EmpSalary += rhs;
            return lhs;
        }
        public static Employeee operator -(Employeee lhs, int rhs)
        {
            lhs.EmpSalary -= rhs;
            return lhs;
        }

        public static implicit operator Employeee (Cst rhs)
        {
            var emp = new Employeee { EmpId = rhs.CstId, EmpSalary = rhs.BaseValue, EmpName = rhs.CstName };
            return emp;
        }

    }

    public class Cst
    {
        public int CstId { get; set; }
        public string CstName { get; set; }
        public int BaseValue { get; set; }
    }
    internal class Ex13OperatorOverloading
    {
        static void Main(string[] args)
        {
            Employeee emp = new Employeee { EmpId= 11, EmpName= "Srushti", EmpSalary= 45000};
            emp += 10000;
            Console.WriteLine("The salary is "+emp.EmpSalary);

            //Explicit Casting
            //Employeee emp2 = (Employeee)new Cst{ CstId = 12, CstName = "Srush", BaseValue = 4000 };
            //Console.WriteLine("The name is " +  emp2.EmpName);

            //Implicit Casting
            Employeee emp2 = new Cst { CstId = 12, CstName = "Srush", BaseValue = 4000 };
            Console.WriteLine("The name is " + emp2.EmpName);
        }
    }
}
