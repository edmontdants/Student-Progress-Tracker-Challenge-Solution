using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentProgress.Application.Commands;
using StudentProgress.Application.DTOs;
using StudentProgress.Application.Queries;

namespace StudentProgress.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAll(
            [FromQuery] string? grade,
            [FromQuery] string? subject,
            [FromQuery] string? searchTerm,
            [FromQuery] DateTime? dateFrom,
            [FromQuery] DateTime? dateTo,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? sortBy = "name")
        {
            var query = new GetAllStudentsQuery(grade, subject, searchTerm, dateFrom, dateTo, page, pageSize, sortBy);
            var result = await _mediator.Send(query);
            return Ok(new { data = result.Students, total = result.TotalCount });
        }

        [HttpPost("{id}/progress")]
        public async Task<IActionResult> AddProgress(Guid id, [FromBody] ProgressCreateDto dto)
        {
            await _mediator.Send(new AddStudentProgressCommand(id, dto));
            return NoContent();
        }
    }
}
