using System;
using Mentrello.Services.Interfaces;
using Mentrello.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentrello.API.Controllers
{
    [ApiController]
    [Route("board")]
    public class BoardController : ControllerBase
    {
        private readonly IBoardService _boardService;
        public BoardController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpPost]
        [Route("create", Name = "CreateBoard")]
        public IActionResult CreateBoard(BoardModel board)
        {
            var result = _boardService.CreateBoard(User, board);
            return Ok(result);
        }

        [HttpGet]
        [Route("all", Name = "GetBoardCollection")]
        public IActionResult GetAll()
        {
            return Ok(_boardService.GetAllBoards(User));
        }

        [HttpGet]
        [Route("{id:guid}", Name = "GetBoardById")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_boardService.GetBoardById(User, id));
        }

        [HttpPatch]
        [Route("update/{id:guid}", Name = "UpdateBoard")]
        public IActionResult Update(Guid id)
        {
            _boardService.UpdateExistingBoard(User, id);
            return Ok($"BOARD # {id} has been updated!");
        }

        [HttpDelete]
        [Route("delete/{id:guid}", Name = "DeleteBoard")]
        public IActionResult Delete(Guid id)
        {
            _boardService.DeleteBoardById(User, id);
            return Ok($"BOARD # {id} has been deleted!");
        }
    }

}
