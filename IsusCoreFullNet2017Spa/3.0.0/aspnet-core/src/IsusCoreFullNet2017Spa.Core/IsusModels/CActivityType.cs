using System.Collections.Generic;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CActivityType : Entity
    {
        public CActivityType()
        {
            SActivities = new HashSet<SActivity>();
        }

        public string Name { get; set; }

        public ICollection<SActivity> SActivities { get; set; }
    }
}
