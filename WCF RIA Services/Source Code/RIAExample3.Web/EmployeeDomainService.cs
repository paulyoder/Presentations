using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.DomainServices.Server;
using System.ServiceModel.DomainServices.Hosting;

namespace RIAExample3.Web
{
    [EnableClientAccess]
    public class EmployeeDomainService : DomainService
    {

        IEmployeeRepository _employeeRepository;

        public EmployeeDomainService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public void AppendEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public void ModifyEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _employeeRepository.DeleteEmployee(employee);
        }

    }
}
