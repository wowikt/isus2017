using System;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class UserOrganizer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
    }
}
