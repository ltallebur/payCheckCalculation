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



          