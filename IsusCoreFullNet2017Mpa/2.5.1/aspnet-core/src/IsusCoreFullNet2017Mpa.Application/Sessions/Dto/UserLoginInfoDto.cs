using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using IsusCoreFullNet2017Mpa.Authorization.Users;
using IsusCoreFullNet2017Mpa.Users;

namespace IsusCoreFullNet2017Mpa.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
