using Employees.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.WebAPI.Controllers
{
    public class EmployeesController : Controller
    {
        public IEmployeeDataService employeeDS;

        public EmployeesController(IEmployeeDataService _empDs)
        {
            this.employeeDS = _empDs;
        }
        [HttpGet]
        [Route("api/employees/getallemployees")]
        public ActionResult GetAllEmployees()
        {
            EmployeesResponse employeersp;
            try
            {
                var employees = this.employeeDS.GetAllEmployees();
                if (employees == null)
                {
                    employeersp = new EmployeesResponse()
                    {

                    };
                }
              
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }
    }
}