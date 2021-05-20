using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientInfoSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientServices _clientServices;
        public ClientsController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _clientServices.GetAllClients();
            if (clients.Any())
            {
                return Ok(clients);
            }
            return NotFound("Not Found");
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> GetClientById(int id)
        {
            var client = await _clientServices.GetClientById(id);
            return Ok(client);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteClient(ClientRegisterRequestModel requestModel)
        {
            await _clientServices.DeleteClient(requestModel);
            return NoContent();
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateClient(ClientRegisterRequestModel requestModel)
        {
            await _clientServices.UpdateClient(requestModel);
            return Ok();

        }




    }
}
