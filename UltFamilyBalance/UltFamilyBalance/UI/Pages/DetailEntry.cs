﻿using System;
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

        /// <summary>
        /// 
        /// </summary>
        private void RefreshTypes()
        {
            // Types list
            var types = from t in _context.Context.EntryTypes
                        where t.Direction.Id == _direction.Id
                        // orderby t.Group.Id ascending
                        select t;
            //
            cmbEntryType.DisplayMember = "Name";
            cmbEntryType.DataSource = types;
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshUsers()
        {
            // User list
            var users = from u in _context.Context.Users
                        select u;
            //
            cmbEntryUser.DisplayMember = "Username";
            cmbEntryUser.DataSource = users;
        }

        /// <summary>
        /// 
        /// </summary>
        private void EntityToUI()
        {
            numEntryAmount.Value = _entry.Amount;
            dtpEntryDate.Value = _entry.Date;
            txtEntryNote.Text = _entry.Note;
            cmbEntryType.SelectedItem = _entry.Type;
            cmbEntryUser.SelectedItem = _entry.User;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UIToEntity()
        {
            _entry.Amount = numEntryAmount.Value;
            _entry.Date = dtpEntryDate.Value;
            _entry.Year = dtpEntryDate.Value.Year;
            _entry.Month = dtpEntryDate.Value.Month;
            _entry.Day = dtpEntryDate.Value.Day;
            _entry.Note = txtEntryNote.Text;
            _entry.Type = cmbEntryType.SelectedItem as EntryType;
            _entry.User = cmbEntryUser.SelectedItem as User;
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
            // Refresh
            RefreshTypes();
            RefreshUsers();
            // Binds UI componenets
            EntityToUI();
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public void Refresh(params object[] args)
        {
            numEntryAmount.Focus();
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
                if (numEntryAmount.Value <= 0)
                {
                    errorProvider.SetError(numEntryAmount, "L'importo è richiesto e deve essere maggiore di zero");
                    entity_verified = false;
                }
                // Type validation
                if (cmbEntryType.SelectedIndex == -1)
                {
                    errorProvider.SetError(cmbEntryType, String.Format("La categoria è richiestea e non è stata selezionata alcuna categoria", _entry.TypeName));
                    entity_verified = false;
                }
                else
                {
                    EntryType type = cmbEntryType.SelectedItem as EntryType;
                    // Note validation
                    if (type != null && type.NoteRequired > 0 && String.IsNullOrEmpty(txtEntryNote.Text))
                    {
                        errorProvider.SetError(txtEntryNote, String.Format("Le note per la categoria {0} sono richieste ma non sono state inserite", _entry.TypeName));
                        entity_verified = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // verify error
                entity_verified = false;
                // Log
                _log.Error("DetailEntry > Verify() error: {0}", ex.Message);
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
                _log.Error("DetailEntry > Save() error: {0}", ex);
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
                if (_entry.EntityState != EntityState.Added)
                {
                    _context.Context.Refresh(RefreshMode.StoreWins, _entry);
                }
                else
                {
                    _context.Context.Detach(_entry);
                }
            }
            catch (Exception ex)
            {
                _log.Error("DetailEntry > Cancel() error: {0}", ex);
                Tracer.Debug(ex);
                UIUtils.Error(ex.InnerException.Message);
            }
            return IDetailResult.Cancel;
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT HANDLERS

        private void DetailEntry_Load(object sender, EventArgs e)
        {
            numEntryAmount.Select(0, numEntryAmount.ToString().Length);
        }

        private void btnAmountCalc_Click(object sender, EventArgs e)
        {
            // Positioning
            Point pos = btnEntryAmountCalc.PointToScreen(new Point(0,0));
            // calc form
            FormCalc calc = new FormCalc();
            calc.Location = new Point(pos.X + btnEntryAmountCalc.Width - calc.Width, pos.Y + btnEntryAmountCalc.Height + 2);
            if (calc.ShowDialog() == DialogResult.OK)
            {
                numEntryAmount.Value = calc.Total;
            }
        }

        // ---

        #endregion
        // -----------------------------------------------------------------------------------------------------------

    }
}
