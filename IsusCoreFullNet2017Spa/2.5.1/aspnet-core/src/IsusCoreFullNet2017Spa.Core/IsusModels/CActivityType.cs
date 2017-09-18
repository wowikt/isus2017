using System.Collections.Generic;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class CActivityType
    {
        public CActivityType()
        {
            SActivities = new HashSet<SActivity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SActivity> SActivities { get; set; }
    }
}
