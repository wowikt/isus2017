using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Isus2017CoreSpa.Roles.Dto;
using Isus2017CoreSpa.Users.Dto;

namespace Isus2017CoreSpa.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}