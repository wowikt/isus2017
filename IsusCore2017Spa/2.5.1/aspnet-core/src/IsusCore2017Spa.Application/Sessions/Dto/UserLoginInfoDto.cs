using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using IsusCore2017Spa.Authorization.Users;
using IsusCore2017Spa.Users;

namespace IsusCore2017Spa.Sessions.Dto
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
