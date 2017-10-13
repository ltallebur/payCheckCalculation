using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Employee
    {
        //Constants
        private const int MIN_DEPENDENTS = 0;
        private const int MAX_DEPENDENT = 10;
        private const double MIN_SALARY = 20000;
        private const double MAX_SALARY = 100000;
        private const string DEFAULT_NAME = "NOT GIVEN";
        private const char DEFAULT_GENDER = 'U';
        private static int numEmployees = 0;

        //data members
        private string firstName = DEFAULT_NAME;
        private string lastName = DEFAULT_NAME;
        private char gender = DEFAULT_GENDER;
        private double dependents = MIN_DEPENDENTS;
        private double annualSalary = MIN_SALARY;


        #region constructors

        //Default Constructors
        public Employee()
        {
            numEmployees++;
        }

        //Overload constructor
        public Employee(string firstName, string lastName, char gender, int dependents, double annualSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Dependents = dependents;
            AnnualSalary = annualSalary;
            numEmployees++;

        }
        #endregion

        #region Properties

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    firstName = DEFAULT_NAME;
                else
                    firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    lastName = DEFAULT_NAME;
                else
                    lastName = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == 'F')
                    gender = value;

                else if(value =='f')
                    gender = value;
                else if (value =='M')
                    gender = value;
                else if (value == 'm')
                    gender = value;
                else
                    gender = DEFAULT_GENDER;

            }
        }

        public double Dependents
        {
            get
            {
                return dependents;
            }
            set
            {
                if (value >= MIN_DEPENDENTS && value <= MAX_DEPENDENT)
                    value = dependents;
                else if (value < MIN_DEPENDENTS)
                    dependents = MIN_DEPENDENTS;
                else 
                    dependents = MAX_DEPENDENT;
               
            }
        }


        public double AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            set
            {
                if (value >= MIN_SALARY && value <= MAX_SALARY)
                    annualSalary = value;
                else if (value < MIN_SALARY)
                    annualSalary = MIN_SALARY;
                else 
                    annualSalary = MAX_SALARY;

            }
        }

            public static int NumEmployees
        {
            get 
            { 
                return numEmployees; 
            }

        }
        #endregion

        public double CalculateWeeklyPay()
            {
                return annualSalary / 52 ;

            }

        public double CalculateWeeklyPay(double modifiedSalary)
            {
            AnnualSalary = modifiedSalary;
            return CalculateWeeklyPay();
            }



        public override string ToString()
        {
            string strReturnVal;

            strReturnVal = "============ Employee Information ============\n" +
                           "Name: " + firstName + " " + lastName + "\n" +
                           "Gender: " + gender + "\n" +
                           "Dependents: " + dependents + "\n" +
                           "Annual Salary: " + annualSalary.ToString("C2");

            return strReturnVal;
        }

    }

}
