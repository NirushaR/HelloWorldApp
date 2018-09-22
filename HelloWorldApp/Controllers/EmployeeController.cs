using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldApp.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployee _employeeRepo = null;
        public EmployeeController()
        {
            this._employeeRepo = new EmployeeRepo();
        }

        /// <summary>
        /// API to get all the list of employees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetAllEmployees")]
        public IEnumerable<Employee> GetAllEmployees()
        {           
            return _employeeRepo.GetEmployeeList();
        }


        /// <summary>
        /// API which exposes individual data of the employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/GetEmployee")]
        public Employee GetEmployee(int id)
        {
            return _employeeRepo.GetEmployee(id);
        }        
    }
}
