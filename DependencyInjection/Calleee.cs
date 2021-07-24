using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Calleee 
    {
        IEmployeeRepository employeeRepository;
        public Calleee(IEmployeeRepository employee)
        {
            employeeRepository = employee;
        }
        public List<Employee> GetRecords()
        {
            List <Employee> employees = employeeRepository.GetEmployees();
            return employees;
        }
    }
}