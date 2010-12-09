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


namespace Ult.FamilyBalance.UI.Pages
{
    public partial class DetailEntry : UserControl, IDetail<Entry>
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS
    
        // 
        private EntryDirection _direction;
        // 
        private Entry _entry;
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
        public DetailEntry()
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

        public Entry Entity
        {
            get { return _entry; }
        }

        public bool HasPendingChanges
        {
            get { return _entry != null && _entry.EntityState != EntityState.Unchanged; }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private void RefreshTypes()
        {
            // Types list
            var types = from t in _context.Context.EntryTypes
                        where t.Direction.Id == _direction.Id
                        select t;
            //
            cmbEntityType.DisplayMember = "Name";
            cmbEntityType.DataSource = types;
        }

        /// <summary>
        /// 
        /// </summary>
        private void EntityToUI()
        {
            numAmount.Value = _entry.Amount;
            dtpEntityDate.Value = _entry.Date;
            txtEntryNote.Text = _entry.Note;
            cmbEntityType.SelectedItem = _entry.Type;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UIToEntity()
        {
            _entry.Amount = numAmount.Value;
            _entry.Date = dtpEntityDate.Value;
            _entry.Note = txtEntryNote.Text;
            _entry.Type = cmbEntityType.SelectedItem as EntryType;
            _entry.DateUpdate = DateTime.Now;
            _entry.DateInsert = (_entry.EntityState == EntityState.Added) ? DateTime.Now : _entry.DateInsert;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PUBLIC METHODS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Init(Entry entity, params object[] args)
        {
            // parameters check
            if (entity == null) throw new ArgumentNullException("entity", "Entity should not be null or empty");
            if (args.Length < 1) throw new ArgumentNullException("Parameters 'direction' is missing");
            if (!(args[0] is EntryDirection)) throw new ArgumentNullException("Parameters 'direction' is missing or wrong");
            // Direction
            _direction = args[0] as EntryDirection;
            // Logger
            _log = Logger.GetDefaultLogger();
            // Page initalization
            _context = UltFamilyBalance.GetUltFamilyBalance();
            _entry = entity;
            // Types refresh
            RefreshTypes();
            // Binds UI componenets
            EntityToUI();
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void Refresh(params object[] args)
        {
            numAmount.Focus();
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
                // Amout validation
                if (numAmount.Value <= 0)
                {
                    errorProvider.SetError(numAmount, "Amount should be greater than 0");
                    entity_verified = false;
                }
                // Type validation
                if (cmbEntityType.SelectedIndex == -1)
                {
                    errorProvider.SetError(cmbEntityType, String.Format("Entry type for entry of type {0} is required but not provided;", _entry.TypeName));
                    entity_verified = false;
                }
                else
                {
                    EntryType type = cmbEntityType.SelectedItem as EntryType;
                    // Note validation
                    if (type != null && type.NoteRequired > 0 && String.IsNullOrEmpty(txtEntryNote.Text))
                    {
                        errorProvider.SetError(txtEntryNote, String.Format("Note for entry of type {0} is required but not provided;", _entry.TypeName));
                        entity_verified = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // verify error
                entity_verified = false;
                // Log
                _log.Error("DetailOutgoingEntry > Verify() error: {0}", ex.Message);
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
                adding = _entry.EntityState == EntityState.Added;
                // Updating entity from controls 
                UIToEntity();
                // Object save
                _context.Context.SaveChanges();
                // Result
                result = adding ? IDetailResult.AddSucces : IDetailResult.UpdateSuccess;
                // Log
                _log.Info("Outgoing entry saved: {0}", _entry);
            }
            catch (OptimisticConcurrencyException)
            {
                _context.Context.Refresh(RefreshMode.ClientWins, _entry);
                // Result
                result = adding ? IDetailResult.AddFailed : IDetailResult.UpdateFailed;
            }
            catch (Exception ex)
            {
                // Result
                result = adding ? IDetailResult.AddFailed : IDetailResult.UpdateFailed;
                // Log
                _log.Error("DetailOutgoingEntry > Save() error: {0}", ex);
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
                _context.Context.Refresh(RefreshMode.StoreWins, _entry);
            }
            catch (Exception ex)
            {
                _log.Error("DetailOutgoingEntry > Cancel() error: {0}", ex);
                Tracer.Debug(ex);
                UIUtils.Error(ex.InnerException.Message);
            }
            return IDetailResult.Cancel;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
