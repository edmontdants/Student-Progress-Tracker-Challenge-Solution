using AutoMapper;
using MediatR;
using StudentProgress.Application.Interfaces;
using StudentProgress.Domain.Entities;

namespace StudentProgress.Application.Commands
{
    public class AddStudentProgressCommandHandler : IRequestHandler<AddStudentProgressCommand, Unit>
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;

        public AddStudentProgressCommandHandler(IStudentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(AddStudentProgressCommand request, CancellationToken cancellationToken)
        {
            var progress = _mapper.Map<Progress>(request.Progress);
            progress.Id = Guid.NewGuid();
            progress.StudentId = request.StudentId;

            await _repo.AddProgressAsync(progress);
            await _repo.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
