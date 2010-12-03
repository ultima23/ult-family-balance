using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ult.FamilyBalance.Model
{
    public partial class EntryDirection
    {

        public const int IncomingId = 10;

        public const int OutgoingId = 20;


        public static readonly EntryDirection IncomingReference = new EntryDirection()
        {
            Id = EntryDirection.IncomingId,
            Name = "Incoming",
            Description = "Incoming",
            Multiplier = 1
        };

        public static readonly EntryDirection OutgoingReference = new EntryDirection()
        {
            Id = EntryDirection.OutgoingId,
            Name = "Outgoing",
            Description = "Outgoing",
            Multiplier = -1
        };

    }
}
