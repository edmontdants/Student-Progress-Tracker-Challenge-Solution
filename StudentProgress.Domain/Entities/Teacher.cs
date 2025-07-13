namespace StudentProgress.Domain.Entities
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public List<Student> AssignedStudents { get; set; } = new();
    }
}
