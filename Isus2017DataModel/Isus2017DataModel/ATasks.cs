using System;
using System.Collections.Generic;

namespace Isus2017DataModel
{
    public partial class ATasks
    {
        public int Uid { get; set; }
        public string Label { get; set; }
        public int? Tag { get; set; }
        public int? FactId { get; set; }
        public int? AuthorId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime Dt { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime Showtime { get; set; }
        public DateTime Failtime { get; set; }
        public DateTime? Endtime { get; set; }
        public int? HookedObjectId { get; set; }
        public int? PausedObjectId { get; set; }
        public string Txt { get; set; }
        public string Data { get; set; }

        public Users Author { get; set; }
        public F Fact { get; set; }
        public AObjects HookedObject { get; set; }
        public AObjects PausedObject { get; set; }
        public Users Receiver { get; set; }
    }
}
