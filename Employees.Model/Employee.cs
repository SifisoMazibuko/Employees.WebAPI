using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string ContactNumber { get; set; }
        public string MailID { get; set; }
        public string Designation { get; set; }
        public string SkillSet { get; set; }
        public string ReportingPerson { get; set; }
        public bool IsSupervisor { get; set; }
    }
}
