using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class UsersOrganizer
    {
        public int Uid { get; set; }
        public int UserId { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
    }
}
