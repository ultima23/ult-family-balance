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
    public partial class PageEntry : UserControl, IDetail<Entry>
    {

        //
        private Entry _entry;
        //
        private UltFamilyBalance _context;

        /// <summary>
        /// Constructor
        /// </summary>
        public PageEntry()
        {
            //
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        protected void Bind()
        {
            //
            maskedEntityAmount.DataBindings.Add("Text", _entry, "Amount");
            dateEntityDate.DataBindings.Add("Value", _entry, "Date");
            textEntryNote.DataBindings.Add("Text", _entry, "Note");
            //
            comboEntityType.DisplayMember = "Name";
            comboEntityType.DataSource = _context.Context.EntryTypes;
            comboEntityType.DataBindings.Add("SelectedItem", _entry, "Type");
        }

        /// <summary>
        /// 
        /// </summary>
        public Entry Entity
        {
            get { return _entry; }
        }

        public bool HasPendingChanges
        {
            get { return _entry != null && _entry.EntityState != EntityState.Unchanged; }
        }

        public void Init(Entry entity)
        {
            // Page initalization
            _context = UltFamilyBalance.GetUltFamilyBalance();
            _entry = entity;
            // Binds UI componenets
            Bind();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.GetDefaultLogger().Debug(_entry.ToString());

                _context.Context.AddToEntries(_entry);
                _context.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                UIUtils.Message(ex.InnerException.Message);
                Tracer.Debug(ex);
            }
        }

        public void Refresh(params object[] args)
        {
            throw new NotImplementedException();
        }

        public void UpdateSize(Size size)
        {
            this.Size = size;
        }

        public Control Control
        {
            get { return this as Control; }
        }

        public void Save()
        {
            try
            {
                Logger.GetDefaultLogger().Debug(_entry.ToString());

                _context.Context.AddToEntries(_entry);
                _context.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                UIUtils.Message(ex.InnerException.Message);
                Tracer.Debug(ex);
            }
        }

        public void Cancel()
        {
            try
            {
                _context.Context.Refresh(RefreshMode.StoreWins, _entry);
            }
            catch (Exception ex)
            {
                UIUtils.Message(ex.InnerException.Message);
                Tracer.Debug(ex);
            }
        }
    }
}
