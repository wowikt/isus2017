using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Mpa.Roles.Dto;
using IsusCoreFullNet2017Mpa.Users.Dto;

namespace IsusCoreFullNet2017Mpa.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}