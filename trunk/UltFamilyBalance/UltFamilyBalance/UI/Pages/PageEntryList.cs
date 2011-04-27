using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Ult.FamilyBalance.Model;
using Ult.Util;

namespace Ult.FamilyBalance.UI.Pages
{
    public partial class PageEntryList : UserControl, IPage
    {


        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        protected const string   DATASET_ENTRY_LIST_NAME = "EntryList";
        protected const string   DATATABLE_ENTRY_LIST_NAME = "EntryListData";

        protected const string   QUERY_PARAM_TYPE = "@type";
        protected const string   QUERY_PARAM_YEAR = "@year";
        protected const string   QUERY_PARAM_QUARTER = "@quarter";
        protected const string   QUERY_PARAM_MONTH = "@month";

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        // 
        private SqlConnection _connection;
        // 
        private PageStatus _status;

        // Columns
        private bool _showEntryGroupColumn;

        private bool _showEntryTypeColumn;

        // Category name
        private string _typeName;

        // Filter parameters
        private int? _filterType;
        private int? _filterYear;
        private int? _filterQuarter;
        private int? _filterMonth;

        //
        private DataSet _dataEntries;
        //
        private SqlDataAdapter _adapterEntries;
        //
        private SqlCommand _commandEntries;
        //
        private BindingSource _bindingEntries;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        public PageEntryList()
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
            get 
            { 
                StringBuilder sb = new StringBuilder();
                sb.Append(" Uscite");
                if (!String.IsNullOrEmpty(_typeName)) sb.AppendFormat(" - Categoria: {0} ", _typeName);
                if (_filterYear != null) sb.AppendFormat(" - Anno: {0} ", _filterYear.ToString());
                if (_filterQuarter != null) sb.AppendFormat(" - Quarter: {0} ", _filterQuarter.ToString());
                if (_filterMonth != null) sb.AppendFormat(" - Mese: {0} ", DateTimeUtils.GetMonthName((int)_filterMonth));
                return sb.ToString(); 
            }
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
            get { return _status != PageStatus.Processing &&
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

        #endregion IPage Members

        public bool ShowEntryGroupColumn
        {
            get { return _showEntryGroupColumn; }
            set { _showEntryGroupColumn = value; }
        }

        public bool ShowEntryTypeColumn
        {
            get { return _showEntryTypeColumn; }
            set { _showEntryTypeColumn = value; }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private void DecodeArgs(params object[] args)
        {
            if (args != null)
            {
                _filterType = null;
                _filterYear = null;
                _filterQuarter = null;
                _filterMonth = null;
                _typeName = string.Empty;
                if (args.Length > 0 && args[0] is Int32) _filterType = Convert.ToInt32(args[0]); // Entry type params
                if (args.Length > 1 && args[1] is Int32) _filterYear = Convert.ToInt32(args[1]); // Entry year
                if (args.Length > 2 && args[2] is Int32) _filterQuarter = Convert.ToInt32(args[2]); // Entry quaerter
                if (args.Length > 3 && args[3] is Int32) _filterMonth = Convert.ToInt32(args[3]); // Entry month
                if (args.Length > 4 && args[4] is String) _typeName = args[4].ToString(); // Entry Type name
            }
        }

        private SqlCommand CreateEntriesListCommand(SqlConnection connection)
        {
            // Query
            string sql = "SELECT EntryId, " +
		                 "       EntryAmount, " +
		                 "       EntryDate, " +
		                 "       EntryTypeId, " +
		                 "       EntryTypeName, " +
		                 "       EntryTypeDesc, " +
		                 "       EntryTypeGroupId, " +
		                 "       EntryTypeGroupName, " +
		                 "       EntryTypeGroupDesc, " +
		                 "       EntryNote, " +
                         "       UserUsername " +
                         " FROM vwEntries " +
                         " WHERE		( ISNULL(" + QUERY_PARAM_TYPE + ", 0) = 0 OR EntryTypeId = " + QUERY_PARAM_TYPE + " ) " +
		                 "        AND	( ISNULL(" + QUERY_PARAM_YEAR + ", 0) = 0 OR EntryYear = " + QUERY_PARAM_YEAR + " ) " +
		                 "        AND	( ISNULL(" + QUERY_PARAM_QUARTER + ", 0) = 0 OR EntryQuarter = " + QUERY_PARAM_QUARTER + " ) "+
		                 "        AND	( ISNULL(" + QUERY_PARAM_MONTH + ", 0) = 0 OR EntryMonth = " + QUERY_PARAM_MONTH + " ) ";
            // Command creation
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            // Direction parameter
            SqlParameter paramDirection = new SqlParameter();
            paramDirection.ParameterName = QUERY_PARAM_TYPE;
            paramDirection.DbType = DbType.Int32;
            // Year parameter
            SqlParameter paramYear = new SqlParameter();
            paramYear.ParameterName = QUERY_PARAM_YEAR;
            paramYear.DbType = DbType.Int32;
            // Quarter parameter
            SqlParameter paramQuarter = new SqlParameter();
            paramQuarter.ParameterName = QUERY_PARAM_QUARTER;
            paramQuarter.DbType = DbType.Int32;
            // Quarter parameter
            SqlParameter paramMonth = new SqlParameter();
            paramMonth.ParameterName = QUERY_PARAM_MONTH;
            paramMonth.DbType = DbType.Int32;
            // Parameter adding
            cmd.Parameters.Add(paramDirection);
            cmd.Parameters.Add(paramYear);
            cmd.Parameters.Add(paramQuarter);
            cmd.Parameters.Add(paramMonth);
            // Returns the command
            return cmd;
        }

        private void LoadData(int? type, int? year, int? quarter, int? month)
        {
            // Setup params

            // Parameter update
            if (_filterType != null)
            {
                _commandEntries.Parameters[QUERY_PARAM_TYPE].Value = _filterType;
            }
            else
            {
                _commandEntries.Parameters[QUERY_PARAM_TYPE].Value = DBNull.Value;
            }
            if (_filterYear != null)
            {
                _commandEntries.Parameters[QUERY_PARAM_YEAR].Value = _filterYear;
            }
            else
            {
                _commandEntries.Parameters[QUERY_PARAM_YEAR].Value = DBNull.Value;
            }
            if (_filterQuarter != null)
            {
                _commandEntries.Parameters[QUERY_PARAM_QUARTER].Value = _filterQuarter;
            }
            else
            {
                _commandEntries.Parameters[QUERY_PARAM_QUARTER].Value = DBNull.Value;
            }            
            if (_filterMonth != null)
            {
                _commandEntries.Parameters[QUERY_PARAM_MONTH].Value = _filterMonth;
            }
            else
            {
                _commandEntries.Parameters[QUERY_PARAM_MONTH].Value = DBNull.Value;
            }
            // Clear dataset data
            _dataEntries.Tables[DATATABLE_ENTRY_LIST_NAME].Clear();
            // Fill 
            _adapterEntries.Fill(_dataEntries.Tables[DATATABLE_ENTRY_LIST_NAME]);
        }

        private void BindData()
        {
            _bindingEntries.DataSource = _dataEntries.Tables[DATATABLE_ENTRY_LIST_NAME];
            _bindingEntries.Sort = "EntryDate ASC";
        }

        private void InitUI()
        {
            // Columns creation
            dgvEntries.AutoGenerateColumns = false;
            dgvEntries.DataSource = _bindingEntries;
        }

        private void UpdateUI()
        {
            UpdateGridUI();
            UpdateTotalUI();
        }

        private void UpdateGridUI()
        {
            ColEntryGroup.Visible = _showEntryGroupColumn;
            ColEntryType.Visible = _showEntryTypeColumn;
        }

        private void UpdateTotalUI()
        {
            decimal total = 0;
            foreach (DataRow row in _dataEntries.Tables[DATATABLE_ENTRY_LIST_NAME].Rows)
            {
                total += Convert.ToDecimal(row["EntryAmount"]);
            }
            lblTotal.Text = string.Format("{0:C2}", total);
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        public void Init(params object[] args)
        {
            // Connection
            _connection = UltFamilyBalance.GetUltFamilyBalance().GetSqlConnection();
            // Dataset creation
            _dataEntries = new DataSet(DATASET_ENTRY_LIST_NAME);
            _dataEntries.Tables.Add(DATATABLE_ENTRY_LIST_NAME);
            // Commands creation
            _commandEntries = CreateEntriesListCommand(_connection);
            // Adapters creation
            _adapterEntries = new SqlDataAdapter(_commandEntries);
            // Binding sources
            _bindingEntries = new BindingSource();
            // Arguments decode
            DecodeArgs(args);
            // UI initialization
            InitUI();
        }

        public void Open(Size size)
        {
            // STATUS: Processing
            _status = PageStatus.Processing;
            // Loads the data
            LoadData(_filterType, _filterYear, _filterQuarter, _filterMonth);
            // BindData data to UI
            BindData();
            // Updating size
            UpdateSize(size);
            // STATUS: Active
            _status = PageStatus.Active;
        }

        public void Close()
        {
            // STATUS: Active
            _status = PageStatus.Ready;
        }

        public void Refresh(params object[] args)
        {
            // STATUS: Processing
            _status = PageStatus.Processing;
            // Arguments decode
            DecodeArgs(args);
            // Loads the data
            LoadData(_filterType, _filterYear, _filterQuarter, _filterMonth);
            // 
            UpdateUI();
            // STATUS: Active
            _status = PageStatus.Active;
        }

        public void UpdateSize(Size size)
        {
            Size = size;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------


    }
}
