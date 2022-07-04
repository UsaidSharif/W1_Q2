using System;

namespace W1_Q2
{
    class SalarySlip  
    {
         
        
        public int AskDesignation()
        {
            int Num;
            Console.WriteLine("\nWhat is your Designation\n" +
                "Enter 1 For Engineerrs\n" +
                "Enter 2 For Managers\n" +
                "Enter 3 For Analysts\n");
            
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num>3 || Num<1)
            {
                Num = 0;
            }
            return Num;

        }

    }
    class Employees

    {
        protected double baseSalary = 1500;
        protected double FuelAllownace = 0;
        protected double MedicalAllowance = 0;

        public virtual double CalculateSalary()
        {
            return baseSalary + FuelAllownace + MedicalAllowance;

        }
    }
    class Engineers : Employees
    {
        public Engineers()
        {
            FuelAllownace = 100;
            MedicalAllowance = 500;
        }
  
    }

    class Managers : Employees
    {
        public Managers()
        {
            FuelAllownace = 250;
            MedicalAllowance = 1000;
        }
       
    }
    class Analysts : Employees
    {
        public Analysts()
        {
            FuelAllownace = 150;
            MedicalAllowance = 800;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SalarySlip MySalarySlip = new SalarySlip();
            Employees MyEnginnersSalarySlip = new Engineers();
            Employees MyManagersSalarySlip = new Managers();
            Employees MyAnalystsSalarySlip = new Analysts();

            int num = MySalarySlip.AskDesignation();

            if (num == 1)
                Console.WriteLine("your gross salary is: " + MyEnginnersSalarySlip.CalculateSalary());
            else if (num == 2)
                Console.WriteLine("your gross salary is: " + MyManagersSalarySlip.CalculateSalary());
            else if (num == 3)
                Console.WriteLine("your gross salary is: " + MyAnalystsSalarySlip.CalculateSalary());
            else if (num==0)
                Console.WriteLine("please enter right designation");

        }
    }
}
