using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class SiteDocuments
    {
        public int Uid { get; set; }
        public string Header { get; set; }
        public string PageContent { get; set; }
        public int PageIndex { get; set; }
        public bool IsVisible { get; set; }
    }
}
