using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Ult.FamilyBalance.Model;
using System.Data.SqlClient;
using Ult.Util;

namespace Ult.FamilyBalance.UI.Pages
{
    public partial class PageReportTrendMonth : UserControl, IPage
    {


        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        private const string PAGE_TITLE                             = "Andamento Mensile";

        private const string DATASET_NAME                           = "ReportTrendMonth";
        private const string DATATABLE_NAME                         = "TableTrendMonth";

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        //
        private int _year;
        // 
        private PageStatus _status;
        // 
        private UltFamilyBalanceContext _context;
        //
        private DataSet _data;
        //
        private SqlCommand _commandReportTrendMonth;
        //
        private SqlDataAdapter _adapterTrendMonth;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        public PageReportTrendMonth()
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
        }

        private void UpdateUI()
        {
            UpdateFiltersUI();
            UpdateDataUI();
        }

        private void UpdateDataUI()
        {

            if (_data.Tables[DATATABLE_NAME].Rows.Count > 0)
            {
                // Row
                DataRow row = _data.Tables[DATATABLE_NAME].Rows[0];
                // 
                lblLastMonth.Text           = row["MonthLastName"].ToString();
                lblMonthCount.Text          = row["MonthCount"].ToString();
                lblTotIn.Text               = String.Format("{0:#0.00} €", row["IncomingTotal"]);
                lblTotOut.Text              = String.Format("{0:#0.00} €", row["OutgoingTotal"]);
                lblTotGain.Text             = String.Format("{0:#0.00} €", row["DeltaTotal"]);
                lblTotExtra.Text            = String.Format("{0:#0.00} €", row["ExtraTotal"]);
                lblMinIn.Text               = String.Format("{0:#0.00} €", row["IncomingMin"]);
                lblMinOut.Text              = String.Format("{0:#0.00} €", row["OutgoingMin"]);
                lblMinGain.Text             = String.Format("{0:#0.00} €", row["DeltaMin"]);
                lblMinExtra.Text            = String.Format("{0:#0.00} €", row["ExtraMin"]);
                lblMaxIn.Text               = String.Format("{0:#0.00} €", row["IncomingMax"]);
                lblMaxOut.Text              = String.Format("{0:#0.00} €", row["OutgoingMax"]);
                lblMaxGain.Text             = String.Format("{0:#0.00} €", row["DeltaMax"]);
                lblMaxExtra.Text            = String.Format("{0:#0.00} €", row["ExtraMax"]);
                lblAvgIn.Text               = String.Format("{0:#0.00} €", row["IncomingAvg"]);
                lblAvgOut.Text              = String.Format("{0:#0.00} €", row["OutgoingAvg"]);
                lblAvgGain.Text             = String.Format("{0:#0.00} €", row["DeltaAvg"]);
                lblAvgExtra.Text            = String.Format("{0:#0.00} €", row["ExtraAvg"]);
                lblCurrBalance.Text         = String.Format("{0:#0.00} €", row["BalanceCurrent"]);
                lblMinBalance.Text          = String.Format("{0:#0.00} €", row["BalanceMin"]);
                lblMaxBalance.Text          = String.Format("{0:#0.00} €", row["BalanceMax"]);
                lblTotInNoExtra.Text        = String.Format("{0:#0.00} €", row["IncomingTotal"]);
                lblTotOutNoExtra.Text       = String.Format("{0:#0.00} €", row["OutgoingTotalNoExtra"]);
                lblTotGainNoExtra.Text      = String.Format("{0:#0.00} €", row["DeltaTotalNoExtra"]);
                lblMinInNoExtra.Text        = String.Format("{0:#0.00} €", row["IncomingMin"]);
                lblMinOutNoExtra.Text       = String.Format("{0:#0.00} €", row["OutgoingMinNoExtra"]);
                lblMinGainNoExtra.Text      = String.Format("{0:#0.00} €", row["DeltaMinNoExtra"]);
                lblMaxInNoExtra.Text        = String.Format("{0:#0.00} €", row["IncomingMax"]);
                lblMaxOutNoExtra.Text       = String.Format("{0:#0.00} €", row["OutgoingMaxNoExtra"]);
                lblMaxGainNoExtra.Text      = String.Format("{0:#0.00} €", row["DeltaMaxNoExtra"]);
                lblAvgInNoExtra.Text        = String.Format("{0:#0.00} €", row["IncomingAvg"]);
                lblAvgOutNoExtra.Text       = String.Format("{0:#0.00} €", row["OutgoingAvgNoExtra"]);
                lblAvgGainNoExtra.Text      = String.Format("{0:#0.00} €", row["DeltaAvgNoExtra"]);
                lblCurrBalanceNoExtra.Text  = String.Format("{0:#0.00} €", row["BalanceCurrentNoExtra"]);
                lblMinBalanceNoExtra.Text   = String.Format("{0:#0.00} €", row["BalanceMinNoExtra"]);
                lblMaxBalanceNoExtra.Text   = String.Format("{0:#0.00} €", row["BalanceMaxNoExtra"]);

            }
            else
            {
                // 
                lblLastMonth.Text           = string.Empty;
                lblMonthCount.Text          = string.Empty;
                lblTotIn.Text               = string.Empty;
                lblTotOut.Text              = string.Empty;
                lblTotGain.Text             = string.Empty;
                lblTotExtra.Text            = string.Empty;
                lblMinIn.Text               = string.Empty;
                lblMinOut.Text              = string.Empty;
                lblMinGain.Text             = string.Empty;
                lblMinExtra.Text            = string.Empty;
                lblMaxIn.Text               = string.Empty;
                lblMaxOut.Text              = string.Empty;
                lblMaxGain.Text             = string.Empty;
                lblMaxExtra.Text            = string.Empty;
                lblAvgIn.Text               = string.Empty;
                lblAvgOut.Text              = string.Empty;
                lblAvgGain.Text             = string.Empty;
                lblAvgExtra.Text            = string.Empty;
                lblCurrBalance.Text         = string.Empty;
                lblMinBalance.Text          = string.Empty;
                lblMaxBalance.Text          = string.Empty;
                lblTotInNoExtra.Text        = string.Empty;
                lblTotOutNoExtra.Text       = string.Empty;
                lblTotGainNoExtra.Text      = string.Empty;
                lblMinInNoExtra.Text        = string.Empty;
                lblMinOutNoExtra.Text       = string.Empty;
                lblMinGainNoExtra.Text      = string.Empty;
                lblMaxInNoExtra.Text        = string.Empty;
                lblMaxOutNoExtra.Text       = string.Empty;
                lblMaxGainNoExtra.Text      = string.Empty;
                lblAvgInNoExtra.Text        = string.Empty;
                lblAvgOutNoExtra.Text       = string.Empty;
                lblAvgGainNoExtra.Text      = string.Empty;
                lblCurrBalanceNoExtra.Text  = string.Empty;
                lblMinBalanceNoExtra.Text   = string.Empty;
                lblMaxBalanceNoExtra.Text   = string.Empty;
            }
        }

