using Microsoft.AspNetCore.Mvc;
using StudentProgress.Application.Services;
using StudentProgress.Infrastructure.Data;
using System.Text;

namespace StudentProgress.API.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class AnalyticsController : ControllerBase
    {
        private readonly IAnalyticsService _service;

        public AnalyticsController(IAnalyticsService service)
        {
            _service = service;
        }

        [HttpGet("class-summary")]
        public async Task<IActionResult> ClassSummary()
        {
            var summary = await _service.GetClassSummaryAsync();
            return Ok(summary);
        }

        [HttpGet("progress-trends")]
        public async Task<IActionResult> ProgressTrends()
        {
            var trends = await _service.GetProgressTrendsAsync();
            return Ok(trends);
        }

        [HttpGet("/api/reports/student-export")]
        public async Task<IActionResult> ExportStudents()
        {
            var csvBytes = await _service.ExportStudentsCsvAsync();
            return File(csvBytes, "text/csv", "students.csv");
        }
    }
}
