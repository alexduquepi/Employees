using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class HourlyEmployee : IEmployee
    {
        public double getAnnualSalary(double hourlySalary, double monthlySalary)
        {
            return 120 * hourlySalary * 12;
        }
    }
}
