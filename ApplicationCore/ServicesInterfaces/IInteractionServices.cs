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
    public interface IInteractionServices
    {
        Task<List<InteractionResponseModel>> GetAllInteractions();
        Task<Interaction> GetInteractionById(int id);
        Task DeleteInteraction(InteractionRegisterRequestModel requestModel);
        Task<Interaction> UpdateInteraction(InteractionRegisterRequestModel requestModel);
        Task<Interaction> RigsterInteraction(InteractionRegisterRequestModel requestModel);
    }
}
