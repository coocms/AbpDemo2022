using Coocms.Application.Contracts.Coocms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coocms.Application.Coocms
{
    public class CoocmsApplicationService : ICoocmsApplicationService
    {
        public async Task<CoocmsDto> GetCoocmsDtoAsync()
        {
            await Task.Delay(1000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("GetCoocmsDtoAsync Invoke");
            Console.BackgroundColor = ConsoleColor.Black;
            return new CoocmsDto()
            {
                Name = "Coocms",
                Description = "This is a CoocmsDto",
                Id = 100
            };
        }
    }
}
