using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeService.Interfaces.EmployeeService.Interfaces.Data;

namespace EmployeeService.Data
{
    public class EmployeeDBHandler : IEmployee
    {
        public void InsertEmployee(EmployeeModels.EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModels.EmployeeModel> RetrieveEmployee()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(EmployeeModels.EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
