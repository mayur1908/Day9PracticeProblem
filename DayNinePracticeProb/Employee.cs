using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DayNinePracticeProb
{
    //I've created a class called Employee that encapsulates the logic for calculating the employee wage. 
    class Employee
    {
        private Random random;

        public Employee()
        {
            //The Employee class has a private field random of type Random to generate random numbers.
            random = new Random();
        }

    //    We then call the CalculateWage method on each instance, passing the specific wage rate
    //      number of working days and working hours per month for each company.
        public int CalculateWage(int wageRate, int numWorkingDays, int workingHoursPerMonth)
        {
            //The CalculateWage method calculates the employee wage by iterating over the working days until 

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;

            while (totalWorkingHours < workingHoursPerMonth && totalWorkingDays < numWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = random.Next(3);
    //It uses a switch statement to determine the number of hours worked based on the random number generated.

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }

                totalWorkingHours += empHour;
                Console.WriteLine("Day {0}: {1} hours", totalWorkingDays, empHour);
                empWage = empHour * wageRate;
                totalEmpWage += empWage;
            }

            Console.WriteLine("\nTotal Working Days: " + totalWorkingDays);
            Console.WriteLine("Total Working Hours: " + totalWorkingHours);
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);

            return totalEmpWage;
        }
    }
}
