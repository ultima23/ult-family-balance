using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ult.FamilyBalance.Model
{
    public partial class CreditCount
    {

        public string MonthName
        {
            get { return String.Format("{0:MM}", new DateTime(Year, Month, 1)); }
        }

        public string UserName
        {
            get { return User.Name ?? "<none>"; }
        }

    }
}
