using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ult.Commons;
using Ult.FamilyBalance.Model;
using Ult.FamilyBalance.UI.Pages;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Windows.Forms.DataVisualization.Charting;
using Ult.Util;

namespace Ult.FamilyBalance.UI
{
    public partial class PageReportTrendYear : UserControl, IPage
    {

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        private const string PAGE_TITLE                             = "Andamento Annuale";

        private const string DATASET_NAME                           = "ReportTrendYear";
        private const string DATATABLE_NAME                         = "TableTrendYear";

        private const string REPORT_SERIE_BALANCE                   = "SerieBalance";
        private const string REPORT_SERIE_OUTGOING_COUNT            = "SerieOutgoingCount";
        private const string REPORT_SERIE_OUTGOING_ENTRIES          = "SerieOutgoingEntries";
        private const string REPORT_SERIE_INCOMING_COUNT            = "SerieIncomingCount";
        private const string REPORT_SERIE_INCOMING_ENTRIES          = "SerieIncomingEntries";
        private const string REPORT_SERIE_DELTA_COUNT               = "SerieDeltaCount";
        private const string REPORT_SERIE_DELTA_ENTRIES             = "SerieDeltaEntries";
        private const string REPORT_SERIE_MISSING_INCOMING          = "SerieMissingIncoming";
        private const string REPORT_SERIE_MISSING_OUTGOING          = "SerieMissingOutgoing";

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        //
        private int _year;
        //
        private List<string> _series;
        // 
        private PageStatus _status;
        // 
        private UltFamilyBalanceContext _context;
        //
        private Logger _log;

        
        private DataSet _data;

        private SqlDataAdapter _adapterTrendYear;

        private SqlCommand _commandReportTrendYear;

        private BindingSource _bindingReportTrendYear;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        public PageReportTrendYear()
        {
            InitializeComponent();
        }

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get { return PAGE_TITLE; }
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
                return  _status != PageStatus.Processing &&
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
            dgvTrendYear.AutoGenerateColumns = false;
            // Grid binding
            dgvTrendYear.DataSource = _bindingReportTrendYear;
            // Chart binding
            chrTrendYear.DataSource = _bindingReportTrendYear;
            // Serie disabling
            chrTrendYear.Series[REPORT_SERIE_BALANCE].Enabled = false;
            chrTrendYear.Series[REPORT_SERIE_OUTGOING_COUNT].Enabled = false;
            chrTrendYear.Series[REPORT_SERIE_OUTGOING_ENTRIES].Enabled = false;
        }

        private void UpdateUI()
        {
            chrTrendYear.DataBind();
            UpdateFiltersUI();
        }

        private void UpdateChartUI()
        {
            foreach (Series serie in chrTrendYear.Series)
            {
                if (_series.Contains(serie.Name)) serie.Enabled = true;
                else serie.Enabled = false;
            }

            chrTrendYear.DataBind();

        }

        private void UpdateFiltersUI()
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(_year);
        }

        private SqlCommand CreateCommandTrendYear(SqlConnection connection, int year)
        {
            // Query
            string sql = "SELECT	[Year], " + 
		                 "       [Month], " +
                         "       [MonthName], " +
		                 "       [EntriesOutgoing], " + 
		                 "       [EntriesIncoming], " + 
		                 "       [EntriesDelta], " + 
		                 "       [CountBalance], " + 
		                 "       [CountOutgoing], " + 
		                 "       [CountIncoming], " + 
		                 "       [CountDelta], " + 
		                 "       [MissingIncoming], " + 
		                 "       [MissingOutgoing] " + 
                         "FROM vwReportTrendYear " + 
                         "WHERE [Year] = @year";
            // Command creation
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            // Year parameter
            SqlParameter paramYear = new SqlParameter();
            paramYear.ParameterName = "@year";
            paramYear.DbType = DbType.Int32;
            paramYear.Value = year;
            // Parameter adding
            cmd.Parameters.Add(paramYear);
            // Returns the command
            return cmd;
        }

        private void LoadData(int year)
        {
            // Sets parameters
            _commandReportTrendYear.Parameters["@year"].Value = year;
            // Data loading
            _data.Tables[DATATABLE_NAME].Clear();
            _adapterTrendYear.Fill(_data, DATATABLE_NAME);
        }

        private void BindData()
        {
            // Creates the bindings
            _bindingReportTrendYear.DataSource = _data;
            _bindingReportTrendYear.DataMember = DATATABLE_NAME;
            // Update the chart
            UpdateChartUI();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Init(params object[] args)
        {
            // STATUS: Active
            _status = PageStatus.Init;
            // Context
            _context = UltFamilyBalance.GetUltFamilyBalance().Context;
            // Parameters
            _year = (args.Length > 0) ? Convert.ToInt32(args[0]) : DateTime.Now.Year;
            // Dataset creation
            _data = new DataSet(DATASET_NAME);
            _data.Tables.Add(DATATABLE_NAME);
            // Default chars serie
            _series = new List<string>();
            _series.Add(REPORT_SERIE_BALANCE);
            // Commands creation
            _commandReportTrendYear = CreateCommandTrendYear(UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection(), _year);
            // Adapters
            _adapterTrendYear = new SqlDataAdapter(_commandReportTrendYear);
            // Binding sources
            _bindingReportTrendYear = new BindingSource();
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

        #endregion PUBLIC METHODS
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

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

        private void rbtBalance_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                _series.Clear();
                _series.Add(REPORT_SERIE_BALANCE);
                // Chart update
                UpdateChartUI();
            }
        }

        private void rbtOutgoing_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                _series.Clear();
                _series.Add(REPORT_SERIE_OUTGOING_COUNT);
                _series.Add(REPORT_SERIE_OUTGOING_ENTRIES);
                // Chart update
                UpdateChartUI();
            }
        }

        private void rbtIncoming_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                _series.Clear();
                _series.Add(REPORT_SERIE_INCOMING_COUNT);
                _series.Add(REPORT_SERIE_INCOMING_ENTRIES);
                // Chart update
                UpdateChartUI();
            }
        }

        private void rbtDelta_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                _series.Clear();
                _series.Add(REPORT_SERIE_DELTA_COUNT);
                _series.Add(REPORT_SERIE_DELTA_ENTRIES);
                // Chart update
                UpdateChartUI();
            }
        }

        private void rbtMissing_CheckedChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                _series.Clear();
                _series.Add(REPORT_SERIE_MISSING_INCOMING);
                _series.Add(REPORT_SERIE_MISSING_OUTGOING);
                // Chart update
                UpdateChartUI();
            }
        }

        // --

        #endregion PUBLIC METHODS
        // -----------------------------------------------------------------------------------------------------------

    }
}
