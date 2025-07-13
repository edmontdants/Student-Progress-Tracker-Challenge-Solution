using AutoMapper;
using MediatR;
using StudentProgress.Application.DTOs;
using StudentProgress.Application.Interfaces;

namespace StudentProgress.Application.Queries
{
    public class GetAllStudentsQueryHandler : IRequestHandler<GetAllStudentsQuery, (IEnumerable<StudentDto>, int)>
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;

        public GetAllStudentsQueryHandler(IStudentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<(IEnumerable<StudentDto>, int)> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await _repo.GetAllAsync(
                request.Grade, request.Subject, request.SearchTerm,
                request.DateFrom, request.DateTo,
                request.Page, request.PageSize, request.SortBy);

            var total = await _repo.GetTotalCountAsync(
                request.Grade, request.Subject, request.SearchTerm,
                request.DateFrom, request.DateTo);

            return (_mapper.Map<IEnumerable<StudentDto>>(students), total);
        }
    }
}
