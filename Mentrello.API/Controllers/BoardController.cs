using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Mentrello.API.Controllers
{
    [ApiController]
    [Route("board")]
    public class BoardController : ControllerBase
    {
        [HttpPost]
        [Route("create", Name = "CreateBoard")]
        public async Task<IActionResult> CreateBoard()
        {
            return Ok("New BOARD has been created!");
        }

        [HttpGet]
        [Route("all", Name = "GetBoardCollection")]
        public async Task<IActionResult> GetAll()
        {
            return Ok("Here is all available BOARDs!");
        }

        [HttpGet]
        [Route("{id:guid}", Name = "GetBoardById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok($"This is BOARD #'{id}'!");
        }

        [HttpPatch]
        [Route("update/{id:guid}", Name = "UpdateBoard")]
        public async Task<IActionResult> Update(Guid id)
        {
            return Ok($"BOARD # {id} has been updated!");
        }

        [HttpDelete]
        [Route("delete/{id:guid}", Name = "DeleteBoard")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok($"BOARD # {id} has been deleted!");
        }
    }

}
