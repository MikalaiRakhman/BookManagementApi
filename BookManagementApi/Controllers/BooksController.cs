﻿using BookManagement.DataAccess.Operations.BooksOperations.AddBooks;
using BookManagement.DataAccess.Operations.BooksOperations.CreateBook;
using BookManagement.DataAccess.Operations.BooksOperations.GetBookDetails;
using BookManagement.DataAccess.Operations.BooksOperations.GetPaginatedBooks;
using BookManagement.DataAccess.Operations.BooksOperations.SoftDeletingBulkBooks;
using BookManagement.DataAccess.Operations.BooksOperations.SoftDeletingSingleBook;
using BookManagement.DataAccess.Operations.BooksOperations.UpdateBook;
using BookManagement.DataAccess.Operations.Services;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _mediator.Send(command);

            return Ok();
        }

        [HttpPost("add-books")]
        public async Task<IActionResult> AddBooks([FromBody] AddBooksCommand command)
        {
            if(command.Books == null || command.Books.Count == 0)
            {
                return BadRequest("Books list cannot be null or empty");
            }

            if (!BookService.ValidateBookDTOModel(command.Books, out var validationResults))
            {
                return BadRequest(validationResults);
            }

            await _mediator.Send(command);

            return Ok();
        }

        [HttpPut("update-book")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBookCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _mediator.Send(command);

            return Ok();
        }

        [HttpPut("soft-delete-book")]
        public async Task<IActionResult> SoftDeleteBook([FromBody] SoftDeletingSingleBookCommand command)
        {
            try
            {
                await _mediator.Send(command);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("soft-delete-books")]
        public async Task<IActionResult> SoftDeleteBooks([FromBody] SoftDeletingBulkBooksCommand command)
        {
            try
            {
                await _mediator.Send(command);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("get-paginated-books")]
        public async Task<IActionResult> GetPaginatedBooks([FromQuery] GetPaginatedBooksQuerry querry)
        {
            var result = await _mediator.Send(querry);

            return Ok(result);
        }

        [HttpGet("get-book-details")]
        public async Task<IActionResult> GetBookDetails([FromQuery] GetBookDetailsQuerry querry)
        {
            var result = await _mediator.Send(querry);

            return Ok(result);
        }
    }
}