﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class ManageEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private EmployeeModelClass[] EmployeeModelClassArray;

        public ManageEmpWage()
        {
            this.EmployeeModelClassArray = new EmployeeModelClass[5];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            EmployeeModelClassArray[this.numOfCompany] = new EmployeeModelClass(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                EmployeeModelClassArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.EmployeeModelClassArray[i]));
                Console.WriteLine(this.EmployeeModelClassArray[i].ToString());
            }
        }
        public int ComputeEmpWage(EmployeeModelClass companyEmpWage)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Day#" + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }

}


















