using Microsoft.EntityFrameworkCore;
using StudentProgress.Domain.Entities;

namespace StudentProgress.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Progress> ProgressRecords => Set<Progress>();
        public DbSet<Teacher> Teachers => Set<Teacher>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relations
            modelBuilder.Entity<Student>()
                .HasMany(s => s.ProgressRecords)
                .WithOne(p => p.Student)
                .HasForeignKey(p => p.StudentId);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.AssignedStudents)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull); // optional

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var teacherId = Guid.NewGuid();
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = teacherId,
                    FullName = "Emily Johnson"
                }
            );

            var students = new List<Student>
            {
                new Student { Id = Guid.NewGuid(), FullName = "Aiden Carter", Grade = "K", DateOfBirth = new DateTime(2019, 4, 12) },
                new Student { Id = Guid.NewGuid(), FullName = "Bella Chen", Grade = "1", DateOfBirth = new DateTime(2018, 5, 22) },
                new Student { Id = Guid.NewGuid(), FullName = "Caleb Davis", Grade = "2", DateOfBirth = new DateTime(2017, 2, 15) },
                new Student { Id = Guid.NewGuid(), FullName = "Diana Evans", Grade = "3", DateOfBirth = new DateTime(2016, 8, 5) },
                new Student { Id = Guid.NewGuid(), FullName = "Ethan Flores", Grade = "4", DateOfBirth = new DateTime(2015, 3, 30) },
                new Student { Id = Guid.NewGuid(), FullName = "Fiona Gomez", Grade = "5", DateOfBirth = new DateTime(2014, 1, 10) },
                new Student { Id = Guid.NewGuid(), FullName = "Gabriel Harris", Grade = "6", DateOfBirth = new DateTime(2013, 7, 25) },
                new Student { Id = Guid.NewGuid(), FullName = "Hannah Ibrahim", Grade = "7", DateOfBirth = new DateTime(2012, 11, 18) },
                new Student { Id = Guid.NewGuid(), FullName = "Ian Jackson", Grade = "8", DateOfBirth = new DateTime(2011, 4, 2) },
                new Student { Id = Guid.NewGuid(), FullName = "Jasmine Kim", Grade = "9", DateOfBirth = new DateTime(2010, 6, 13) },
                new Student { Id = Guid.NewGuid(), FullName = "Kai Lee", Grade = "10", DateOfBirth = new DateTime(2009, 12, 21) },
                new Student { Id = Guid.NewGuid(), FullName = "Liam Martinez", Grade = "11", DateOfBirth = new DateTime(2008, 8, 7) },
                new Student { Id = Guid.NewGuid(), FullName = "Mia Nguyen", Grade = "12", DateOfBirth = new DateTime(2007, 5, 19) },
                new Student { Id = Guid.NewGuid(), FullName = "Noah Patel", Grade = "5", DateOfBirth = new DateTime(2014, 10, 1) },
                new Student { Id = Guid.NewGuid(), FullName = "Olivia Quinn", Grade = "7", DateOfBirth = new DateTime(2012, 9, 3) },
                new Student { Id = Guid.NewGuid(), FullName = "Parker Rivera", Grade = "2", DateOfBirth = new DateTime(2017, 6, 8) },
                new Student { Id = Guid.NewGuid(), FullName = "Quinn Smith", Grade = "8", DateOfBirth = new DateTime(2011, 2, 27) },
                new Student { Id = Guid.NewGuid(), FullName = "Riley Thompson", Grade = "9", DateOfBirth = new DateTime(2010, 11, 14) },
                new Student { Id = Guid.NewGuid(), FullName = "Sophia Upton", Grade = "10", DateOfBirth = new DateTime(2009, 7, 29) },
                new Student { Id = Guid.NewGuid(), FullName = "Tyler Vasquez", Grade = "11", DateOfBirth = new DateTime(2008, 3, 6) }
            };
            modelBuilder.Entity<Student>().HasData(students);

            var progressRecords = new List<Progress>
            {
                new Progress { Id = Guid.NewGuid(), StudentId = students[0].Id, Subject = "Math", CompletionPercentage = 65, Score = 68, TimeSpent = TimeSpan.FromHours(4), AssignmentCompleted = 3, AssessmentScore = 60, LastActivity = DateTime.UtcNow.AddDays(-1) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[1].Id, Subject = "Reading", CompletionPercentage = 80, Score = 85, TimeSpent = TimeSpan.FromHours(10), AssignmentCompleted = 4, AssessmentScore = 88, LastActivity = DateTime.UtcNow.AddDays(-5) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[2].Id, Subject = "Science", CompletionPercentage = 95, Score = 93, TimeSpent = TimeSpan.FromHours(12), AssignmentCompleted = 5, AssessmentScore = 95, LastActivity = DateTime.UtcNow.AddDays(-3) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[3].Id, Subject = "Social Studies", CompletionPercentage = 50, Score = 55, TimeSpent = TimeSpan.FromHours(3), AssignmentCompleted = 2, AssessmentScore = 52, LastActivity = DateTime.UtcNow.AddDays(-30) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[4].Id, Subject = "Math", CompletionPercentage = 70, Score = 72, TimeSpent = TimeSpan.FromHours(6), AssignmentCompleted = 3, AssessmentScore = 68, LastActivity = DateTime.UtcNow.AddDays(-10) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[5].Id, Subject = "Reading", CompletionPercentage = 88, Score = 90, TimeSpent = TimeSpan.FromHours(9), AssignmentCompleted = 4, AssessmentScore = 85, LastActivity = DateTime.UtcNow.AddDays(-2) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[6].Id, Subject = "Science", CompletionPercentage = 92, Score = 94, TimeSpent = TimeSpan.FromHours(11), AssignmentCompleted = 5, AssessmentScore = 91, LastActivity = DateTime.UtcNow.AddDays(-1) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[7].Id, Subject = "Social Studies", CompletionPercentage = 40, Score = 45, TimeSpent = TimeSpan.FromHours(2), AssignmentCompleted = 1, AssessmentScore = 42, LastActivity = DateTime.UtcNow.AddDays(-45) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[8].Id, Subject = "Math", CompletionPercentage = 78, Score = 80, TimeSpent = TimeSpan.FromHours(8), AssignmentCompleted = 3, AssessmentScore = 75, LastActivity = DateTime.UtcNow.AddDays(-4) },
                new Progress { Id = Guid.NewGuid(), StudentId = students[9].Id, Subject = "Reading", CompletionPercentage = 85, Score = 88, TimeSpent = TimeSpan.FromHours(10), AssignmentCompleted = 4, AssessmentScore = 83, LastActivity = DateTime.UtcNow.AddDays(-6) }
            };
            modelBuilder.Entity<Progress>().HasData(progressRecords);
        }
    }
}
