using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Isus2017CoreSpa.Roles.Dto;

namespace Isus2017CoreSpa.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
