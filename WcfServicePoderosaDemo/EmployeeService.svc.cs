using System;
using System.Collections.Generic;
using WcfServicePoderosa.Contracts.Contracts;

namespace WcfServicePoderosaDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {

        public void DoWork()
        {
        }

        public List<EmployeeContract> GetAllEmployes()
        {
            throw new NotImplementedException();
        }

        public void CreateEmployee(EmployeeContract employeeContract)
        {
            throw new NotImplementedException();
        }
    }
}
