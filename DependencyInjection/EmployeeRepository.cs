using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Hello", Role = "Full-Time" },
                new Employee(){ Id = 2, Name = "World", Role = "Part-Time" }
            };
            return employees;
        }
    }
}
