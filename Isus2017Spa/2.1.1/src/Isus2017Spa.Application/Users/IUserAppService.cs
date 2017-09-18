using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Isus2017Spa.Roles.Dto;
using Isus2017Spa.Users.Dto;

namespace Isus2017Spa.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}