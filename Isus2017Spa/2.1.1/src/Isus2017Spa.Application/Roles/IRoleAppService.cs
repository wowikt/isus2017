using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Isus2017Spa.Roles.Dto;

namespace Isus2017Spa.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
