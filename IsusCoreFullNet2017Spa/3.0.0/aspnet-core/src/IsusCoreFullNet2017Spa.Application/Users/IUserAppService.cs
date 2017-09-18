using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IsusCoreFullNet2017Spa.Roles.Dto;
using IsusCoreFullNet2017Spa.Users.Dto;

namespace IsusCoreFullNet2017Spa.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}