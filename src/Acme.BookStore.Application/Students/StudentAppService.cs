using Acme.BookStore.Notices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Students
{
    public class StudentAppService : CrudAppService<
            Student,
            StudentDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateStudentDto>, IStudentAppService
    {
        public StudentAppService(IRepository<Student, Guid> repository) : base(repository)
        {

        }
    }
}
