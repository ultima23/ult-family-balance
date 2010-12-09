﻿using System;
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
using Ult.Util;
using Ult.Commons;
using Ult.Core.Utils;

namespace Ult.FamilyBalance.UI
{
    public partial class PageEntry : UserControl, IPage, INavigablePage<Entry>
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        //
        private EntryDirection _direction;
        // 
        private PageStatus _status;
        //
        ObjectQuery<Entry> _entries;
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
        public PageEntry()
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
            get { return _direction == EntryDirection.OutgoingReference ? "Uscite" : "Entrate"; }
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

        /// <summary>
        /// 
        /// </summary>
        public Entry CurrentEntity
        {
            get 
            {
                if (HasCurrentEntity)
                {
                    return dgvEntries.Rows[dgvEntries.SelectedRows[0].Index].DataBoundItem as Entry;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HasCurrentEntity
        {
            get { return (dgvEntries.SelectedRows.Count > 0); }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private void DefaultFilters()
        {
            _useDateFrom = true;
            _useDateTo = true;
            _dateFrom = DateTimeUtils.ToMidnight(DateTime.Today.AddMonths(-1));
            _dateTo = DateTimeUtils.Midnight;
            _type = _direction == EntryDirection.OutgoingReference ? EntryType.AllOutgoing : EntryType.AllIncoming;
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
                        where t.Direction.Id == _direction.Id
                        select t;
            List<EntryType> list = new List<EntryType>();
            list.Add((_direction.Id == EntryDirection.OutgoingId) ? EntryType.AllOutgoing : EntryType.AllIncoming);
            list.AddRange(types);
            // 
            cmbTypes.DisplayMember = "Name";
            cmbTypes.DataSource = list;
        }

        private void RefreshList()
        {
            // Data refresh
            _context.Refresh(RefreshMode.StoreWins, _entries);
            // Incoming entries query
            var outgoing =  from e in _entries
                            where e.Type.Direction.Id == _direction.Id
                                 && (!_useDateTo || e.Date <= _dateTo)
                                 && (!_useDateFrom || e.Date >= _dateFrom)
                                 && (_type.Id == 0 || _type.Id == e.Type.Id)
                                 && (_amountMin == -1 || e.Amount >= _amountMin)
                                 && (_amountMax == -1 || e.Amount <= _amountMax)
                            // orderby Date descending
                            select e;
            // Incoming entries
            dgvEntries.AutoGenerateColumns = false;
            dgvEntries.DataSource = outgoing;
        }

        private void RefreshText()
        {
            labelTitle.Text = Title;
        }

        private void EditEntry()
        {
            if (HasCurrentEntity)
            {
                //
                IDetail<Entry> detail = new DetailEntry();
                //
                FormDetail<Entry> form_detail = new FormDetail<Entry>(detail, CurrentEntity, _direction);
                form_detail.Title = Title + " Edit";
                form_detail.ShowDialog();
                //
                RefreshList();
            }
        }

        private void NewEntry()
        {
            Entry new_entry = new Entry();
            new_entry.Date = DateTime.Now;
            new_entry.DateInsert = DateTime.Now;
            new_entry.DateUpdate = DateTime.Now;
            new_entry.User = UltFamilyBalance.GetUltFamilyBalance().User;
            //
            IDetail<Entry> detail = new DetailEntry();
            //
            FormDetail<Entry> form_detail = new FormDetail<Entry>(detail, new_entry, _direction);
            form_detail.Title = Title + " New";
            form_detail.ShowDialog();
            //
            RefreshList();
        }

        private void DeleteEntry()
        {
            if (HasCurrentEntity)
            {
                // Delete user confirm
                if (UIUtils.Confirm("Are you sure to delete the selected entry?\r\nThis operation cannot be reverted."))
                {
                    _context.DeleteObject(this.CurrentEntity);
                    _context.SaveChanges();
                    //
                    RefreshList();
                    // Move to the previous entity
                    // Prev();
                }
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Init(params object[] args)
        {
            // Parameters check
            if (args.Length < 1) throw new ArgumentException("Parameters 'direction' are missing");
            if (!(args[0] is EntryDirection)) throw new ArgumentException("Parameter 'direction' (EntryDirection) missing or wrong");
            // Entry direction definition
            _direction = args[0] as EntryDirection;
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
            _entries = _context.Entries;
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

        public void MoveFirst()
        {
        }

        public void MoveLast()
        {
            try
            {
                int selected = 0;
                if (dgvEntries.SelectedRows.Count > 0)
                {
                    selected = dgvEntries.SelectedRows[0].Index;
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
                    _dateTo = DateTimeUtils.ToMidnight(dtpDateTo.Value);
                    RefreshList();
                }
            }
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (_dateFrom != dtpDateFrom.Value)
                {
                    _dateFrom = DateTimeUtils.ToMidnight(dtpDateFrom.Value);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                NewEntry();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                EditEntry();
            }
        }

        private void dgvOutgoing_DoubleClick(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                EditEntry();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEntry();
        }

        //---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
