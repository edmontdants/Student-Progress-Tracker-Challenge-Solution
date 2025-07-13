using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgress.Application.DTOs
{
    public class ProgressCreateDto
    {
        public string Subject { get; set; } = string.Empty;
        public double CompletionPercentage { get; set; }
        public double Score { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public int AssignmentCompleted { get; set; }
        public double AssessmentScore { get; set; }
        public DateTime LastActivity { get; set; }
    }
}
