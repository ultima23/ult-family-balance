using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ult.FamilyBalance.Model;
using System.Data.Objects;

namespace Ult.FamilyBalance.UI.Pages
{
    public interface IPageList<TEntity>
    {

        void Init(UltFamilyBalanceContext context, ObjectQuery<TEntity> list);


    }
}
