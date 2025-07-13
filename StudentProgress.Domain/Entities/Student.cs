namespace StudentProgress.Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Grade { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public List<Progress> ProgressRecords { get; set; } = new();
    }
}
