using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Interface;
using Employees.Model;

namespace Employees.DataServices
{
    public class EmployeeDataServices: IEmployeeDataService
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee
            {
                EmployeeID = "1",
                EmployeeName = "Sifiso",
                ContactNumber = "0123456789",
                Designation = "SSP",
                MailID = "sifiso@hotmail.com",
                ReportingPerson = "AAA",
                IsSupervisor = false,
                SkillSet = "ASP.NET MVC 6, C#, DB"
            });
            return employees;
        }
        public List<Employee> GetAllEmployees()
        {
            var employees = GetEmployees();
            return employees;
        }

        public Employee GetEmployeebyId(string employeeId)
        {
            var employees = GetEmployees();
            var employee = employees.Find(id => id.EmployeeID == employeeId);
            return employee;
        }

        public List<Employee> SaveEmployee(Employee employee)
        {
            var employees = GetEmployees();
            employees.Add(employee);
            return employees;
        }

        public List<Employee> DeleteEmployeeById(string eid)
        {
            var employees = GetEmployees();
            var employee = employees.Find(id => id.EmployeeID == eid);
            employees.Remove(employee);
            return employees;
        }

        public List<Employee> UpdateEmployee(string eid, Employee employee)
        {
            var employees = GetEmployees();
            var employeeById = employees.Find(id => id.EmployeeID == eid);
            employeeById.EmployeeName = employee.EmployeeName;
            employeeById.ContactNumber = employee.ContactNumber;
            employeeById.Designation = employee.Designation;
            employeeById.MailID = employee.MailID;
            employeeById.SkillSet = employee.SkillSet;
            employeeById.IsSupervisor = employee.IsSupervisor;
            employeeById.ReportingPerson = employee.ReportingPerson;

            return employees;
        }
    }
}
