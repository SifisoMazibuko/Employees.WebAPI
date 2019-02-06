using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Interface
{
    public interface IEmployeeDataService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeebyId(string employeeId);
        List<Employee> SaveEmployee(Employee employee);
        List<Employee> DeleteEmployeeById(string eid);
        List<Employee> UpdateEmployee(string eid, Employee employee);
    }
}
