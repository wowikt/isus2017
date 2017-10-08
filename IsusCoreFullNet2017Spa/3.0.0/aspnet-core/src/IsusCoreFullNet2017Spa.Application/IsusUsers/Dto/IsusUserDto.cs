using Abp.AutoMapper;
using IsusCoreFullNet2017Spa.IsusModels;
using IsusCoreFullNet2017Spa.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsusCoreFullNet2017Spa.IsusUsers.Dto
{
    [AutoMapFrom(typeof(IsusUser))]
    public class IsusUserDto
    {
        public long Id { get; set; }
        public string CurrentName { get; set; }
        public string CurrentShortName { get; set; }
        public string Data { get; set; }
        public byte[] Photo { get; set; }
        public string Email { get; set; }
        public bool? IsDeveloper { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsBoss { get; set; }
        public string AccountName { get; set; }
        public string AccountPwd { get; set; }
        public byte[] AccountPwdMd5 { get; set; }
        public bool? AccountValid { get; set; }
        public bool? SurplusIsTeacher { get; set; }
        public int? SurplusKlassId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Tmp { get; set; }
        public string ContactInfo { get; set; }
        public int? WorkYear { get; set; }

        public UserCardBodyItemDto[] Body { get; set; }

        public UserCardHistoryItemDto[] History { get; set; }
    }
}
