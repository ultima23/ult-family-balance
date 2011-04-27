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
    public partial class FormPage : Form
    {


        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        private IPage _page;

        private object[] _args;

        private Logger _log;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        public FormPage(IPage page) : this(page, null)
        {
        }

        public FormPage(IPage page, params object[] args)
        {
            InitializeComponent();
            Init(page, args);
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        /// <summary>
        /// Page to display
        /// </summary>
        public IPage Page
        {
            get { return _page; }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        /// <summary>
        /// 
        /// </summary>
        protected void Init(IPage page, params object[] args)
        {
            // Retrieve default logger instance
            _log = Logger.GetDefaultLogger();
            // Form init
            UIUtils.SetDefaultIcon(this);
            // Page registering
            RegisterPage(page, args);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        private void RegisterPage(IPage page, params object[] args)
        {
            _page = page;
            panelDetail.Controls.Add(_page.Control);
            // Page init
            _page.Init(args);
            // Sets arguments
            _args = args;
            // Title
            Text = _page.Title;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UnregisterPage()
        {
            // Deregister the page
            panelDetail.Controls.Remove(_page.Control);
            // Closes the page
            _page.Close();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region EVENT HANDLERS

        private void FormInfo_Load(object sender, EventArgs e)
        {
            // Opens the page
            _page.Open(panelDetail.Size);
            // Refresh page the first time
            _page.Refresh(_args);
        }

        private void FormPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (_page.Status == PageStatus.Processing);
        }

        private void FormPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Unregistering page
            UnregisterPage();
            // Result
            DialogResult = DialogResult.OK;
        }

        private void FormPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(btnClose, new EventArgs());
            }
        }

        private void FormPage_Resize(object sender, EventArgs e)
        {
            _page.UpdateSize(Size);
        }

        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------


    }
}
