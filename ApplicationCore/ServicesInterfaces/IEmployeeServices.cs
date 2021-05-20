using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServicesInterfaces
{
    public interface IEmployeeServices
    {
        Task<List<EmployeeResponseModel>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> RigsterEmployee(EmployeeRegisterRequestModel requestModel);
        Task DeleteEmployee(EmployeeRegisterRequestModel requestModel);
        Task<Employee> UpdateEmployee(EmployeeRegisterRequestModel requestModel);
    }
}
