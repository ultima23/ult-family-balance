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
        private IPage _activePage;
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
        public IPage ActivePage
        {
            get { return _activePage; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HasActivePage
        {
            get { return _activePage != null; }
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
            _activePage = null;
            _pages = new Dictionary<string, IPage>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private IPage CreatePage(string key, Type type)
        {
            IPage page = GetPage(key);
            if (page == null)
            {
                // 
                page = (IPage)Activator.CreateInstance(type);
                page.Init(new object[] {});
                // Adds the page to the created pages
                _pages.Add(key, page);
            }
            return page;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private IPage CreatePage(string key, Type type, params object[] args)
        {
            IPage page = GetPage(key);
            if (page == null)
            {
                // Dynamic page creation
                page = (IPage)Activator.CreateInstance(type);
                page.Init(args);
                // Adds the page to the created pages
                _pages.Add(key, page);
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
            if (_activePage != page)
            {
                if (HasActivePage)
                {
                    if (!_activePage.CanHide)
                    {
                        UIUtils.Alert("Current page {0} cannot be closed!", new object[] { _activePage.Title });
                        return;
                    }
                    tscMain.ContentPanel.Controls.Remove(_activePage.Control);
                    _activePage.Close();
                }
                // 
                tscMain.ContentPanel.Controls.Add(page.Control);
                //
                page.Open(tscMain.ContentPanel.Size);
                // Current page
                _activePage = page;
            }
            else
            {
                _activePage.Refresh();
            }
            //
            RefreshStatusBar();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshStatusBar()
        {

            if (_ufb.IsUserLogged)
            {
                toolStripUser.Text = String.Format("User: {0} ", _ufb.User.Name);
            }
            else
            {
                toolStripUser.Text = "User: - ";
            }
            

            if (HasActivePage)
            {
                toolStripStatusBarPage.Text = String.Format("Current page: {0} ", _activePage.Title);
            }
            else
            {
                toolStripStatusBarPage.Text = "Current page: - ";
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Login()
        {
            #if !DEBUG
            FormLogin frm = new FormLogin();
            frm.CanCancel = _ufb.IsUserLogged;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshStatusBar();
            }
            #else
            _ufb.Login("luca", "luca");
            RefreshStatusBar();
            #endif

        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT EHANDLERS

        private void MainForm_Load(object sender, EventArgs e)
        {
            UIUtils.Setup();
            //
            RefreshStatusBar();
            // Startup
            tmrStartup.Enabled = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (HasActivePage)
            {
                _activePage.UpdateSize(tscMain.ContentPanel.Size);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            #if !DEBUG
            if (UIUtils.YesNo("Si desidera arrestare il server database?"))
            {
                // Stops the server
                SqlServerUtils.StopServer(30000, "Attendere l'arresto del server database ...");
            }
            #endif
        }

        private void tmrStartup_Tick(object sender, EventArgs e)
        {
            // error message
            string errorMessage = string.Empty;
            // Stops the timer
            tmrStartup.Enabled = false;
            // SQL Server service check
            if (SqlServerUtils.Exists())
            {
                if (SqlServerUtils.StartServer(30000, "Attendere l'avvio del server database ..."))
                {
                    // Login
                    Login();
                }
                else
                {
                    errorMessage = "SQL Service cannot be started, the program cannot be executed and will be closed";
                }
            }
            else
            {
                errorMessage = "SQL Service does not exists on this PC, the program cannot be executed and will be closed";
            }
            // If in error, display error and exit program
            if (!String.IsNullOrEmpty(errorMessage))
            {
                UIUtils.Error(errorMessage);
                Application.Exit();
            }
        }

        private void usciteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 
            SetPage(CreatePage("EntryOutgoing", typeof(PageEntry), EntryDirection.OutgoingReference));
        }

        private void entrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 
            SetPage(CreatePage("EntryIncoming", typeof(PageEntry), EntryDirection.IncomingReference));
        }

        private void totaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void contoCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 
            SetPage(CreatePage("Counts", typeof(PageCreditCount)));
        }

        private void mensiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 
            SetPage(CreatePage("ReportOutgoingByMonth", typeof(PageReportEntriesByMonth), EntryDirection.OutgoingReference));
        }

        private void mensiliToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 
            SetPage(CreatePage("ReportIncomingByMonth", typeof(PageReportEntriesByMonth), EntryDirection.IncomingReference));
        }

        private void annualiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPage(CreatePage("ReportOutgoingByYear", typeof(PageReportEntriesByYear), EntryDirection.OutgoingReference));
        }

        private void annualiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPage(CreatePage("ReportIncomingByYear", typeof(PageReportEntriesByYear), EntryDirection.IncomingReference));
        }

        private void cambiaUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HasActivePage && ActivePage.CanHide)
            {
                Close();
            }
        }

        private void annualeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPage(CreatePage("ReportTrandYear", typeof(PageReportTrendYear)));
            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            FormTest test = new FormTest();
            test.Show();
            */
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SetPage(CreatePage("ReportTypeYear", typeof(PageReportTypeYear)));
        }

        private void mensileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPage(CreatePage("ReportTrendMonth", typeof(PageReportTrendMonth)));
            
        }

        // --

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}