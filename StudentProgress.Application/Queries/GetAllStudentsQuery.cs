using MediatR;
using StudentProgress.Application.DTOs;

namespace StudentProgress.Application.Queries
{
    public record GetAllStudentsQuery(
    string? Grade,
    string? Subject,
    string? SearchTerm,
    DateTime? DateFrom,
    DateTime? DateTo,
    int Page,
    int PageSize,
    string? SortBy) : IRequest<(IEnumerable<StudentDto> Students, int TotalCount)>;
}
