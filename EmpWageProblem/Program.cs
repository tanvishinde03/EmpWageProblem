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
                Console.ReadLine();

                DailyWage empcheckk = new DailyWage();
        DailyWage.EmpWage();
                Console.ReadLine();

                PartTime empcheckkk = new PartTime();
        PartTime.EmpWagePart();
                Console.ReadLine();

                Switchcase emppcheck = new Switchcase();
        Switchcase.SwitchCase();
                Console.ReadLine();

                MonthlyWage obj = new MonthlyWage();
        MonthlyWage.EmployeeMonthlyWage();
                Console.ReadLine();

                HoursDaysTotal Obj = new HoursDaysTotal();
        HoursDaysTotal.DaysHoursOfMonth();
                Console.ReadLine();

            Refactor obJ = new Refactor();
            Refactor.ComputeEmpWage();
            Console.ReadLine();
    }
}
}
    




    


