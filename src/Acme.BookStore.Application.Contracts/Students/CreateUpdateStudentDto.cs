using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Students
{
    public class CreateUpdateStudentDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(StudentConsts.MaxNameLength)]
        public string Name { get; set; }
        [Required]
        [StringLength(StudentConsts.MaxDescribeLength)]
        public string Description { get; set; }
        public int StudentId { get; set; }
    }
}
