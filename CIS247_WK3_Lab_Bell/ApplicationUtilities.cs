using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    public class ApplicationUtilities
    {
        public static void DisplayApplicationInformation()
        {
            Console.WriteLine("Welcome the Basic Employee Program");
            Console.WriteLine("******** " + System.DateTime.Now + " ********");
            Console.WriteLine("CIS247a, Week 2 Lab");
            Console.WriteLine("Name: Rufus A. Bell");
            Console.WriteLine("This program accepts user input as a string, then makes the \n");
            Console.WriteLine("appropriate data conversion and assigns the value to Employee objects");
            Console.WriteLine();
        }
        public static void DisplayDivider(string outputTitle)
        {
            Console.WriteLine("\n********* " + outputTitle + " *********\n");
        }
        public static void TerminateApplication()
        {
            DisplayDivider("Program Termination");
            Console.Write("Thank you.  Press any key to terminate the program...");
            Console.ReadLine();
        }
        public static void PauseExecution()
        {
            Console.Write("\nProgram paused, press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
