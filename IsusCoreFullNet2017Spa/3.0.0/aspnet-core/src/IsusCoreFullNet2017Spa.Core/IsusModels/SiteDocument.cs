using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class SiteDocument : Entity
    {
        public string Header { get; set; }
        public string PageContent { get; set; }
        public int PageIndex { get; set; }
        public bool IsVisible { get; set; }
    }
}
