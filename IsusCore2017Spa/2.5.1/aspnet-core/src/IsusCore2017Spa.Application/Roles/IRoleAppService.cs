using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCore2017Spa.Roles.Dto;

namespace IsusCore2017Spa.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
