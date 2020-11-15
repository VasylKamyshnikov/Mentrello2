using Mentrello.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

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
        public async Task<IActionResult> CreateBoard()
        {
            return Ok(await _boardService.CreateBoard());
        }

        [HttpGet]
        [Route("all", Name = "GetBoardCollection")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _boardService.GetAllBoards());
        }

        [HttpGet]
        [Route("{id:guid}", Name = "GetBoardById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _boardService.GetBoardById(id));
        }

        [HttpPatch]
        [Route("update/{id:guid}", Name = "UpdateBoard")]
        public async Task<IActionResult> Update(Guid id)
        {
            await _boardService.UpdateExistingBoard(id);
            return Ok($"BOARD # {id} has been updated!");
        }

        [HttpDelete]
        [Route("delete/{id:guid}", Name = "DeleteBoard")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _boardService.DeleteBoardById(id);
            return Ok($"BOARD # {id} has been deleted!");
        }
    }

}
