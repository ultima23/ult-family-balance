using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using Ult.Core.Utils;

namespace Ult.FamilyBalance
{
    public partial class FormExceptionReport : Form
    {

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTANTS

        private const int Height_HiddenDetails = 200;
        private const int Height_VisibleDetails = 470;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        bool _allowSave;

        bool _allowDetails;

        private string _title;

        private string _message;

        private string _description;

        private Exception _error;


        private StackTrace _stack;

        private StackFrame _callerFrame;

        private MethodBase _callerMethod;

        private Type _callerType;


        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        public FormExceptionReport(Exception error)
        {
            // Caller data
            _stack = new StackTrace(true);
            _callerFrame = _stack.GetFrame(1);
            _callerMethod = _callerFrame.GetMethod();
            _callerType = _callerMethod.GetType();
            // Initialization
            _error = error;
            _title = String.Format("Unhandled exception in {0}.{1}()", _callerType.Name, _callerMethod.Name);
            _message = String.Format("Unhandled exception in {0}.{1}()", _callerType.Name, _callerMethod.Name);
            _description = GetErrorDescription(error);
            _allowDetails = true;
            _allowSave = true;
            // Compoenents initialization
            InitializeComponent();
        }

        public FormExceptionReport(Exception error, string title, string message)
        {
            // Caller data
            _stack = new StackTrace(true);
            _callerFrame = _stack.GetFrame(2);
            _callerMethod = _callerFrame.GetMethod();
            _callerType = _callerMethod.GetType();
            // Initialization
            _error = error;
            _title = title;
            _message = message;
            _description = GetErrorDescription(error);
            _allowDetails = true;
            _allowSave = true;
            // Compoenents initialization
            InitializeComponent();
        }

        public FormExceptionReport(Exception error, string title, string message, string description, bool allow_details, bool allow_save)
        {
            // Caller data
            _stack = new StackTrace(true);
            _callerFrame = _stack.GetFrame(2);
            _callerMethod = _callerFrame.GetMethod();
            _callerType = _callerMethod.GetType();
            // Initialization
            _error = error;
            _title = title;
            _message = message;
            _description = description;
            _allowDetails = allow_details;
            _allowSave = allow_save;
            // Compoenents initialization
            InitializeComponent();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private string GetErrorDescription(Exception error)
        {
            StringBuilder description = new StringBuilder();
            // Check exception error
            if (!String.IsNullOrEmpty(error.Message))
            {
                description.AppendFormat("{0}", error.Message);
            }
            else
            {
                description.AppendFormat("{0}", error.GetType().Name);
            }
            return description.ToString();
        }

        private string GetErrorDetails(Exception error)
        {
            // builder
            StringBuilder details = new StringBuilder();
            details.AppendFormat("Scope details: \r\n");
            details.AppendFormat("  Class : {0} ({1})\r\n", _callerType.Name, _callerType.Namespace);
            details.AppendFormat("  Method : {0}\r\n", DebugUtils.FormatMethodSign(_callerMethod));
            details.AppendFormat("  File : {0}\r\n", _callerFrame.GetFileName());
            details.AppendFormat("  Row : {0}\r\n", _callerFrame.GetFileLineNumber());
            details.AppendFormat("  Column : {0}\r\n", _callerFrame.GetFileColumnNumber());
            details.AppendFormat("\r\n");
            //
            details.AppendFormat("Exception details: \r\n");
            details.AppendFormat("  Type: {0}\r\n", error.GetType().Name);
            details.AppendFormat("  Message: {0}\r\n", error.Message ?? "<none>");
            details.AppendFormat("  Source: {0}\r\n", error.Source ?? "<none>");
            details.AppendFormat("  Target Site: {0}\r\n", error.TargetSite != null ? DebugUtils.FormatMethodSign(error.TargetSite) : "<none>");
            details.AppendFormat("  Inner Exception: {0}\r\n", error.InnerException != null ? error.InnerException.Message : "<none>");
            details.AppendFormat("\r\n");
            details.AppendFormat("Exception stack: \r\n");
            details.AppendFormat(error.StackTrace);
            details.AppendFormat("\r\n");
            // Stack
            details.AppendFormat("Caller stack: \r\n");
            for (int i = 1; i < _stack.FrameCount; i++)
            {
                details.AppendFormat("  at {0}\r\n", DebugUtils.FormatStackFrame(_stack.GetFrame(i)));
            }
            details.AppendFormat("\r\n");
            return details.ToString();
        }

        private void ShowDetails()
        {
            btnToggleDetails.Text = "Hide Details";
            Height = Height_VisibleDetails;
        }

        private void HideDetails()
        {
            btnToggleDetails.Text = "Show Details";
            Height = Height_HiddenDetails;
        }

        private void ToggleDetails()
        {
            if (Height == Height_VisibleDetails)
            {
                HideDetails();
            }
            else
            {
                ShowDetails();
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT HANDLERS

        private void FormExceptionReport_Load(object sender, EventArgs e)
        {
            Text = _title;
            lblMessage.Text = _message;
            lblDescription.Text = _description;
            txtDetails.Text = GetErrorDetails(_error);
            btnToggleDetails.Visible = _allowDetails;
            // btnSaveReport.Visible = _allowSave;
            btnSaveReport.Visible = false;
        }

        private void btnToggleDetails_Click(object sender, EventArgs e)
        {
            ToggleDetails();
        }

        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
