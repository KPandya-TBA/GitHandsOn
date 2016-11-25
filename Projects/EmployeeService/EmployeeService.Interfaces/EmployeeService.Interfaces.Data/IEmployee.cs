using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeModels;
namespace EmployeeService.Interfaces.EmployeeService.Interfaces.Data
{
    public interface IEmployee
    {
        /// <summary>
        /// Inserts Employee.
        /// </summary>
        void InsertEmployee(EmployeeModel employee);

        /// <summary>
        /// Retrieve Employees.
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeModel> RetrieveEmployee();

        /// <summary>
        /// Updates Employee.
        /// </summary>
        /// <param name="employee"></param>
        void UpdateEmployee(EmployeeModel employee);

        /// <summary>
        /// Deletes Employee.
        /// </summary>
        /// <param name="employee"></param>
        void DeleteEmployee(int id);
    }
}
