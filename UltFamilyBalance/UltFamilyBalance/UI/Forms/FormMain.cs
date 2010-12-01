using System;
using System.Windows.Forms;

using Ult.Commons;
using Ult.FamilyBalance.Model;
using Ult.FamilyBalance.UI.Pages;
using System.Collections.Generic;
using System.Globalization;
using Ult.Util;


namespace Ult.FamilyBalance.UI
{
    public partial class FormMain : Form
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        //
        private IPage _page;
        //
        private Dictionary<string, IPage> _pages;
        //
        private Logger _logger = Logger.GetDefaultLogger();
        //
        private UltFamilyBalance _ufb;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// </summary>
        public FormMain()
        {
            // Logger
            _logger = Logger.GetDefaultLogger();
            //
            _ufb = UltFamilyBalance.GetUltFamilyBalance();
            _ufb.Init("conn string not used now");
            _ufb.Login("Luca", "luca");
            // Culture
            Application.CurrentCulture = CultureInfo.GetCultureInfo("it-IT");
            // Initialization
            InitializeComponent();
            //
            Init();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        /// <summary>
        /// 
        /// </summary>
        public bool HasActivePage
        {
            get { return _page != null; }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE  METHODS

        /// <summary>
        /// 
        /// </summary>
        private void Init()
        {
            _page = null;
            _pages = new Dictionary<string, IPage>();
            /*
            _logger.Debug("DEBUG LOG MESSAGE");
            _logger.Info("INFO LOG MESSAGE");
            _logger.Warning("WARNING LOG MESSAGE");
            _logger.Error("ERROR LOG MESSAGE");
            _logger.Fatal("FATAL LOG MESSAGE");
            Tracer.Trace("TEST TRACE TEST TRACE");
            */
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private IPage CreatePage(Type type)
        {
            IPage page = GetPage(type.Name);
            if (page == null)
            {
                // 
                page = (IPage)Activator.CreateInstance(type);
                page.Init();
                // Adds the page to the created pages
                _pages.Add(type.Name, page);
            }
            return page;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private IPage GetPage(string key)
        {
            if (_pages.ContainsKey(key))
            {
                return _pages[key];
            }
            else return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        private void SetPage(IPage page)
        {
            if (_page != page)
            {
                if (HasActivePage)
                {
                    if (!_page.CanHide)
                    {
                        UIUtils.Alert("Current page {0} cannot be closed!", new object[] { _page.Title });
                        return;
                    }
                    tscMain.ContentPanel.Controls.Remove(_page.Control);
                    _page.Close();
                }
                // 
                tscMain.ContentPanel.Controls.Add(page.Control);
                //
                page.Open(tscMain.ContentPanel.Size);
                // Current page
                _page = page;
            }
            else
            {
                _page.Refresh();
            }
            //
            RefreshStatusBar();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshStatusBar()
        {
            if (HasActivePage)
            {
                toolStripStatusBarPage.Text = String.Format("Current page: {0}", _page.Title);
            }
            else
            {
                toolStripStatusBarPage.Text = "Current page: -";
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT EHANDLERS

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ultFamilyBalance_dataDataSet.vwEntries' table. You can move, or remove it, as needed.
            // this.vwEntriesTableAdapter.Fill(this.ultFamilyBalance_dataDataSet.vwEntries);

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (HasActivePage)
            {
                _page.UpdateSize(tscMain.ContentPanel.Size);
            }
        }

        private void nuovaEntrataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            PageEntry page = new PageEntry();
            panelContent.Controls.Add(page);
            page.Init(_ufb.Context);
            */

            // SetActivePage(new PageListEntry());

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            PageListEntry page = new PageListEntry();
            panelContent.Controls.Add(page);
            page.Init(_ufb.Context, _ufb.Context.Entries);
            */
            SetPage(CreatePage(typeof(PageListEntry)));
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPage(CreatePage(typeof(PageOutgoingList)));
        }

        // --

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}