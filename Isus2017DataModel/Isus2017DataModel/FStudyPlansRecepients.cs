using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FStudyPlansRecepients
    {
        public int Uid { get; set; }
        public int PlanId { get; set; }
        public int BasicgroupId { get; set; }

        public FStudyPlans Plan { get; set; }
    }
}
