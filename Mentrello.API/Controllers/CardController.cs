using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Mentrello.API.Controllers
{
    [ApiController]
    [Route("card")]
    public class CardController : ControllerBase
    {
        [HttpPost]
        [Route("create", Name = "CreateCard")]
        public async Task<IActionResult> CreateCard()
        {
            return Ok("New CARD has been created!");
        }

        [HttpGet]
        [Route("all", Name = "GetCardCollection")]
        public async Task<IActionResult> GetAll()
        {
            return Ok("Here is all available CARDs!");
        }

        [HttpGet]
        [Route("{id:guid}", Name = "GetCardById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok($"This is CARD #'{id}'!");
        }

        [HttpPatch]
        [Route("update/{id:guid}", Name = "UpdateCard")]
        public async Task<IActionResult> Update(Guid id)
        {
            return Ok($"CARD # {id} has been updated!");
        }

        [HttpDelete]
        [Route("delete/{id:guid}", Name = "DeleteCard")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok($"CARD # {id} has been deleted!");
        }
    }

}
