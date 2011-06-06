using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ult.Commons;
using System.Data.SqlClient;
using Ult.Util;

namespace Ult.FamilyBalance.UI.Pages
{
    public partial class PageReportGroupYear : UserControl, IPage
    {

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        protected const string PAGE_TITLE                               = "Report uscite per gruppi";

        protected const string DATASET_NAME                             = "ReportGroups";
        protected const string DATASET_MASTER_NAME                      = "TableGroups";
        protected const string DATASET_DETAIL_NAME                      = "TableGroupsDetail";
        protected const string DATASET_TABLE_BALANCE                    = "TableBalance";

        protected const string DATASET_RELATION_NAME                    = "RelationGroups";
        protected const string DATASET_RELATION_MASTER_FIELD            = "EntryGroupId";
        protected const string DATASET_RELATION_DETAIL_FIELD            = "EntryGroupId";

        protected const string PARAM_YEAR                               = "@year";

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        //
        private Logger _log;
        // 
        private PageStatus _status;
        //
        private int _year;
        //
        private DataSet _dataset;
        //
        private SqlDataAdapter _adapterGroupsYear;
        private SqlDataAdapter _adapterGroupsYearDetail;
        private SqlDataAdapter _adapterLastMonthBalance;
        //
        private SqlCommand _commandGroupsYear;
        private SqlCommand _commandGroupsYearDetail;
        private SqlCommand _commandLastMonthBalance;
        //
        private BindingSource _bindingGroupsYear;
        private BindingSource _bindingGroupsYearDetail;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        public PageReportGroupYear()
        {
            InitializeComponent();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        #region IPage Members

        public string Title
        {
            get { return PAGE_TITLE; }
        }

        public bool Active
        {
            get
            {
                return _status != PageStatus.Unknown &&
                       _status != PageStatus.Init;
            }
        }

        public bool CanHide
        {
            get 
            { 
                return  _status != PageStatus.Processing &&
                        _status != PageStatus.Locked;
            }
        }

        public PageStatus Status
        {
            get { return _status; }
        }

        public Control Control
        {
            get { return this as Control; }
        }

        #endregion

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private SqlCommand CreateGroupsCommand(SqlConnection connection)
        {
            // Query
            string sql = "SELECT [Selected] = 0, " +
                         "       [Year], " + 
		                 "       [EntryGroupId], " +
                         "       [Group], " +
                         "       [Total], " + 
		                 "       [Avg] " + 
                         "FROM vwReportGroupYear " + 
                         "WHERE ISNULL( " + PARAM_YEAR + ", 0) = 0 OR [Year] = " + PARAM_YEAR + " " +
                         "ORDER BY [Total] DESC";
            // Command creation
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            // Year parameter
            SqlParameter paramYear = new SqlParameter();
            paramYear.ParameterName = PARAM_YEAR;
            paramYear.DbType = DbType.Int32;
            // Parameter adding
            cmd.Parameters.Add(paramYear);
            // Returns the command
            return cmd;
        }

        private SqlCommand CreateGroupsDetailCommand(SqlConnection connection)
        {
            // Query
            string sql = "SELECT [Year], " + 
		                 "       [Month], " + 
		                 "       [MonthName], " + 
		                 "       [EntryGroupId], " + 
		                 "       [Group], " + 
		                 "       [Total], " + 
		                 "       [Avg] " + 
                         "FROM vwReportGroupMonth " + 
                         "WHERE     ISNULL( " + PARAM_YEAR + ", 0) = 0 OR [Year] = " + PARAM_YEAR + " " +
                         "ORDER BY [Month] ASC";
            // Command creation
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            // Year parameter
            SqlParameter paramYear = new SqlParameter();
            paramYear.ParameterName = PARAM_YEAR;
            paramYear.DbType = DbType.Int32;
            // Parameter adding
            cmd.Parameters.Add(paramYear);
            // Returns the command
            return cmd;
        }

        private SqlCommand CreateLastMonthBalanceCommand(SqlConnection connection)
        {
            // Query
            string sql = "SELECT	a.[YEAR], " +
			             "        	a.[Month], " +
			             "        	b.[MonthName], " +
			             "        	a.[Balance] " +
	                     "FROM		    vwCreditCountByMonth			a " +
	                     "INNER JOIN	dbo.FnGetLastClosedMonth(@year)	b	ON		a.[Year] = b.[Year] " +
						 "        	                                            AND a.[Month] = b.[Month]";
            // Command creation
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            // Year parameter
            SqlParameter paramYear = new SqlParameter();
            paramYear.ParameterName = PARAM_YEAR;
            paramYear.DbType = DbType.Int32;
            // Parameter adding
            cmd.Parameters.Add(paramYear);
            // Returns the command
            return cmd;
        }

        private void CalcBalance()
        {
            decimal total           = 0;
            decimal correction      = 0;
            decimal total_corrected = 0;
            // Total
            total = Convert.ToDecimal(_dataset.Tables[DATASET_TABLE_BALANCE].Rows[0]["Balance"] ?? 0);
            // Correction
            foreach (DataRow row in _dataset.Tables[DATASET_MASTER_NAME].Rows)
            {
                if (Convert.ToBoolean(row["Selected"])) correction += Convert.ToDecimal(row["Total"]);
            }
            // Total corrected
            total_corrected = total - correction;

            // Display
            lblTotal.Text = String.Format("{0:#0.00} €", total);
            lblCorrection.Text = String.Format("{0:#0.00} €", correction);
            lblTotalCorrect.Text = String.Format("{0:#0.00} €", total_corrected);
        }

        private void InitUI()
        {
            // Years combobox loading
            int[] years = DateTimeUtils.GetYearInterval(UltFamilyBalance.FiltersPastYearsNumber,
                                                        UltFamilyBalance.FiltersYearsNumber);
            cmbYear.Items.Clear();
            for (int i = 0; i < years.Length; i++)
            {
                cmbYear.Items.Add(years[i]);
            }
            // Columns creation
            dgvGroupsYear.AutoGenerateColumns = false;
            dgvGroupsYearDetail.AutoGenerateColumns = false;
            // Grid binding
            dgvGroupsYear.DataSource = _bindingGroupsYear;
            dgvGroupsYearDetail.DataSource = _bindingGroupsYearDetail;
        }

        private void UpdateUI()
        {
            UpdateFiltersUI();
        }

        private void UpdateFiltersUI()
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(_year);
        }

