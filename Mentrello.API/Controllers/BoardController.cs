using System;
using Mentrello.Services.Dto;
using Mentrello.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mentrello.API.Controllers
{
    [ApiController]
    [Route("board")]
    public class BoardController : ControllerBase
    {
        private readonly IBoardOwnerService _boardOwnerService;
        private readonly IAssigneeService _assigneeService;
        public BoardController(IBoardOwnerService boardOwnerService, IAssigneeService assigneeService)
        {
            _boardOwnerService = boardOwnerService;
            _assigneeService = assigneeService;
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
