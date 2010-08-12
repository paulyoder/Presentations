using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.DomainServices.Server;
using System.ServiceModel.DomainServices.Hosting;

namespace RIAExample.Web
{
    [EnableClientAccess]
    public class EmployeeDomainService : DomainService
    {
        IEmployeeRepository _employeeRepository;

        public EmployeeDomainService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        [Query(ResultLimit=2)]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        [Insert]
        public void AppendEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        [Update]
        public void DoSomethingEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

        [Delete]
        public void RemoveEmployee(Employee employee)
        {
            _employeeRepository.DeleteEmployee(employee);
        }
    }
}