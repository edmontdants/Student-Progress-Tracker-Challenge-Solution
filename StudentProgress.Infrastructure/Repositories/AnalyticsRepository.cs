using StudentProgress.Application.Interfaces;
using StudentProgress.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace StudentProgress.Infrastructure.Repositories
{
    public class AnalyticsRepository : IAnalyticsRepository
    {
        private readonly AppDbContext _context;

        public AnalyticsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetTotalStudentsAsync()
            => await _context.Students.CountAsync();

        public async Task<double> GetAverageCompletionAsync()
            => await _context.ProgressRecords.AverageAsync(p => p.CompletionPercentage);

        public async Task<DateTime> GetLatestActivityAsync()
            => await _context.ProgressRecords.MaxAsync(p => p.LastActivity);

        public async Task<IEnumerable<(DateTime Date, double AvgScore)>> GetProgressTrendsAsync()
        {
            return await _context.ProgressRecords
                .GroupBy(p => p.LastActivity.Date)
                .Select(g => new ValueTuple<DateTime, double>(g.Key, g.Average(p => p.Score)))
                .ToListAsync();
        }

        public async Task<IEnumerable<(Guid Id, string FullName, string Grade, DateTime DateOfBirth)>> GetAllStudentsAsync()
        {
            return await _context.Students
                .Select(s => new ValueTuple<Guid, string, string, DateTime>(
                    s.Id, s.FullName, s.Grade, s.DateOfBirth))
                .ToListAsync();
        }
    }
}
