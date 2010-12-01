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
    public partial class PageOutgoingList : UserControl, IPage
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        // 
        private PageStatus _status;
        // 
        private UltFamilyBalanceContext _context;


        private bool _useDateFrom;

        private bool _useDateTo;
        // 
        private DateTime _dateFrom;
        //
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
        public PageOutgoingList()
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
            get { return "Outgoing Entries"; }
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
            get { return _status != PageStatus.Processing &&
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

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private void DefaultFilters()
        {
            _useDateFrom = false;
            _useDateTo = false;
            _dateFrom = DateTime.Today.AddMonths(-1);
            _dateTo = DateTime.Today;
            _type = EntryType.AllOutgoing;
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
            cmbTypes.SelectedItem = _type;
            cbxMinAmount.Checked = _amountMin > -1;
            cbxMaxAmount.Checked = _amountMax > -1;
            numMinAmount.Enabled = _amountMin > -1;
            numMaxAmount.Enabled = _amountMax > -1;
        }

        private void RefreshTypes()
        {
            // Outgoing types 
            var types = from t in _context.EntryTypes
                        where t.Direction.Id == EntryDirection.OutgoingId
                        select t;
            List<EntryType> list = new List<EntryType>();
            list.Add(EntryType.AllOutgoing);
            list.AddRange(types);
            // 
            cmbTypes.DisplayMember = "Name";
            cmbTypes.DataSource = list;
        }

        private void RefreshList()
        {
            // Entries
            ObjectQuery<Entry> entries = _context.Entries;
            // Incoming entries query
            var outgoing = from e in entries
                           where    e.Type.Direction.Id == EntryDirection.OutgoingId 
                                 && (!_useDateTo || e.Date <= _dateTo)
                                 && (!_useDateFrom || e.Date >= _dateFrom)
                                 && (_type.Id == 0 || _type.Id == e.Type.Id)
                                 && (_amountMin == -1 || e.Amount >= _amountMin)
                                 && (_amountMax == -1 || e.Amount <= _amountMax)
                           select new { e.Id, e.Date, e.Type.Name, e.Amount, e.DateUpdate };
            // Incoming entries
            dgvIncoming.AutoGenerateColumns = false;
            dgvIncoming.DataSource = outgoing;
        }

        private void RefreshUI()
        {
            labelTitle.Text = Title;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Init()
        {
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
            RefreshUI();
            RefreshTypes();
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

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT EHANDLERS

        private void chbUseDateFrom_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cbxUseDateFrom.Checked)
                {
                    dtpDateFrom.Enabled = true;
                    _useDateFrom = true;
                    _dateFrom = dtpDateFrom.Value;
                }
                else
                {
                    dtpDateFrom.Enabled = false;
                    _useDateFrom = false;
                    
                }
                RefreshList();
            }
        }

        private void chbUseDateTo_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cbxUseDateTo.Checked)
                {
                    dtpDateTo.Enabled = true;
                    _useDateTo = true;
                    _dateTo = dtpDateTo.Value;
                }
                else
                {
                    dtpDateTo.Enabled = false;
                    _useDateTo = false;
                }
                RefreshList();
            }
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (_dateTo != dtpDateTo.Value)
                {
                    _dateTo = dtpDateTo.Value;
                    RefreshList();
                }
            }
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (_dateTo != dtpDateTo.Value)
                {
                    _dateFrom = dtpDateFrom.Value;
                    RefreshList();
                }
            }
        }

        private void cmbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                EntryType type = cmbTypes.SelectedItem as EntryType;
                if (type != null && type != _type)
                {
                    _type = type;
                    RefreshList();
                }
            }
        }

        private void cbxMinAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cbxMinAmount.Checked)
                {
                    numMinAmount.Enabled = true;
                    _amountMin = Convert.ToInt32(numMinAmount.Value);
                }
                else
                {
                    numMinAmount.Enabled = false;
                    _amountMin = -1;
                    
                }
                RefreshList();
            }
        }

        private void numMinAmount_ValueChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                
                _amountMin = Convert.ToInt32(numMinAmount.Value);
                RefreshList();
            }
        }

        private void cbxMaxAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cbxMaxAmount.Checked)
                {
                    numMaxAmount.Enabled = true;
                    _amountMax = Convert.ToInt32(numMaxAmount.Value);
                }
                else
                {
                    numMaxAmount.Enabled = false;
                    _amountMax = -1;
                }
                RefreshList();
            }
        }

        private void numMaxAmount_ValueChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                _amountMax = Convert.ToInt32(numMaxAmount.Value);
                RefreshList();
            }
        }

        //---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
