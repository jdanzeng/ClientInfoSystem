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
    public class InteractionsController : ControllerBase
    {
        private readonly IInteractionServices _interactionServices;

        public InteractionsController(IInteractionServices interactionServices)
        {
            _interactionServices = interactionServices;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllInteractions()
        {
            var interactions = await _interactionServices.GetAllInteractions();
            if (interactions.Any())
            {
                return Ok(interactions);
            }
            return NotFound("Not Found");
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetInteraction")]
        public async Task<ActionResult> GetInteractionById(int id)
        {
            var interaction = await _interactionServices.GetInteractionById(id);
            return Ok(interaction);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> RigsterInteractionAsync(InteractionRegisterRequestModel requestModel)
        {
            var createdInteraction = await _interactionServices.RigsterInteraction(requestModel);
            return CreatedAtRoute("GetInteraction", new { id = createdInteraction.Id }, createdInteraction);
        }



    }
}
