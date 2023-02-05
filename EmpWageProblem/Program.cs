using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpCheck empcheck = new EmpCheck();
            EmpCheck.Attendance();
            
            DailyWage empcheckk = new DailyWage();
            DailyWage.EmpWage();

            PartTime empcheckkk = new PartTime();
            PartTime.EmpWagePart();
            Console.ReadLine();



        }
    }
}
