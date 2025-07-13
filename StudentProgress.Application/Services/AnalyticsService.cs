using StudentProgress.Application.Interfaces;
using System.Text;

namespace StudentProgress.Application.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        private readonly IAnalyticsRepository _repo;

        public AnalyticsService(IAnalyticsRepository repo)
        {
            _repo = repo;
        }

        public async Task<object> GetClassSummaryAsync()
        {
            var totalStudents = await _repo.GetTotalStudentsAsync();
            var avgCompletion = await _repo.GetAverageCompletionAsync();
            var latestActivity = await _repo.GetLatestActivityAsync();

            return new
            {
                totalStudents,
                averageCompletion = avgCompletion,
                latestActivity
            };
        }

        public async Task<IEnumerable<object>> GetProgressTrendsAsync()
        {
            var trends = await _repo.GetProgressTrendsAsync();

            return trends.Select(t => new
            {
                Date = t.Date,
                AvgScore = t.AvgScore
            });
        }

        public async Task<byte[]> ExportStudentsCsvAsync()
        {
            var students = await _repo.GetAllStudentsAsync();

            var sb = new StringBuilder();
            sb.AppendLine("Id,FullName,Grade,DateOfBirth");

            foreach (var s in students)
            {
                sb.AppendLine($"{s.Id},{s.FullName},{s.Grade},{s.DateOfBirth:yyyy-MM-dd}");
            }

            return Encoding.UTF8.GetBytes(sb.ToString());
        }
    }
}
