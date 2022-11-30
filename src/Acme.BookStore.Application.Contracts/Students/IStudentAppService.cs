using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Students
{
    public interface IStudentAppService:
        ICrudAppService< //Defines CRUD methods
            StudentDto, //Used to show books
            Guid, //Primary key of the notice entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStudentDto> //Used to create/update a notice
    {
    }
}
