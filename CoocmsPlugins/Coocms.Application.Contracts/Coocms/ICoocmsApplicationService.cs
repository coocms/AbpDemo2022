using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace Coocms.Application.Contracts.Coocms
{
    public interface ICoocmsApplicationService: IRemoteService, ITransientDependency
    {
        public Task<CoocmsDto> GetCoocmsDtoAsync();
    }
}
