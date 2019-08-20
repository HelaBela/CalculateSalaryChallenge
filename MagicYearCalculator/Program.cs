using System;
using System.Security.Cryptography;


namespace MagicYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Provide your annual salary");
            var initialSalary = int.Parse(Console.ReadLine());
            var userAnnualSalary = initialSalary;
          
            
            Console.WriteLine("When was your work start year?");
            var userWorkStartYear = int.Parse(Console.ReadLine());
            
            Console.WriteLine("yrs to retire?");
            var yearsToRetire = int.Parse(Console.ReadLine());
         
            
            var magicYear = userWorkStartYear + yearsToRetire;
            var workYearsTotal = magicYear - userWorkStartYear;
            var montlySalary = Math.Round((decimal) (userAnnualSalary / 12));
            
            
            
            var countLeapYears = 0;
           // var userAnnualSalary = 0;
            var totalSal = 0;

            for ( var userWorkYear = userWorkStartYear; userWorkYear < magicYear-1; userWorkYear++)
            {

                if (userWorkYear % 4 == 0)
                {
                    countLeapYears++;
                   
                }
                else
                {
                    userAnnualSalary = (int) (userAnnualSalary * 0.02) + userAnnualSalary;
                    totalSal += userAnnualSalary;
                }
                
            }

            var realToal = totalSal + initialSalary;

            var yearsWorkedTotalWithLeapGaps = workYearsTotal - countLeapYears;

            
            
            Console.WriteLine($"your magical year is {magicYear} and your monthly salary is {montlySalary}. If taking vacation on every leap year for a year, you will work in total {yearsWorkedTotalWithLeapGaps} years, and you will make in total ${realToal} ");

        }
        
    }
}

//10k
//2017
//20200

/*Provide your annual salary
10000
When was your work start year?
2017
your magical year is 2027 and your monthly salary is 833. If taking vacation on every leap year for a year, you will work in total 8 years, and you will make in total $85825 */
