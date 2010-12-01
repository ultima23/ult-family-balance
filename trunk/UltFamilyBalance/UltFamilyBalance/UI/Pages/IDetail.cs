﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Ult.FamilyBalance.Model;
using System.Windows.Forms;

namespace Ult.FamilyBalance.UI.Pages
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IDetail<TEntity>
    {

        TEntity Entity
        {
            get;
        }

        /// <summary>
        /// True if the detail has pending changes
        /// </summary>
        bool HasPendingChanges
        {
            get;
        }

        /// <summary>
        /// Control that rapresents the page
        /// </summary>
        Control Control
        {
            get;
        }

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="entity"></param>
        void Init(TEntity entity);

        /// <summary>
        /// Save detail changes
        /// </summary>
        void Save();

        /// <summary>
        /// Cancel detail changes
        /// </summary>
        void Cancel();

        /// <summary>
        /// Refresh page data
        /// </summary>
        void Refresh(params object[] args);

        /// <summary>
        /// Resize page to specified size
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        void UpdateSize(Size size);

    }
}
