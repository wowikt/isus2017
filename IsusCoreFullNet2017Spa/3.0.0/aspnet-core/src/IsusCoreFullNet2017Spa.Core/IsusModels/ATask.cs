﻿using System;
using Abp.Domain.Entities;

namespace IsusCoreFullNet2017Spa.IsusModels
{
    public partial class ATask : Entity
    {
        public string Label { get; set; }
        public int? Tag { get; set; }
        public long? FactId { get; set; }
        public long? AuthorId { get; set; }
        public long ReceiverId { get; set; }
        public DateTime Dt { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime Showtime { get; set; }
        public DateTime Failtime { get; set; }
        public DateTime? Endtime { get; set; }
        public int? HookedObjectId { get; set; }
        public int? PausedObjectId { get; set; }
        public string Txt { get; set; }
        public string Data { get; set; }

        public IsusUser Author { get; set; }
        public Fact Fact { get; set; }
        public AObject HookedObject { get; set; }
        public AObject PausedObject { get; set; }
        public IsusUser Receiver { get; set; }
    }
}
