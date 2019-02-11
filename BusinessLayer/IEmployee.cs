using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLayer
{
    interface IEmployee
    {
        double getAnnualSalary(double hourlySalary, double monthlySalary);
    }
}
