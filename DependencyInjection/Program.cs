using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Calleee calleee = new Calleee(new EmployeeRepository());

            IEnumerable<Employee> employees = calleee.GetRecords();
            foreach (Employee emp in employees)
            {
                Console.WriteLine("ID : {0}, NAME: {1}, ROLE: {2}", emp.Id, emp.Name, emp.Role);
            }
            Console.ReadLine();
        }
    }
}
