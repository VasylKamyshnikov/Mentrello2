using System;
using Mentrello.Services.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mentrello.API.Controllers
{
    [Authorize]
    //[AllowAnonymous]
    [ApiController]
    [Route("board")]
    public class BoardController : ControllerBase
    {
        public BoardController()
        {

        }

        [HttpPost]
        [Route("create", Name = "CreateBoard")]
        public IActionResult CreateBoard(BoardDto board)
        {
            //var result = _boardService.CreateBoard(User, board);
            return Ok();
        }

        [HttpGet]
        [Route("all", Name = "GetBoardCollection")]
        public IActionResult GetAll()
        {
            var user = User.Identity;
            return Ok();
        }

        [HttpGet]
        [Route("{id:guid}", Name = "GetBoardById")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpPatch]
        [Route("update/{id:guid}", Name = "UpdateBoard")]
        public IActionResult Update(Guid id)
        {
            
            return Ok($"BOARD # {id} has been updated!");
        }

        [HttpDelete]
        [Route("delete/{id:guid}", Name = "DeleteBoard")]
        public IActionResult Delete(Guid id)
        {
            
            return Ok($"BOARD # {id} has been deleted!");
        }
    }

}