        private void UpdateFiltersUI()
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(_year);
        }

        private SqlCommand CreateCommandTrendMonth(SqlConnection connection, int year)
        {
            // Query
            string sql = "SELECT    [Year], " +                     // 0
		                 "          [MonthCount], " +               // 1
                         "          [MonthLast], " +                // 2
                         "          [MonthLastName], " +            // 3
		                 "          [BalanceCurrent], " +           // 4
		                 "          [BalanceMin], " +               // 5
		                 "          [BalanceMax], " +               // 6
		                 "          [IncomingTotal], " +            // 7
		                 "          [IncomingMin], " +              // 8
		                 "          [IncomingMax], " +              // 9
		                 "          [IncomingAvg], " +              // 10
		                 "          [OutgoingTotal], " +            // 11
		                 "          [OutgoingMin], " +              // 12
		                 "          [OutgoingMax], " +              // 13
		                 "          [OutgoingAvg], " +              // 14
		                 "          [DeltaTotal], " +               // 15
		                 "          [DeltaMin], " +                 // 16
		                 "          [DeltaMax], " +                 // 17
		                 "          [DeltaAvg], " +                 // 18
		                 "          [BalanceCurrentNoExtra], " +    // 19
                         "          [BalanceMinNoExtra], " +        // 20
                         "          [BalanceMaxNoExtra], " +        // 21
		                 "          [OutgoingTotalNoExtra], " +     // 22
		                 "          [OutgoingMinNoExtra], " +       // 23
		                 "          [OutgoingMaxNoExtra], " +       // 24
		                 "          [OutgoingAvgNoExtra], " +       // 25
		                 "          [DeltaTotalNoExtra], " +        // 26
		                 "          [DeltaMinNoExtra], " +          // 27
		                 "          [DeltaMaxNoExtra], " +          // 28
		                 "          [DeltaAvgNoExtra], " +          // 29
                         "          [ExtraTotal], " +               // 30
                         "          [ExtraMin], " +                 // 31
                         "          [ExtraMax], " +                 // 32
                         "          [ExtraAvg] " +                  // 33
                         "FROM vwReportTrendMonth " + 
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
            _commandReportTrendMonth.Parameters["@year"].Value = year;
            // Data loading
            _data.Tables[DATATABLE_NAME].Clear();
            _adapterTrendMonth.Fill(_data, DATATABLE_NAME);

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
            // Commands creation
            _commandReportTrendMonth = CreateCommandTrendMonth(UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection(), _year);
            // Adapters
            _adapterTrendMonth = new SqlDataAdapter(_commandReportTrendMonth);
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
            // UI Updating
            UpdateUI();
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

        // ---
    
        // -----------------------------------------------------------------------------------------------------------


    }
}
