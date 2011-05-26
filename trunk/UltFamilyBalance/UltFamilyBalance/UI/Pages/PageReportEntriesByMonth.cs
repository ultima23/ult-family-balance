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
using Ult.Util;

namespace Ult.FamilyBalance.UI
{
    public partial class PageReportEntriesByMonth : UserControl, IPage
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        private const string DATASET_REPORT_NAME                    = "EntriesReport";
        private const string REPORT_DATATABLE_NAME                  = "EntriesByMonth";
        private const string REPORT_BY_TYPE_DATATABLE_NAME          = "EntriesByMonthAndType";

        private const string REPORT_RELATION_NAME                   = REPORT_DATATABLE_NAME + "_" + REPORT_BY_TYPE_DATATABLE_NAME;
        private const string REPORT_RELATION_YEAR_FIELD             = "Year";
        private const string REPORT_RELATION_MONTH_FIELD            = "Month";

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        //
        private int _year;
        //
        private EntryDirection _direction;
        // 
        private PageStatus _status;
        // 
        private UltFamilyBalanceContext _context;
        //
        private Logger _log;

        
        private DataSet _data;

        private SqlDataAdapter _adapterEntryReport;
        private SqlDataAdapter _adapterEntryReportByMonth;

        private SqlCommand _commandEntryReport;
        private SqlCommand _commandEntryReportByType;

