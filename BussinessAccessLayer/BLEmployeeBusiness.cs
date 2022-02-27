using CommanLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessAccessLayer
{
    public class BLEmployeeBusiness
    {
        private EmployeeDataAccessDb employeeData;
        public BLEmployeeBusiness()
        {
            employeeData = new EmployeeDataAccessDb();
        }
        public List<Employees> GetEmployees()
        {
            return employeeData.GetEmployees();
        }
    }
}
