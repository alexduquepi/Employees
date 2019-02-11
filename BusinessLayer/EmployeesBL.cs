using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;


namespace BusinessLayer
{
    public class EmployeesBL
    {
        public List<Employee> GetEmployees(int id)
        {
            List<Employee> employees = new EmployeesDAL().GetEmployees(id);

            employees.All(x => { x.AnnualSalary = EmployeeFactory.getEmployeeType(x.contractTypeName).getAnnualSalary(x.hourlySalary, x.monthlySalary); return true; });

            return employees ;
        }
    }
}
