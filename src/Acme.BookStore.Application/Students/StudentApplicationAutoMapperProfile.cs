using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Acme.BookStore.Notices;
using Acme.BookStore.Students;
using AutoMapper;

namespace Acme.BookStore
{
    public class StudentApplicationAutoMapperProfile : Profile
    {
        public StudentApplicationAutoMapperProfile()
        {

            CreateMap<Student, StudentDto>();
            CreateMap<CreateUpdateStudentDto, Student>();
        }
    }
}

