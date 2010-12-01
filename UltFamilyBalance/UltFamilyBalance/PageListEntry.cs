using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Ult.FamilyBalance.UI.Pages;
using Ult.FamilyBalance.Model;
using System.Data.Objects;

namespace Ult.FamilyBalance
{
    public partial class PageListEntry : UserControl, IPage
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        // 
        private PageStatus _status;
        // 
        private UltFamilyBalanceContext _context;

        // 
        private DateTime _dateFrom;

        private DateTime _dateTo;

        private EntryType _type;

        private int _amountMin;

        private int _amountMax;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        /// <summary>
        /// 
        /// </summary>
        public PageListEntry()
        {
            InitializeComponent();
            //
            DefaultFilters();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get { return "Incoming Entries"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Active
        {
            get
            {
                return _status != PageStatus.Unknown &&
                       _status != PageStatus.Init;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool CanHide
        {
            get { return true; }
        }

        /// <summary>
        /// 
        /// </summary>
        public PageStatus Status
        {
            get { return _status; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Control Control
        {
            get { return this as Control; }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private void DefaultFilters()
        {
            _dateFrom = DateTime.MinValue;
            _dateTo = DateTime.Today;
            _type = null;
            _amountMin = -1;
            _amountMax = -1;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Init()
        {
            _context = UltFamilyBalance.GetUltFamilyBalance().Context;
            // STATUS: Init
            _status = PageStatus.Init;
        }

        public void Open(Size size)
        {
            //
            UpdateSize(size);
            //
            Refresh();
            // STATUS: Active
            _status = PageStatus.Active;
        }

        public void Refresh(params object[] args)
        {
            // STATUS: Processing
            _status = PageStatus.Processing;
            // Entries
            ObjectQuery<Entry> entries = _context.Entries;
            // Incoming types
            var types = from t in _context.EntryTypes
                        where t.Direction.Id == EntryDirection.IncomingId
                        select new { t.Id, t.Name };
            cmbTypes.DisplayMember = "Name";
            cmbTypes.DataSource = types;
            // Incoming entries query
            var incoming = from e in entries
                           where e.Type.Direction.Id == EntryDirection.IncomingId &&
                                 e.Date <= _dateTo
                           select new { e.Id, e.Date, e.Type.Name, e.Amount, e.DateUpdate };
            // Incoming entries
            dgvIncoming.AutoGenerateColumns = false;
            dgvIncoming.DataSource = incoming;
            // 

            // STATUS: Active
            _status = PageStatus.Active;
        }

        public void Close()
        {
            // STATUS: Active
            _status = PageStatus.Ready;
        }

        public void UpdateSize(Size size)
        {
            Size = size;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------


    }
}
