using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ult.Util;

namespace Ult.FamilyBalance.UI
{
    public partial class FormCalc : Form
    {

        // -----------------------------------------------------------------------------------------------------------
        #region FIELDS

        decimal _total;

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region CONSTRCUCTORS

        public FormCalc()
        {
            InitializeComponent();
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PROPERTIES

        public decimal Total
        {
            get { return _total; }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region PRIVATE METHODS

        private void Add(decimal value)
        {
            if (value > 0)
            {
                lstItems.Items.Add(String.Format("{0:#0.00} €", value));
                _total += value;
                // Update UI
                UpdateTotalUI();
            }
            SelectValue();
        }

        private void SubtractCurrent()
        {
            if (lstItems.SelectedIndex > -1)
            {
                string current_string = lstItems.SelectedItem.ToString();
                decimal current = Convert.ToDecimal(current_string.Substring(0, current_string.Length - 2));
                _total -= current;
                lstItems.Items.RemoveAt(lstItems.SelectedIndex);
                // Update UI
                UpdateTotalUI();
                SelectValue();
            }
        }

        private void SelectValue()
        {
            numValue.Value = 0.0M;
            numValue.Select(0, numValue.ToString().Length);
        }

        private void UpdateTotalUI()
        {
            lblTot.Text = String.Format("{0:#0.00} €", _total);
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------

        // -----------------------------------------------------------------------------------------------------------
        #region UI EVENT HANDLER

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add(numValue.Value);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SubtractCurrent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            _total = 0.0M;
            // Update UI
            UpdateTotalUI();
            SelectValue();
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {
            UIUtils.SetDefaultIcon(this);
            SelectValue();
        }

        private void FormCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(btnAdd, new EventArgs());
            }
            if (e.KeyCode == Keys.Add)
            {
                btnAdd_Click(btnAdd, new EventArgs());
            }
            if (e.KeyCode == Keys.Subtract)
            {
               btnRemove_Click(btnRemove, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                // btnRemove_Click(btnRemove, new EventArgs());
                Close();
            }
        }

        #endregion
        // -----------------------------------------------------------------------------------------------------------


    }
}
