using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Ult.FamilyBalance.Model;
using Ult.Commons;
using Ult.Util;
using System.Globalization;


namespace Ult.FamilyBalance.UI.Pages
{
    public partial class DetailCreditCount : UserControl, IDetail<CreditCount>
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS
    
        // 
        private EntryDirection _direction;
        // 
        private CreditCount _creditCount;
        // Logger
        private Logger _log; 
        // 
        private UltFamilyBalance _context;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRUCTORS

        /// <summary>
        /// Constructor
        /// </summary>
        public DetailCreditCount()
        {
            //
            InitializeComponent();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        public Control Control
        {
            get { return this as Control; }
        }

        public CreditCount Entity
        {
            get { return _creditCount; }
        }

        public bool HasPendingChanges
        {
            get { return _creditCount != null && _creditCount.EntityState != EntityState.Unchanged; }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS


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

        /// <summary>
        /// 
        /// </summary>
        private void EntityToUI()
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(_creditCount.Year);
            cmbMonth.SelectedIndex = _creditCount.Month -1;
            numIncoming.Value = _creditCount.Incoming;
            numOutgoing.Value = _creditCount.Outgoing;
            numBalance.Value = _creditCount.Balance ?? 0;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UIToEntity()
        {
            _creditCount.Year = (int) cmbYear.SelectedItem;
            _creditCount.Month = cmbMonth.SelectedIndex + 1;
            _creditCount.Incoming = numIncoming.Value;
            _creditCount.Outgoing = numOutgoing.Value;
            // Balance value check
            if (numBalance.Value == 0)
            {
                _creditCount.Balance = null;
            }
            else
            {
                _creditCount.Balance = numBalance.Value;
            }
            _creditCount.DateUpdate = DateTime.Now;
            _creditCount.DateInsert = (_creditCount.EntityState == EntityState.Added) ? DateTime.Now : _creditCount.DateInsert;

        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Init(CreditCount creditCount, params object[] args)
        {
            // parameters check
            if (creditCount == null) throw new ArgumentNullException("entity", "Entity should not be null or empty");
            // Logger
            _log = Logger.GetDefaultLogger();
            // Page initalization
            _context = UltFamilyBalance.GetUltFamilyBalance();
            _creditCount = creditCount;
            // Combo years loading
            LoadYears();
            LoadMonths();
            // Binds UI componenets
            EntityToUI();
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void Refresh(params object[] args)
        {
            numIncoming.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public void UpdateSize(Size size)
        {
            this.Size = size;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Verify()
        {
            bool entity_verified = true;
            try
            {
                // clear previous errors
                errorProvider.Clear();
                // Incoming validation
                if (numIncoming.Value <= 0)
                {
                    errorProvider.SetError(numIncoming, "L'importo dell'entrata è richiesto e deve essere maggiore di zero");
                    entity_verified = false;
                }
                // Outgoing validation
                if (numOutgoing.Value <= 0)
                {
                    errorProvider.SetError(numOutgoing, "L'importo delle uscite è richiesto e deve essere maggiore di zero");
                    entity_verified = false;
                }
            }
            catch (Exception ex)
            {
                // verify error
                entity_verified = false;
                // Log
                _log.Error("DetailCreditCount > Verify() error: {0}", ex.Message);
                Tracer.Debug(ex);
                // User message
                UIUtils.Error(ex.InnerException.Message);
            }
            return entity_verified;
        }

        /// <summary>
        /// 
        /// </summary>
        public IDetailResult Save()
        {
            bool adding = false;
            IDetailResult result = IDetailResult.None;
            // execution
            try
            {
                // check if we are adding a new entry
                adding = _creditCount.EntityState == EntityState.Added;
                // Updating entity from controls 
                UIToEntity();
                // Object save
                _context.Context.SaveChanges();
                // Result
                result = adding ? IDetailResult.AddSucces : IDetailResult.UpdateSuccess;
                // Log
                _log.Info("Outgoing entry saved: {0}", _creditCount);
            }
            catch (OptimisticConcurrencyException)
            {
                _context.Context.Refresh(RefreshMode.ClientWins, _creditCount);
                // Result
                result = adding ? IDetailResult.AddFailed : IDetailResult.UpdateFailed;
            }
            catch (Exception ex)
            {
                // Result
                result = adding ? IDetailResult.AddFailed : IDetailResult.UpdateFailed;
                // Log
                _log.Error("DetailCreditCount > Save() error: {0}", ex);
                Tracer.Debug(ex);
                // User message
                UIUtils.Error(ex.InnerException.Message);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        public IDetailResult Cancel()
        {
            try
            {
                // checks for object state
                if (_creditCount.EntityState != EntityState.Added)
                {
                    _context.Context.Refresh(RefreshMode.StoreWins, _creditCount);
                }
                else
                {
                    _context.Context.Detach(_creditCount);
                }
            }
            catch (Exception ex)
            {
                _log.Error("DetailCreditCount > Cancel() error: {0}", ex);
                Tracer.Debug(ex);
                UIUtils.Error(ex.InnerException.Message);
            }
            return IDetailResult.Cancel;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------


        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT HANDLERS

        private void btnIncomingCalc_Click(object sender, EventArgs e)
        {
            // Positioning
            Point pos = btnIncomingCalc.PointToScreen(new Point(0,0));
            // calc form
            FormCalc calc = new FormCalc();
            calc.Location = new Point(pos.X + btnIncomingCalc.Width - calc.Width, pos.Y + btnIncomingCalc.Height + 2);
            if (calc.ShowDialog() == DialogResult.OK)
            {
                numIncoming.Value = calc.Total;
            }
        }

        #endregion

        private void btnOutgoingCalc_Click(object sender, EventArgs e)
        {
            // Positioning
            Point pos = btnOutgoingCalc.PointToScreen(new Point(0,0));
            // calc form
            FormCalc calc = new FormCalc();
            calc.Location = new Point(pos.X + btnOutgoingCalc.Width - calc.Width, pos.Y + btnOutgoingCalc.Height + 2);
            if (calc.ShowDialog() == DialogResult.OK)
            {
                numOutgoing.Value = calc.Total;
            }
        }

        private void btnBalanceCalc_Click(object sender, EventArgs e)
        {
            // Positioning
            Point pos = btnBalanceCalc.PointToScreen(new Point(0,0));
            // calc form
            FormCalc calc = new FormCalc();
            calc.Location = new Point(pos.X + btnBalanceCalc.Width - calc.Width, pos.Y + btnBalanceCalc.Height + 2);
            if (calc.ShowDialog() == DialogResult.OK)
            {
                numBalance.Value = calc.Total;
            }
        }
        // -----------------------------------------------------------------------------------------------------------

    }
}
