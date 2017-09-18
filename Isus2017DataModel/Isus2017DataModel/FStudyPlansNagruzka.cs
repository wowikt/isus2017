using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class FStudyPlansNagruzka
    {
        public int Uid { get; set; }
        public int PlanId { get; set; }
        public int Grade { get; set; }
        public double Hours { get; set; }

        public FStudyPlans Plan { get; set; }
    }
}
