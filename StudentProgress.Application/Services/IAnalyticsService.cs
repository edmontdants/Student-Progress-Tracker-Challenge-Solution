using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgress.Application.Services
{
    public interface IAnalyticsService
    {
        Task<object> GetClassSummaryAsync();
        Task<IEnumerable<object>> GetProgressTrendsAsync();
        Task<byte[]> ExportStudentsCsvAsync();
    }
}
