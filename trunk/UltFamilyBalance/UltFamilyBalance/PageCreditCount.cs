using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Ult.Commons;
using Ult.FamilyBalance.UI.Pages;
using Ult.FamilyBalance.Model;
using Ult.Core.Utils;



namespace Ult.FamilyBalance.UI
{
    public partial class PageCreditCount : UserControl, IPage
    {


        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        // 
        private PageStatus _status;
        //
        ObjectQuery<CreditCount> _creditCounts;
        // 
        private UltFamilyBalanceContext _context;

        private Logger _log;

        //
        private bool _useDateFrom;
        //
        private bool _useDateTo;
        // 
        private DateTime _dateFrom;
        //
        private DateTime _dateTo;

        private int _amountMin;

        private int _amountMax;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        public PageCreditCount()
        {
            InitializeComponent();
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
            get { return "Conto Corrente"; }
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
            get
            {
                return _status != PageStatus.Processing &&
                       _status != PageStatus.Locked;
            }
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

        private void DefaultFilters()
        {
            _useDateFrom = false;
            _useDateTo = false;
            _dateFrom = DateTimeUtils.ToMidnight(DateTime.Today.AddMonths(-1));
            _dateTo = DateTimeUtils.Midnight;
            _amountMin = -1;
            _amountMax = -1;
        }

        private void RefreshFilters()
        {
            cbxUseDateTo.Checked = _useDateTo;
            cbxUseDateFrom.Checked = _useDateFrom;
            dtpDateFrom.Value = _dateFrom;
            dtpDateTo.Value = _dateTo;
            dtpDateFrom.Enabled = _useDateFrom;
            dtpDateTo.Enabled = _useDateTo;
            cbxMinAmount.Checked = _amountMin > -1;
            cbxMaxAmount.Checked = _amountMax > -1;
            numMinAmount.Enabled = _amountMin > -1;
            numMaxAmount.Enabled = _amountMax > -1;
        }

        private void RefreshList()
        {
            // Data refresh
            _context.Refresh(RefreshMode.StoreWins, _creditCounts);
            // Incoming entries query
            var list =  from c in _creditCounts
                        where    (!_useDateTo || c.Year <= _dateTo.Year)
                            &&  (!_useDateFrom || c.Year >= _dateFrom.Year)
                            &&  (_amountMin == -1 || c.Balance >= _amountMin)
                            &&  (_amountMax == -1 || c.Balance <= _amountMax)
                        // orderby Year, Month descending
                        select c;
            // Incoming entries
            dgvCreditCounts.AutoGenerateColumns = false;
            dgvCreditCounts.DataSource = list;
        }

        private void RefreshText()
        {
            labelTitle.Text = Title;
        }

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Init(params object[] args)
        {
            // Logger
            _log = Logger.GetDefaultLogger();
            // Context
            _context = UltFamilyBalance.GetUltFamilyBalance().Context;
            //
            DefaultFilters();
            // STATUS: Init
            _status = PageStatus.Init;
        }

        public void Open(Size size)
        {
            //
            UpdateSize(size);
            // Entries
            _creditCounts = _context.CreditCounts;
            //
            Refresh();
            // STATUS: Active
            _status = PageStatus.Active;
        }

        public void Refresh(params object[] args)
        {
            // STATUS: Processing
            _status = PageStatus.Processing;
            // Refresh
            RefreshText();
            RefreshFilters();
            RefreshList();
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

        public void MoveFirst()
        {
        }

        public void MoveLast()
        {
            try
            {
                int selected = 0;
                if (dgvCreditCounts.SelectedRows.Count > 0)
                {
                    selected = dgvCreditCounts.SelectedRows[0].Index;
                }
            }
            catch (Exception ex)
            {
                _log.Error("", ex);

            }
        }

        public void MoveNext()
        {
        }

        public void MovePrev()
        {
        }

        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            // 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //
        }
        // -----------------------------------------------------------------------------------------------------------


        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT HANDLERS


        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
