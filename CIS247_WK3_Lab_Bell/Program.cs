using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationUtilities.DisplayApplicationInformation();
            //ApplicationUtilities.DisplayDivider("Please enter the emplyoyee information to be added");
            
            string [] sampleEmployee = new string [10];
                    int count = 0 ;
            do {
                for (int samp = 0; samp < sampleEmployee.Length; samp++)
                    {
                    
                    ApplicationUtilities.DisplayDivider("Please enter the emplyoyee information to be added");
                    Employee emp = new Employee();
                    emp.FirstName = InputUtilities.GetInput("First Name");
                    emp.LastName = InputUtilities.getStringInputValue("Last Name");
                    emp.Gender = InputUtilities.getCharInputValue("Gender");
                    emp.Dependents = InputUtilities.getIntegerInputValue("Number of dependents");
                    emp.AnnualSalary = InputUtilities.getDoubleInputValue("Annual Salary");
                    Console.WriteLine(emp.ToString());
                    emp.CalculateWeeklyPay();
                    Console.WriteLine("Weekly Pay: " + emp.CalculateWeeklyPay().ToString("C2"));
                    count = samp++;
                    Console.WriteLine("Number of employees: " + count ++);
                    }   
                }     while (count < 10);


            /*Employee emp = new Employee();
            emp.FirstName = InputUtilities.getStringInputValue("First Name");
            emp.LastName = InputUtilities.getStringInputValue("Last Name");
            emp.Gender = InputUtilities.getCharInputValue("Gender");
            emp.Dependents = InputUtilities.getDoubleInputValue("Number of dependents");
            emp.AnnualSalary = InputUtilities.getDoubleInputValue("Annual Salary");
            Console.WriteLine(emp.ToString());
            emp.CalculateWeeklyPay();
            Console.WriteLine("Weekly Pay: " + emp.CalculateWeeklyPay().ToString("C2"));
            ApplicationUtilities.PauseExecution();

            ApplicationUtilities.DisplayDivider("Get Updated Salary");
            emp.AnnualSalary = InputUtilities.getDoubleInputValue("Modified Annual Salary");
            Console.WriteLine(emp.FirstName + " " + emp.LastName + "'s Modifed Weekly Salary: " + emp.CalculateWeeklyPay(emp.AnnualSalary).ToString("C2"));
            Console.WriteLine("\n*** There are " + Employee.NumEmployees + " Employee objects created***");
            Employee emp2 = new Employee("John", "Doe", 'M', 2, 75000);
            Console.WriteLine(emp2.ToString());
            Console.WriteLine("\n*** There are " + Employee.NumEmployees + " Employee objects created***");
            Employee emp3 = new Employee("Sue", "Smith", 'F', 15, 500000.0);
            Console.WriteLine(emp3.ToString());*/

            //Console.WriteLine("Below are the employee(s) added");

            for (int samp = 0; samp < sampleEmployee.Length; samp++)
            {
                string newSamp = sampleEmployee[samp];
                Console.Write(newSamp);
            }

            Console.WriteLine("\n*** There are " + Employee.NumEmployees + " Employee objects created***");


            ApplicationUtilities.TerminateApplication();

        }
    }
}



           /* int [] sampleEmployee = new int [2];
            for (int samp = 0; samp < 2; samp++)
            {
                Employee emp = new Employee();
                emp.FirstName = InputUtilities.GetInput("First Name");
                emp.LastName = InputUtilities.getStringInputValue("Last Name");
                emp.Gender = InputUtilities.getCharInputValue("Gender");
                emp.Dependents = InputUtilities.getIntegerInputValue("Number of dependents");
                emp.AnnualSalary = InputUtilities.getDoubleInputValue("Annual Salary");
                Console.WriteLine(emp.ToString());
                emp.CalculateWeeklyPay();
                Console.WriteLine("Weekly Pay: " + emp.CalculateWeeklyPay().ToString("C2"));              
            }*/

