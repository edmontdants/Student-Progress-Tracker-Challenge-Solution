using StudentProgress.Application.DTOs;

namespace StudentProgress.Application.Services
{

    public interface IStudentService
    {
        Task<(IEnumerable<StudentDto> Students, int TotalCount)> GetAllAsync(
            string? grade, string? subject, string? searchTerm,
            DateTime? dateFrom, DateTime? dateTo,
            int page, int pageSize, string? sortBy);

        Task<StudentDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<ProgressDto>> GetProgressAsync(Guid studentId);
        Task AddProgressAsync(Guid studentId, ProgressCreateDto dto);
    }
}
