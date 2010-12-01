using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ult.FamilyBalance.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Entry
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Entry [type:{2}, date:{0:yyyy-MM-dd}, amount:{1}]", Date, Amount, Type.Name);
        }

    }
}
