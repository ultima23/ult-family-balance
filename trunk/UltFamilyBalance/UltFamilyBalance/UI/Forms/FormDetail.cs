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
using Ult.Commons;

namespace Ult.FamilyBalance.UI
{
    public partial class FormDetail<TEntity> : Form
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        private IDetail<TEntity> _detail;

        private IDetailResult _result;

        private Logger _log;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTOR

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="entity"></param>
        public FormDetail(IDetail<TEntity> detail, TEntity entity, params object[] args)
        {
            InitializeComponent();
            Init(detail, entity, args);
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        public string Title
        {
            get { return Text; }
            set { Text = value; }
        }

        public IDetailResult Result
        {
            get { return _result;  }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        protected void Init(IDetail<TEntity> detail, TEntity entity, params object[] args)
        {
            // Parameters check
            if (detail == null) throw new ArgumentNullException("detail", "Detail should not be null");
            if (entity == null) throw new ArgumentNullException("entity", "Entity should not be null");
            // retrieve logger instance
            _log = Logger.GetDefaultLogger();
            //
            UIUtils.SetDefaultIcon(this);
            // Detail registering
            RegisterDetail(detail);
            // Initialization
            _detail.Init(entity, args);
            //
            _result = IDetailResult.None;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        private void RegisterDetail(IDetail<TEntity> detail)
        {
            _detail = detail;
            panelDetail.Controls.Add(_detail.Control);
        }

        /// <summary>
        /// 
        /// </summary>
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Entity verification
                if (_detail.Verify())
                {
                    // Entity save
                    _result = _detail.Save();
                    // Closing dialog
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                _log.Error("FormDetail > btnSave_Click() handler error:", ex);
                UIUtils.Error("FormDetail > btnSave_Click() handler error:", ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancelling modify
            _result = _detail.Cancel();
            // Closing dialog
            DialogResult = DialogResult.Cancel;
        }

        private void FormDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(btnSave, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(btnCancel, new EventArgs());
            }
        }

        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }

}
