using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
namespace VogCodeChallenge.API
{
    public class EmployeeList : IEnumerable
    {
        List<Employee> employees;
        /*If we connected to database 
        instead of creating a list here, 
        we apply the required database operations. Like "INSERT INTO [employees](Name) VALUES (Batuhan)"
        */
        public EmployeeList()
        {
            employees = new List<Employee>();

        }

        public void Add(Employee employee)
        {
            employees.Add(employee);

        }

        public IEnumerator GetEnumerator()
        {
            yield return new EmployeeEnumerator();
        }
    }
    public class EmployeeEnumerator : IEnumerable
    {
        List<Employee> employees;

        public EmployeeEnumerator()
        {
        }

        public EmployeeEnumerator(List<Employee> employelist)
        {
            employees = employelist;

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
