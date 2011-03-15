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
using Ult.Util;
using System.Globalization;

namespace Ult.FamilyBalance.UI
{
    public partial class PageCreditCount : UserControl, IPage, INavigablePage<CreditCount>
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        //
        private int _index;
        // 
        private PageStatus _status;
        //
        private ObjectQuery<CreditCount> _creditCounts;
        // 
        private UltFamilyBalanceContext _context;
        // 
        private Logger _log;
        //
        private bool _useYear;
        //
        private bool _useMonth;
        // 
        private int _year;
        //
        private int _month;

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

        /// <summary>
        /// 
        /// </summary>
        public CreditCount CurrentEntity
        {
            get
            {
                if (HasCurrentEntity)
                {
                    return dgvCreditCounts.Rows[dgvCreditCounts.SelectedRows[0].Index].DataBoundItem as CreditCount;
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
            get { return (dgvCreditCounts.SelectedRows.Count > 0); }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private void DefaultFilters()
        {
            _useYear = true;
            _useMonth = false;
            _year = DateTime.Today.Year;
            _month = -1;
            _amountMin = -1;
            _amountMax = -1;
        }

        private void RefreshFilters()
        {
            cbxUseYear.Checked = _useYear;
            cbxUseMonth.Checked = _useMonth;
            cmbYear.SelectedIndex = _useYear ? cmbYear.Items.IndexOf(_year) : -1;
            cmbYear.Enabled = _useYear;
            cmbMonth.SelectedIndex = _useMonth ? _month -1 : -1;
            cmbMonth.Enabled = _useMonth;
            cbxMinAmount.Checked = _amountMin > -1;
            cbxMaxAmount.Checked = _amountMax > -1;
            numMinAmount.Enabled = _amountMin > -1;
            numMaxAmount.Enabled = _amountMax > -1;
        }

        private void ApplyFilters()
        {
            // Incoming entries query
            var list =  from c in _creditCounts
                        where    (!_useYear || c.Year == _year)
                            &&  (!_useMonth || c.Month == _month)
                            &&  (_amountMin == -1 || c.Balance >= _amountMin)
                            &&  (_amountMax == -1 || c.Balance <= _amountMax)
                        orderby c.Year descending, c.Month descending
                        select c;
            // Incoming entries
            dgvCreditCounts.AutoGenerateColumns = false;
            dgvCreditCounts.DataSource = list;
            // check position
            if (_index > 0)
            {
                SetSelectedRow(_index);
            }
        }

        private void RefreshText()
        {
            labelTitle.Text = Title;
        }

        private void LoadYears()
        {
            int[] years = DateTimeUtils.GetYearInterval(UltFamilyBalance.FiltersPastYearsNumber, 
                                                        UltFamilyBalance.FiltersYearsNumber);

            cmbYear.Items.Clear();
            for (int i = 0; i < years.Length; i++)
            {
                cmbYear.Items.Add(years[i]);
            }
        }

        private void LoadMonths()
        {
            string[] months = DateTimeUtils.GetMonthNames(new CultureInfo("it-IT"));
            cmbMonth.Items.Clear();
            for (int i = 0; i < months.Length; i++)
            {
                cmbMonth.Items.Add(months[i]);
            }
        }

        private void LoadData()
        {
            // Data refresh
            _context.Refresh(RefreshMode.StoreWins, _creditCounts);
        }

        private void SaveSelectedRow()
        {
            SaveSelectedRow(0);
        }

        private void SaveSelectedRow(int offeset)
        {
            if (dgvCreditCounts.SelectedRows.Count > 0)
            {
                _index = dgvCreditCounts.SelectedRows[0].Index + offeset;
            }
            else
            {
                _index = -1;
            }
        }

        private void SetSelectedRow(int index)
        {
            if (index > -1 && index < dgvCreditCounts.Rows.Count)
            {
                dgvCreditCounts.CurrentCell = dgvCreditCounts.Rows[index].Cells[1];
            }
        }

        private void EditCreditCount()
        {
            if (HasCurrentEntity)
            {
                //
                IDetail<CreditCount> detail = new DetailCreditCount();
                //
                FormDetail<CreditCount> form_detail = new FormDetail<CreditCount>(detail, CurrentEntity, new object[] { });
                form_detail.Title = "Modifica " + Title;
                form_detail.ShowDialog();
            }
        }

        private void NewCreditCount()
        {
            CreditCount new_credit_count = new CreditCount();
            new_credit_count.Year = _useYear ? _year : DateTime.Now.Year;
            new_credit_count.Month = _useMonth ? _month : DateTime.Now.Month;
            new_credit_count.DateInsert = DateTime.Now;
            new_credit_count.DateUpdate = DateTime.Now;
            new_credit_count.User = UltFamilyBalance.GetUltFamilyBalance().User;
            //
            IDetail<CreditCount> detail = new DetailCreditCount();
            //
            FormDetail<CreditCount> form_detail = new FormDetail<CreditCount>(detail, new_credit_count, new object[] { });
            form_detail.Title = "Nuovo " + Title;
            form_detail.ShowDialog();
            // Reloads data from database
            LoadData();
            // UI Refresh
            Refresh(new object [] {});
        }

        private void DeleteCreditCount()
        {
            if (HasCurrentEntity)
            {
                // Delete user confirm
                if (UIUtils.Confirm("Sei sicuro di voler eliminare il resoconto mensile corrente?\r\nQuesta operazione non potrà essere recuperata."))
                {
                    // Save the position
                    SaveSelectedRow(-1);
                    // Delete selected object
                    _context.DeleteObject(CurrentEntity);
                    _context.SaveChanges();
                    // Reloads data from database
                    LoadData();
                    // UI Refresh
                    Refresh(new object[] { });
                }
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

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
            // Data loading
            LoadData();
            LoadYears();
            LoadMonths();
            // Refresh
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
            ApplyFilters();
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
            SetSelectedRow(0);
        }

        public void MoveLast()
        {
            try
            {
                SetSelectedRow(dgvCreditCounts.RowCount - 1);
            }
            catch (Exception ex)
            {
                _log.Error("MoveLast() error", ex);
                UIUtils.Error("MoveLast() error: {0}", ex.Message);
            }
        }

        public void MoveNext()
        {
            try
            {
                SetSelectedRow(_index + 1);
            }
            catch (Exception ex)
            {
                _log.Error("MoveNext() error", ex);
                UIUtils.Error("MoveNext() error: {0}", ex.Message);
            }
        }

        public void MovePrev()
        {
            try
            {
                SetSelectedRow(_index - 1);
            }
            catch (Exception ex)
            {
                _log.Error("MovePrev() error", ex);
                UIUtils.Error("MovePrev() error: {0}", ex.Message);
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT HANDLERS

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCreditCount();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCreditCount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCreditCount();
        }

        private void dgvCreditCounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCreditCount();
        }

        private void cbxUseYear_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cbxUseYear.Checked)
                {
                    cmbYear.Enabled = true;
                    if (cmbYear.SelectedIndex > -1)
                    {
                        _year = Convert.ToInt32(cmbYear.Text);
                        _useYear = true;
                    }
                    else
                    {
                        _useYear = false;
                    }
                }
                else
                {
                    cmbYear.Enabled = false;
                    _useYear = false;
                }
                //
                ApplyFilters();
            }
        }

        private void cbxUseMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cbxUseMonth.Checked)
                {
                    cmbMonth.Enabled = true;
                    if (cmbMonth.SelectedIndex > -1)
                    {
                        _month = cmbMonth.SelectedIndex + 1;
                        _useMonth = true;
                    }
                    else
                    {
                        _useMonth = false;
                    }
                }
                else
                {
                    cmbMonth.Enabled = false;
                    _useMonth = false;
                }
                //
                ApplyFilters();
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cmbYear.SelectedIndex > -1)
                {
                    _year = Convert.ToInt32(cmbYear.Text);
                    _useYear = true;
                    ApplyFilters();
                }
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cmbMonth.SelectedIndex > -1)
                {
                    _month = cmbMonth.SelectedIndex + 1;
                    _useMonth = true;
                    ApplyFilters();
                }
            }
        }

        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
