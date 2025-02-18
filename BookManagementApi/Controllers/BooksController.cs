using BookManagement.DataAccess.Operations.BooksOperations.AddBooks;
using BookManagement.DataAccess.Operations.BooksOperations.CreateBook;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create-book")]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }

        [HttpPost("add-books")]
        public async Task<IActionResult> AddBooks([FromBody] AddBooksCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
    }
}
