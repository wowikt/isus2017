using Abp.AutoMapper;
using IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsusCoreFullNet2017Spa.Users.Dto
{
    [AutoMapTo(typeof(IsusUserCardHistoryItem))]
    public class UserCardHistoryItemDto
    {
        public string Attr { get; set; }

        public DateTime Date { get; set; }

        public string Value { get; set; }
    }
}
