using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public interface EmpWageInterface
    {

        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void ComputeEmpWage();
        int ComputeEmpWage(EmployeeModelClass companyEmpWage);

    }
}


















