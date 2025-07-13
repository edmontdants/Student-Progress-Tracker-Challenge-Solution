using Microsoft.EntityFrameworkCore;
using StudentProgress.Application.Interfaces;
using StudentProgress.Domain.Entities;
using StudentProgress.Infrastructure.Data;

namespace StudentProgress.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Student>> GetAllAsync(
            string? grade, string? subject, string? searchTerm,
            DateTime? dateFrom, DateTime? dateTo,
            int page, int pageSize, string? sortBy)
        {
            var query = _context.Students
                .Include(s => s.ProgressRecords)
                .AsQueryable();

            if (!string.IsNullOrEmpty(grade))
                query = query.Where(s => s.Grade == grade);

            if (!string.IsNullOrEmpty(searchTerm))
                query = query.Where(s => s.FullName.Contains(searchTerm));

            if (!string.IsNullOrEmpty(subject))
                query = query.Where(s => s.ProgressRecords.Any(p => p.Subject == subject));

            if (dateFrom.HasValue)
                query = query.Where(s => s.ProgressRecords.Any(p => p.LastActivity >= dateFrom.Value));

            if (dateTo.HasValue)
                query = query.Where(s => s.ProgressRecords.Any(p => p.LastActivity <= dateTo.Value));

            // Sorting
            query = sortBy switch
            {
                "name" => query.OrderBy(s => s.FullName),
                "progress" => query.OrderByDescending(s => s.ProgressRecords.Average(p => p.CompletionPercentage)),
                "lastActivity" => query.OrderByDescending(s => s.ProgressRecords.Max(p => p.LastActivity)),
                _ => query.OrderBy(s => s.FullName)
            };

            // Pagination
            return await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalCountAsync(
            string? grade, string? subject, string? searchTerm,
            DateTime? dateFrom, DateTime? dateTo)
        {
            var query = _context.Students.AsQueryable();

            if (!string.IsNullOrEmpty(grade))
                query = query.Where(s => s.Grade == grade);

            if (!string.IsNullOrEmpty(searchTerm))
                query = query.Where(s => s.FullName.Contains(searchTerm));

            if (!string.IsNullOrEmpty(subject))
                query = query.Where(s => s.ProgressRecords.Any(p => p.Subject == subject));

            if (dateFrom.HasValue)
                query = query.Where(s => s.ProgressRecords.Any(p => p.LastActivity >= dateFrom.Value));

            if (dateTo.HasValue)
                query = query.Where(s => s.ProgressRecords.Any(p => p.LastActivity <= dateTo.Value));

            return await query.CountAsync();
        }

        public Task<Student?> GetByIdAsync(Guid id)
            => _context.Students.Include(s => s.ProgressRecords)
                .FirstOrDefaultAsync(s => s.Id == id);

        public Task<IEnumerable<Progress>> GetProgressByStudentIdAsync(Guid studentId)
            => Task.FromResult<IEnumerable<Progress>>(
                _context.ProgressRecords.Where(p => p.StudentId == studentId));

        public async Task AddProgressAsync(Progress progress)
            => await _context.ProgressRecords.AddAsync(progress);

        public Task SaveChangesAsync()
            => _context.SaveChangesAsync();
    }
}
