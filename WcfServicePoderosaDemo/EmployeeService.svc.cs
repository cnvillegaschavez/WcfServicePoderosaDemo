using System;
using System.Collections.Generic;
using WcfServicePoderosa.Contracts.Contracts;
using System.Linq;
using System.ServiceModel;

namespace WcfServicePoderosaDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public void CreateEmployee(EmployeeInfo employeeInfo)
        {
            throw new NotImplementedException();
        }

        public EmployeeInfo GetEmployee(EmployeeRequest employeeRequest)
        {
            var employee = GetAllEmployees().FirstOrDefault(e => e.EmployeeId == employeeRequest.EmployeeId);
            if (employee == null)
            {
                throw new FaultException<ErrorInformation>(new ErrorInformation($"No existe un registro del " +
                    $"empleado con el Id {employeeRequest.EmployeeId}", MessageType.Error));
            }
            return new EmployeeInfo(employee);
        }

        private List<Employee> GetAllEmployees()
        {
            var emplpoyees = new List<Employee> {
                new Employee { EmployeeId= 1, Name = "Oscar", Address="Av." },
                new Employee { EmployeeId= 2 , Name = "Cristian", Address="Av." },
                new Employee { EmployeeId = 3, Name = "Reynaldo", Address="Av." },
            };
            return emplpoyees;
        }
    }
}
