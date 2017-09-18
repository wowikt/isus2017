using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class UserOrganizer : Entity
    {
        public long UserId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }

        public IsusUser IsusUser { get; set; }
    }
}
