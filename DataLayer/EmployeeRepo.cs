using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    //Repository to implement DB logic
    public class EmployeeRepo : IEmployee
    {
        List<Employee> lstEmployees = new List<Employee>() {
            new Employee() { empId=1,firstName = "John", lastName = "Scott", salary = 5000 },
            new Employee() { empId=2, firstName = "Winson", lastName = "James", salary = 5000 }
        };
        /// <summary>
        /// To retrieve the employee details by id
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public Employee GetEmployee(int empId)
        {
            return lstEmployees.Where(x => x.empId == empId).FirstOrDefault();
        }

        /// <summary>
        /// To retrieve all the employee's
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployeeList()
        {
            return lstEmployees.ToList();
        }
    }
}
