namespace StudentProgress.Domain.Entities
{
    public class Progress
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public double CompletionPercentage { get; set; }
        public double Score { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public int AssignmentCompleted { get; set; }
        public double AssessmentScore { get; set; }
        public DateTime LastActivity { get; set; }

        public Student? Student { get; set; }
    }
}
