using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class Switchcase
    {
        public static void SwitchCase()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;
            int Is_Part_Time = 2;
            int Empwage;
            int Emphours;

            Random random = new Random();
            int empcheck = random.Next(2);

            switch (empcheck)
            {
                case 0:

                    Emphours = 8;
                    Console.WriteLine(" Is_Full_Time");
                    break;

                case 1:
                    Emphours = 4;
                    Console.WriteLine("Is_Part_Time");
                    break;

                default:
                    Emphours = 0;
                   
                    break;
            }

            Empwage = Emphours * Emp_Rate_Per_Hour;
            Console.WriteLine("Daily employee wage is : " + Empwage);

        }
    }
}












    

