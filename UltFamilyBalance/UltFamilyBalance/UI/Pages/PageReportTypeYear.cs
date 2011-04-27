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
    public partial class PageReportTypeYear : UserControl, IPage
    {


        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        protected const string PAGE_TITLE                               = "Report Uscite per Categoria";


        protected const string DATASET_NAME                             = "ReportTypeYear";
        protected const string DATASET_MASTER_NAME                      = "TableTypeYear";
        protected const string DATASET_DETAIL_NAME                      = "TableTypeYearDetail";

        protected const string DATASET_RELATION_NAME                    = "RelationTypeYear";
        protected const string DATASET_RELATION_MASTER_FIELD            = "TypeId";
        protected const string DATASET_RELATION_DETAIL_FIELD            = "TypeId";

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
        private SqlDataAdapter _adapterTypeYear;
        private SqlDataAdapter _adapterTypeYearDetail;
        //
        private SqlCommand _commandTypeYear;
        private SqlCommand _commandTypeYearDetail;
        //
        private BindingSource _bindingTypeYear;
        private BindingSource _bindingTypeYearDetail;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        public PageReportTypeYear()
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

        private SqlCommand CreateTypeYearCommand(SqlConnection connection)
        {
            // Query
            string sql = "SELECT [Year]," + 
		                 "       [TypeId], " +
                         "       [Type], " +
                         "       [Total], " + 
		                 "       [Avg], " + 
		                 "       [Min], " + 
		                 "       [Max], " + 
                         "       [Perc] " + 
                         "FROM vwReportTypeYear " + 
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

        private SqlCommand CreateTypeYearDetailCommand(SqlConnection connection)
        {
            // Query
            string sql = "SELECT [Year]," + 
		                 "       [Month], " +
                         "       [MonthName], " +
		                 "       [Type], " + 
		                 "       [TypeId], " + 
		                 "       [Total], " + 
                         "       [Avg], " + 
                         "       [Min], " + 
                         "       [Max] " + 
                         "FROM vwReportTypeMonth " + 
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
            dgvTypeYear.AutoGenerateColumns = false;
            dgvTypeYearDetail.AutoGenerateColumns = false;
            // Grid binding
            dgvTypeYear.DataSource = _bindingTypeYear;
            dgvTypeYearDetail.DataSource = _bindingTypeYearDetail;
            // Chart binding
            // ... todo ... chrTrendYear.DataSource = _bindingReportTrendYear;
        }

        private void UpdateUI()
        {
            chartTypeDetail.DataBind();
            UpdateFiltersUI();
        }

        private void UpdateChartUI()
        {
            /* ... todo ...
            foreach (Series serie in chartTypeDetail.Series)
            {
                if (_series.Contains(serie.Name)) serie.Enabled = true;
                else serie.Enabled = false;
            }
            */
            chartTypeDetail.DataBind();
        }

        private void UpdateFiltersUI()
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(_year);
        }

        private void LoadData(int year)
        {
            // Sets parameters
            _commandTypeYear.Parameters[PARAM_YEAR].Value = year;
            _commandTypeYearDetail.Parameters[PARAM_YEAR].Value = year;
            // Data loading (prima il dettaglio)
            _dataset.Tables[DATASET_DETAIL_NAME].Clear();
            _dataset.Tables[DATASET_MASTER_NAME].Clear();
            _adapterTypeYear.Fill(_dataset, DATASET_MASTER_NAME);
            _adapterTypeYearDetail.Fill(_dataset, DATASET_DETAIL_NAME);
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
                _bindingTypeYear.DataSource = _dataset;
                _bindingTypeYear.DataMember = DATASET_MASTER_NAME;
                // Creates detail bindings
                _bindingTypeYearDetail.DataSource = _bindingTypeYear;
                _bindingTypeYearDetail.DataMember = DATASET_RELATION_NAME;
            }
            // Update the chart
            UpdateChartUI();
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
            // Default chars serie
            /*
            ... todo ...
            _series = new List<string>();
            _series.Add(REPORT_SERIE_BALANCE);
            */
            // Commands creation
            _commandTypeYear = CreateTypeYearCommand(UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection());
            _commandTypeYearDetail = CreateTypeYearDetailCommand(UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection());
            // Adapters
            _adapterTypeYear = new SqlDataAdapter(_commandTypeYear);
            _adapterTypeYearDetail = new SqlDataAdapter(_commandTypeYearDetail);
            // Binding sources
            _bindingTypeYear = new BindingSource();
            _bindingTypeYearDetail = new BindingSource();
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

        #endregion

        private void dgvTypeYear_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 
                DataRowView row = dgvTypeYearDetail.Rows[e.RowIndex].DataBoundItem as DataRowView;
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
                    page.ShowEntryGroupColumn = false;
                    // Form
                    FormPage form = new FormPage(page, args);
                    form.Width = 520;
                    form.ShowDialog();
                }
            }
        }

        private void dgvTypeYearDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 
                DataRowView row = dgvTypeYearDetail.Rows[e.RowIndex].DataBoundItem as DataRowView;
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
                    page.ShowEntryGroupColumn = false;
                    // Form
                    FormPage form = new FormPage(page, args);
                    form.Width = 520;
                    form.ShowDialog();
                }
            }
        }


        // -----------------------------------------------------------------------------------------------------------

    }
}
