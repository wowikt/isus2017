using Abp.AutoMapper;
using IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsusCoreFullNet2017Spa.Users.Dto
{
    [AutoMapTo(typeof(IsusUserCard))]
    public class UserCardDto
    {
        public UserCardBodyItemDto[] Body { get; set; }

        public UserCardHistoryItemDto[] History { get; set; }
    }
}
