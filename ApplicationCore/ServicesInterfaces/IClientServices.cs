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
    public interface IClientServices
    {
        Task<List<ClientResponseModel>> GetAllClients();
        Task<Client> GetClientById(int id);
        
        Task DeleteClient(ClientRegisterRequestModel requestModel);
        Task<Client> UpdateClient(ClientRegisterRequestModel requestModel);
    }
}
