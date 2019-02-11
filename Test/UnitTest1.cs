using BusinessLayer;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities;
using BusinessLayer;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BusinessLayer.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void GetEmployeesTest()
        {
            int id = 1;
            List<Employee> employeeExpected = new List<Employee>();
            employeeExpected.Add(new Employee() {
                id = 1,
                name = "Juan",
                contractTypeName = "HourlySalaryEmployee",
                roleId = 1,
                roleName = "Administrator",
                roleDescription = null,
                hourlySalary = 60000,
                monthlySalary = 80000,
                AnnualSalary = 86400000
                });
            
            List<Employee> employee = new EmployeesBL().GetEmployees(id);
            string expected = JsonConvert.SerializeObject(employeeExpected);
            string employeeActual = JsonConvert.SerializeObject(employee);
            Assert.AreEqual(expected, employeeActual);           
        }
    }
}

