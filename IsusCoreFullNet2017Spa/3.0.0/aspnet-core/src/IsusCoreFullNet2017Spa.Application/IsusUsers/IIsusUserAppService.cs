using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Spa.IsusUsers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsusCoreFullNet2017Spa.IsusUsers
{
    public interface IIsusUserAppService
    {
        Task<PagedResultDto<IsusUserDto>> GetAll(PagedResultRequestDto input, string filter);

        Task<bool> MoveToMainUserTable(long isusUserId);
    }
}
