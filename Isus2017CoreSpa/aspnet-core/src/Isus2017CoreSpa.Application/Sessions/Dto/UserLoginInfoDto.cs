using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Isus2017CoreSpa.Authorization.Users;
using Isus2017CoreSpa.Users;

namespace Isus2017CoreSpa.Sessions.Dto
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
