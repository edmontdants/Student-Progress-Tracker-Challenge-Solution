using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgress.Application.Interfaces
{
    public interface IAnalyticsRepository
    {
        Task<int> GetTotalStudentsAsync();
        Task<double> GetAverageCompletionAsync();
        Task<DateTime> GetLatestActivityAsync();
        Task<IEnumerable<(DateTime Date, double AvgScore)>> GetProgressTrendsAsync();
        Task<IEnumerable<(Guid Id, string FullName, string Grade, DateTime DateOfBirth)>> GetAllStudentsAsync();
    }
}
