using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ult.FamilyBalance.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EntryType
    {

        public static readonly EntryType AllOutgoing = new EntryType()
        {
            Id = 0,
            Name = "All Outgoing",
            Description = "All Outgoing",
            Direction = EntryDirection.OutgoingReference
        };

        public static readonly EntryType AllIncoming = new EntryType()
        {
            Id = 0,
            Name = "All Incoming",
            Description = "All Incoming",
            Direction = EntryDirection.IncomingReference
        };


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("EntryType [name:{0:yyyy-MM-dd}, desc:{1}, direction:{2}]", Name, Description, Direction);
        }

    }
}
