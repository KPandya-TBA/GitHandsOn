using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Interfaces.EmployeeService.Interfaces.Data
{
    public interface IEmployee
    {
        /// <summary>
        /// Inserts Employee.
        /// </summary>
        void InsertEmployee();

        /// <summary>
        /// Retrieve Employees.
        /// </summary>
        /// <returns></returns>
        DataTable RetrieveEmployee();

        void UpdateEmployee ()
    }
}
