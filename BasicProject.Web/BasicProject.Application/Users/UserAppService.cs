using BasicProject.Application.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace BasicProject.Application.Users
{

    public class UserAppService : IUserAppService, IRemoteService,ISingletonDependency
    {
        public async Task<UserDto> GetUserAsync(int id)
        {
            await Task.CompletedTask;
            return new UserDto
            {
                Id = id,
                UserName = "coocms",
                Email = "2323@qq.com",
                Password = "123"
                    
            };
        }

        public async Task<IEnumerable<UserDto>> GetUserAsync()
        {
            await Task.CompletedTask;
            
            return new List<UserDto>
            {
                new UserDto
                {
                    Id = 1,
                    UserName = "coocms",
                    Email = "2323@qq.com",
                    Password = "123"
                }
            };
        }
    }
}
