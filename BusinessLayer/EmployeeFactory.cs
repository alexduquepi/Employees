using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class EmployeeFactory
    {
        public static IEmployee getEmployeeType(string contract)
        {
            if (contract == "HourlySalaryEmployee")
                return new HourlyEmployee();
            else
                return new MonthlyEmployee();
        }
    }
}