        private BindingSource _bindingEntryReport;
        private BindingSource _bindingEntryReportByType;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        public PageReportEntriesByMonth()
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
            get { return _direction == EntryDirection.OutgoingReference ? "Report Mensile Uscite" : "Report Mensile Entrate"; }
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
        #region PRIVATE  METHODS

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
            dgvEntriesReport.AutoGenerateColumns = false;
            dgvEntriesReportByType.AutoGenerateColumns = false;
            // Grid binding
            dgvEntriesReport.DataSource = _bindingEntryReport;
            dgvEntriesReportByType.DataSource = _bindingEntryReportByType;
            // Chart binding
            chrReportByType.DataSource = _bindingEntryReportByType;
            chrReportByType.Series["PieReport"].XValueMember = "Type";
            chrReportByType.Series["PieReport"].YValueMembers = "Perc";
            chrReportByType.Series["PieReport"].IsValueShownAsLabel = true;
            chrReportByType.Series["PieReport"]["PieLabelStyle"] = "Outside";
            chrReportByType.Series["PieReport"].Label = "#VALX: #VALY{#0.## '%'}";
            #region threshold settings
            // Set the threshold under which all points will be collected
            chrReportByType.Series["PieReport"]["CollectedThreshold"] = "5";
            // Set the threshold type to be a percentage of the pie
            // When set to false, this property uses the actual value to determine the collected threshold
            chrReportByType.Series["PieReport"]["CollectedThresholdUsePercent"] = "true";
            // Set the label of the collected pie slice
            chrReportByType.Series["PieReport"]["CollectedLabel"] = "Altro";
            // Set the legend text of the collected pie slice
            chrReportByType.Series["PieReport"]["CollectedLegendText"] = "Altro";
            // Set the collected pie slice to be exploded
            chrReportByType.Series["PieReport"]["CollectedSliceExploded"]= "false";
            // Set the color of the collected pie slice
            chrReportByType.Series["PieReport"]["CollectedColor"] = "Green";
            // Set the tooltip of the collected pie slice
            chrReportByType.Series["PieReport"]["CollectedToolTip"] = "Altro";
            #endregion threshold settings
            //
            chrReportByType.Legends[0].Enabled = false;
        }

        private void UpdateUI()
        {
            chrReportByType.DataBind();
            UpdateFiltersUI();
        }

        private void UpdateFiltersUI()
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(_year);
        }

        private SqlCommand CreateCommandEntryReport(SqlConnection connection, int direction, int year)
        {
            // Query
            string sql = "SELECT   [Year], " + 
                         "         [Month], " +
                         "         [MonthName], " +
                         "         [Count], " +
                         "         [Total] " + 
                         "FROM vwEntriesByMonth " +
                         "WHERE      [EntryDirectionId] = @direction " +
                         "       AND [Year] = @year " +
                         "ORDER BY [Month] ASC";
            // Command creation
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            // Direction parameter
            SqlParameter paramDirection = new SqlParameter();
            paramDirection.ParameterName = "@direction";
            paramDirection.DbType = DbType.Int32;
            paramDirection.Value = direction;
            // Year parameter
            SqlParameter paramYear = new SqlParameter();
            paramYear.ParameterName = "@year";
            paramYear.DbType = DbType.Int32;
            paramYear.Value = year;
            // Parameter adding
            cmd.Parameters.Add(paramDirection);
            cmd.Parameters.Add(paramYear);
            // Returns the command
            return cmd;
        }

        private SqlCommand CreateCommandEntryReportByType(SqlConnection connection, int direction, int year)
        {
            // Query
            string sql = "SELECT   [Year], " + 
                         "         [Month], " +
                         "         [MonthName], " +
                         "         [Count], " +
                         "         [Type], " +
                         "         [Total], " + 
                         "         [Perc], " +
                         "         [EntryTypeId] " +
                         "FROM vwEntriesByMonthAndType " +
                         "WHERE      [EntryDirectionId] = @direction " +
                         "       AND [Year] = @year " +
                         "ORDER BY [Total] DESC";
            // Command creation
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            // Direction parameter
            SqlParameter paramDirection = new SqlParameter();
            paramDirection.ParameterName = "@direction";
            paramDirection.DbType = DbType.Int32;
            paramDirection.Value = direction;
            // Year parameter
            SqlParameter paramYear = new SqlParameter();
            paramYear.ParameterName = "@year";
            paramYear.DbType = DbType.Int32;
            paramYear.Value = year;
            // Parameter adding
            cmd.Parameters.Add(paramDirection);
            cmd.Parameters.Add(paramYear);
            // Returns the command
            return cmd;
        }

        private void LoadData(int direction, int year)
        {
            // Sets parameters
            _commandEntryReport.Parameters["@year"].Value = year;
            _commandEntryReportByType.Parameters["@year"].Value = year;
            _commandEntryReport.Parameters["@direction"].Value = direction;
            _commandEntryReportByType.Parameters["@direction"].Value = direction;
            // Data loading
            _data.Tables[REPORT_BY_TYPE_DATATABLE_NAME].Clear();
            _data.Tables[REPORT_DATATABLE_NAME].Clear();
            _adapterEntryReport.Fill(_data, REPORT_DATATABLE_NAME);
            _adapterEntryReportByMonth.Fill(_data, REPORT_BY_TYPE_DATATABLE_NAME);
        }

        private void BindData()
        {
            if (!_data.Relations.Contains(REPORT_RELATION_NAME))
            {
                // Create relation between tables
                _data.Relations.Add( new DataRelation(REPORT_RELATION_NAME, 
                                                      _data.Tables[REPORT_DATATABLE_NAME].Columns[REPORT_RELATION_MONTH_FIELD], 
                                                      _data.Tables[REPORT_BY_TYPE_DATATABLE_NAME].Columns[REPORT_RELATION_MONTH_FIELD]));
                // Creates the bindings
                _bindingEntryReport.DataSource = _data;
                _bindingEntryReport.DataMember = REPORT_DATATABLE_NAME;
                // Bindings report detail
                _bindingEntryReportByType.DataSource = _bindingEntryReport;
                _bindingEntryReportByType.DataMember = REPORT_RELATION_NAME;
                _bindingEntryReportByType.Sort = "Perc DESC";
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Init(params object[] args)
        {
            // STATUS: Active
            _status = PageStatus.Active;
            // Context
            _context = UltFamilyBalance.GetUltFamilyBalance().Context;
            // Parameters
            _direction = args[0] as EntryDirection;
            _year = (args.Length > 1) ? Convert.ToInt32(args[1]) : DateTime.Now.Year;
            // Dataset creation
            _data = new DataSet(DATASET_REPORT_NAME);
            _data.Tables.Add(REPORT_DATATABLE_NAME);
            _data.Tables.Add(REPORT_BY_TYPE_DATATABLE_NAME);
            // Commands creation
            _commandEntryReport = CreateCommandEntryReport(UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection(),_direction.Id, _year);
            _commandEntryReportByType = CreateCommandEntryReportByType(UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection(),_direction.Id, _year);
            // Adapters
            _adapterEntryReport = new SqlDataAdapter(_commandEntryReport);
            _adapterEntryReportByMonth = new SqlDataAdapter(_commandEntryReportByType);
            // Binding sources
            _bindingEntryReport = new BindingSource();
            _bindingEntryReportByType = new BindingSource();
            // UI initialization
            InitUI();
        }

        public void Open(Size size)
        {
            // STATUS: Processing
            _status = PageStatus.Processing;
            // Loads the data
            LoadData(_direction.Id, _year);
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
            _direction = (args.Length > 0) ? args[0] as EntryDirection : _direction;
            _year = (args.Length > 1) ? Convert.ToInt32(args[1]) : _year;
            // Relation check and creation
            LoadData(_direction.Id, _year);
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
                    Refresh(_direction, year);
                }
            }
        }

        private void dgvEntriesReport_SelectionChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                chrReportByType.DataBind();
            }
        }

        private void dgvEntriesReportByType_SelectionChanged(object sender, EventArgs e)
        {
            if (_status != PageStatus.Processing)
            {
                if (dgvEntriesReportByType.CurrentCell != null)
                {
                    //
                    int index = dgvEntriesReportByType.CurrentCell.RowIndex;
			        // Explode selected country
                    for (int i=0; i<chrReportByType.Series["PieReport"].Points.Count; i++)
			        {
				        chrReportByType.Series["PieReport"].Points[i]["Exploded"] = i == index ? "true" : "false";
			        }
                }
            }
        }

        private void dgvEntriesReportByType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 
                DataRowView row = dgvEntriesReportByType.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (row != null)
                {
                    // Detail filters
                    object[] args = new object[] { row["EntryTypeId"], 
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
            }
        }

        // --

        #endregion PUBLIC METHODS
        // -----------------------------------------------------------------------------------------------------------

    }
}
