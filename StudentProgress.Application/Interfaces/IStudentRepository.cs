using StudentProgress.Domain.Entities;

namespace StudentProgress.Application.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllAsync(
            string? grade, string? subject, string? searchTerm,
            DateTime? dateFrom, DateTime? dateTo,
            int page, int pageSize, string? sortBy);

        Task<int> GetTotalCountAsync(
            string? grade, string? subject, string? searchTerm,
            DateTime? dateFrom, DateTime? dateTo);

        Task<Student?> GetByIdAsync(Guid id);
        Task<IEnumerable<Progress>> GetProgressByStudentIdAsync(Guid studentId);
        Task AddProgressAsync(Progress progress);
        Task SaveChangesAsync();
    }
}