        private void LoadData(int year)
        {
            // Sets parameters
            _commandGroupsYear.Parameters[PARAM_YEAR].Value = year;
            _commandGroupsYearDetail.Parameters[PARAM_YEAR].Value = year;
            _commandLastMonthBalance.Parameters[PARAM_YEAR].Value = year;
            // Data loading (prima il dettaglio)
            _dataset.Tables[DATASET_DETAIL_NAME].Clear();
            _dataset.Tables[DATASET_MASTER_NAME].Clear();
            _dataset.Tables[DATASET_TABLE_BALANCE].Clear();
            _adapterGroupsYear.Fill(_dataset, DATASET_MASTER_NAME);
            _adapterGroupsYearDetail.Fill(_dataset, DATASET_DETAIL_NAME);
            _adapterLastMonthBalance.Fill(_dataset, DATASET_TABLE_BALANCE);
            //
            CalcBalance();
        }

        private void BindData()
        {
            // Check relation between master and detail
            if (!_dataset.Relations.Contains(DATASET_RELATION_NAME))
            {
                // Master detail relation creation
                _dataset.Relations.Add(new DataRelation( DATASET_RELATION_NAME,
                                                        _dataset.Tables[DATASET_MASTER_NAME].Columns[DATASET_RELATION_MASTER_FIELD],
                                                        _dataset.Tables[DATASET_DETAIL_NAME].Columns[DATASET_RELATION_DETAIL_FIELD] ) );
                // Creates master bindings
                _bindingGroupsYear.DataSource = _dataset;
                _bindingGroupsYear.DataMember = DATASET_MASTER_NAME;
                // Creates detail bindings
                _bindingGroupsYearDetail.DataSource = _bindingGroupsYear;
                _bindingGroupsYearDetail.DataMember = DATASET_RELATION_NAME;
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        #region IPage Members

        public void Init(params object[] args)
        {
            // STATUS: Active
            _status = PageStatus.Init;
            // Parameters
            _year = (args.Length > 0) ? Convert.ToInt32(args[0]) : DateTime.Now.Year;
            // Dataset creation
            _dataset = new DataSet(DATASET_NAME);
            _dataset.Tables.Add(DATASET_MASTER_NAME);
            _dataset.Tables.Add(DATASET_DETAIL_NAME);
            _dataset.Tables.Add(DATASET_TABLE_BALANCE);
            // Commands creation
            SqlConnection connection = UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection();
            _commandGroupsYear = CreateGroupsCommand(connection);
            _commandGroupsYearDetail = CreateGroupsDetailCommand(connection);
            _commandLastMonthBalance = CreateLastMonthBalanceCommand(connection);
            // Adapters
            _adapterGroupsYear = new SqlDataAdapter(_commandGroupsYear);
            _adapterGroupsYearDetail = new SqlDataAdapter(_commandGroupsYearDetail);
            _adapterLastMonthBalance = new SqlDataAdapter(_commandLastMonthBalance);
            // Binding sources
            _bindingGroupsYear = new BindingSource();
            _bindingGroupsYearDetail = new BindingSource();
            // UI initialization
            InitUI();
            // STATUS: Active
            _status = PageStatus.Active;
        }

        public void Open(Size size)
        {
            // STATUS: Processing
            _status = PageStatus.Processing;
            // Loads the data
            LoadData(_year);
            // BindData data to UI
            BindData();
            // UI Updating
            UpdateFiltersUI();
            // Updating size
            UpdateSize(size);
            // STATUS: Active
            _status = PageStatus.Active;
        }

        public void Refresh(params object[] args)
        {
            // STATUS: Processing
            _status = PageStatus.Processing;
            // Parameters
            _year = (args.Length > 0) ? Convert.ToInt32(args[0]) : _year;
            // Relation check and creation
            LoadData(_year);
            // UI Updating
            UpdateUI();
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

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region EVENT HANDLERS

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (cmbYear.SelectedIndex > -1)
                {
                    // Selected year
                    int year = Convert.ToInt32(cmbYear.Text);
                    // Refresh
                    Refresh(year);
                }
            }
        }

        private void dgvGroupsYear_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 
                DataRowView row = dgvGroupsYear.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (row != null)
                {
                    // Detail filters
                    object[] args = new object[] { row["TypeId"], 
                                                   row["Year"], 
                                                   null, 
                                                   null,
                                                   row["Type"],
                                                 };
                    // Entry list page
                    PageEntryList page = new PageEntryList();
                    page.ShowEntryTypeColumn = false;
                    // Form
                    FormPage form = new FormPage(page, args);
                    form.Width = 520;
                    form.ShowDialog();
                }
            }
        }

        private void dgvGroupsYearDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*
                // 
                DataRowView row = dgvGroupsYearDetail.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (row != null)
                {
                    // Detail filters
                    object[] args = new object[] { row["TypeId"], 
                                                   row["Year"], 
                                                   null, 
                                                   row["Month"],
                                                   row["Type"],
                                                 };
                    // Entry list page
                    PageEntryList page = new PageEntryList();
                    page.ShowEntryTypeColumn = false;
                    // Form
                    FormPage form = new FormPage(page, args);
                    form.Width = 520;
                    form.ShowDialog();
                }
                */
            }
        }

        private void dgvGroupsYear_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                CalcBalance();
            }
        }

        private void dgvGroupsYear_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvGroupsYear.IsCurrentCellDirty)
            {
                dgvGroupsYear.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
