﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class MultipleCompanies
    {
         public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static void ComputeWage(string Company, int empRateperhour, int numOfWorkingDays, int maxHrsInMonths)
        {
            
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            
            while (totalEmpHrs <= maxHrsInMonths && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRateperhour;
            Console.WriteLine("Total Emp Wage of {0}: {1} ", Company, totalEmpWage);
          
        }
       
    }
}



    

