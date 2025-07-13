using AutoMapper;
using StudentProgress.Application.DTOs;
using StudentProgress.Application.Interfaces;
using StudentProgress.Domain.Entities;

namespace StudentProgress.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<(IEnumerable<StudentDto> Students, int TotalCount)> GetAllAsync(
            string? grade, string? subject, string? searchTerm,
            DateTime? dateFrom, DateTime? dateTo,
            int page, int pageSize, string? sortBy)
        {
            var students = await _repo.GetAllAsync(grade, subject, searchTerm, dateFrom, dateTo, page, pageSize, sortBy);
            var total = await _repo.GetTotalCountAsync(grade, subject, searchTerm, dateFrom, dateTo);
            return (_mapper.Map<IEnumerable<StudentDto>>(students), total);
        }

        public async Task<StudentDto?> GetByIdAsync(Guid id)
        {
            var student = await _repo.GetByIdAsync(id);
            return student == null ? null : _mapper.Map<StudentDto>(student);
        }

        public async Task<IEnumerable<ProgressDto>> GetProgressAsync(Guid studentId)
        {
            var progress = await _repo.GetProgressByStudentIdAsync(studentId);
            return _mapper.Map<IEnumerable<ProgressDto>>(progress);
        }

        public async Task AddProgressAsync(Guid studentId, ProgressCreateDto dto)
        {
            var progress = _mapper.Map<Progress>(dto);
            progress.Id = Guid.NewGuid();
            progress.StudentId = studentId;
            await _repo.AddProgressAsync(progress);
            await _repo.SaveChangesAsync();
        }
    }
}
