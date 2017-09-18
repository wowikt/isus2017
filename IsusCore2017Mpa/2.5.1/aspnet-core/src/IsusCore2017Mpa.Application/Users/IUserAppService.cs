using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCore2017Mpa.Roles.Dto;
using IsusCore2017Mpa.Users.Dto;

namespace IsusCore2017Mpa.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}