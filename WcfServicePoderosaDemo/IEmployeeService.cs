﻿using System.Collections.Generic;
using System.ServiceModel;
using WcfServicePoderosa.Contracts.Contracts;

namespace WcfServicePoderosaDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [FaultContract(typeof(ErrorInformation))]
        List<EmployeeContract> GetAllEmployes();

        [OperationContract]
        [FaultContract(typeof(ErrorInformation))]
        void CreateEmployee(EmployeeContract employeeContract);
    }

    [ServiceContract]
    public interface IGetResult
    {
        [OperationContract(IsOneWay = true)]
        void GetResult(bool result);
    }    
}
