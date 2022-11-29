using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Notices
{
    public class NoticeAppService : CrudAppService<
            Notice, 
            NoticeDto,
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateNoticeDto>, INoticeAppService
    {

        public NoticeAppService(IRepository<Notice, Guid> repository) : base(repository)
        {
            
        }

        public async Task<bool> PostReadNotice(Guid noticeId)
        {
            throw new NotImplementedException();
        }
    }
}
