using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JMCC_Employee_Track_Record.Controllers
{
    public class EmployeeController : ApiController
    {
        private EmployeeEntities androidEntities = new EmployeeEntities();

        public IEnumerable<Employee> Get()
        {
            return androidEntities.Employees.AsEnumerable();
        }

        public Employee Get(int id)
        {
            return androidEntities.Employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public Employee Post(string fullname, DateTime logindate, DateTime logoutdate)
        {
            Employee product = new Employee()
            {
                Full_Name = fullname,
                Login_Date = logindate,
                Logout_Date = logoutdate
            };

            androidEntities.Employees.Add(product);
            androidEntities.SaveChanges();
            return product;
        }

        public Employee Post(Employee employee)
        {
            Employee foundEmployee = androidEntities.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();
            if (foundEmployee != null)
            {
                foundEmployee.Full_Name = employee.Full_Name;
                foundEmployee.Login_Date = employee.Login_Date;
                foundEmployee.Logout_Date = employee.Logout_Date;
            }
            androidEntities.SaveChanges();
            return foundEmployee;
        }

        public void Delete(int id)
        {
            Employee employee = androidEntities.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee != null)
            {
                androidEntities.Employees.Remove(employee);
            }
            androidEntities.SaveChanges();
        }
    }
}
