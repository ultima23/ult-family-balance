using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ult.FamilyBalance.Model;
using System.Data.Objects;

namespace Ult.FamilyBalance.UI.Pages
{
    /// <summary>
    /// Standard interface for a navigable page
    /// </summary>
    /// <typeparam name="TEntity">Type of the entity handled by the page</typeparam>
    public interface INavigablePage<TEntity>
    {

        /// <summary>
        /// Currently selected entity into page
        /// </summary>
        TEntity SelectedEntity
        {
            get;
        }

        /// <summary>
        /// True if the page has an entity selected
        /// </summary>
        bool HasSelectedEntity
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        void First();

        /// <summary>
        /// 
        /// </summary>
        void Last();

        /// <summary>
        /// 
        /// </summary>
        void Next();

        /// <summary>
        /// 
        /// </summary>
        void Prev();

    }
}
