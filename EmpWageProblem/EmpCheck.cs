﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class EmpCheck
    {
        public static void Attendance()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 0)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }













    }
}
