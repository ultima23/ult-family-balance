using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Ult.FamilyBalance.UI.Pages;
using Ult.Util;

namespace Ult.FamilyBalance.UI
{
    public partial class FormDetail<TEntity> : Form
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        private IDetail<TEntity> _detail;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTOR

        public FormDetail(IDetail<TEntity> detail)
        {
            InitializeComponent();
            Init(detail);
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        protected void Init(IDetail<TEntity> detail)
        {
            if (detail == null) throw new ArgumentNullException("detail", "Detail should not be null");
            _detail = detail;
            RegisterDetail(_detail);
        }

        private void RegisterDetail(IDetail<TEntity> detail)
        {
            panelDetail.Controls.Add(_detail.Control);
        }

        private void UnregisterDetail()
        {
            panelDetail.Controls.Remove(_detail.Control);
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT HANDLERS

        private void FormDetail_Load(object sender, EventArgs e)
        {
            _detail.UpdateSize(panelDetail.Size);
            _detail.Refresh();
        }

        private void FormDetail_Resize(object sender, EventArgs e)
        {
            _detail.UpdateSize(panelDetail.Size);
        }

        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
