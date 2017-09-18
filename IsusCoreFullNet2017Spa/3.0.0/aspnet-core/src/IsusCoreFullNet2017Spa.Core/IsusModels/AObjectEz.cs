using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class AObjectEz : Entity
    {
        public int ObjectId { get; set; }
        public DateTime EzDate { get; set; }
        public string EzSigma { get; set; }
        public string EzContent { get; set; }
        public string EzData { get; set; }

        public AObject Object { get; set; }
    }
}
