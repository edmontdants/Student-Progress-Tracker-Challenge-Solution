using MediatR;
using StudentProgress.Application.DTOs;

namespace StudentProgress.Application.Commands
{
    public record AddStudentProgressCommand(
        Guid StudentId,
        ProgressCreateDto Progress) : IRequest<Unit>;
}
