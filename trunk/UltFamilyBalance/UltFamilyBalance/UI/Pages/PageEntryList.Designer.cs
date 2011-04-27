namespace Ult.FamilyBalance.UI.Pages
{
    partial class PageEntryList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.ColEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntryUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalTit = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntries
            // 
            this.dgvEntries.AllowUserToAddRows = false;
            this.dgvEntries.AllowUserToDeleteRows = false;
            this.dgvEntries.AllowUserToOrderColumns = true;
            this.dgvEntries.AllowUserToResizeColumns = false;
            this.dgvEntries.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Info;
            this.dgvEntries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntries.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEntryDate,
            this.ColEntryAmount,
            this.ColEntryGroup,
            this.ColEntryType,
            this.ColEntryNote,
            this.ColEntryUser});
            this.dgvEntries.Location = new System.Drawing.Point(3, 3);
            this.dgvEntries.MultiSelect = false;
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.RowHeadersVisible = false;
            this.dgvEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntries.ShowCellErrors = false;
            this.dgvEntries.ShowCellToolTips = false;
            this.dgvEntries.ShowEditingIcon = false;
            this.dgvEntries.ShowRowErrors = false;
            this.dgvEntries.Size = new System.Drawing.Size(633, 391);
            this.dgvEntries.TabIndex = 0;
            // 
            // ColEntryDate
            // 
            this.ColEntryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEntryDate.DataPropertyName = "EntryDate";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "dd/MM/yyyy";
            this.ColEntryDate.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColEntryDate.HeaderText = "Data";
            this.ColEntryDate.Name = "ColEntryDate";
            this.ColEntryDate.ReadOnly = true;
            this.ColEntryDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEntryDate.Width = 75;
            // 
            // ColEntryAmount
            // 
            this.ColEntryAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEntryAmount.DataPropertyName = "EntryAmount";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C2";
            this.ColEntryAmount.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColEntryAmount.HeaderText = "Importo";
            this.ColEntryAmount.Name = "ColEntryAmount";
            this.ColEntryAmount.ReadOnly = true;
            this.ColEntryAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEntryAmount.Width = 80;
            // 
            // ColEntryGroup
            // 
            this.ColEntryGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEntryGroup.DataPropertyName = "EntryTypeGroupName";
            this.ColEntryGroup.HeaderText = "Gruppo";
            this.ColEntryGroup.Name = "ColEntryGroup";
            this.ColEntryGroup.ReadOnly = true;
            this.ColEntryGroup.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColEntryType
            // 
            this.ColEntryType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEntryType.DataPropertyName = "EntryTypeName";
            this.ColEntryType.HeaderText = "Categoria";
            this.ColEntryType.Name = "ColEntryType";
            this.ColEntryType.ReadOnly = true;
            this.ColEntryType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColEntryNote
            // 
            this.ColEntryNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEntryNote.DataPropertyName = "EntryNote";
            this.ColEntryNote.HeaderText = "Nota";
            this.ColEntryNote.Name = "ColEntryNote";
            this.ColEntryNote.ReadOnly = true;
            this.ColEntryNote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColEntryUser
            // 
            this.ColEntryUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEntryUser.DataPropertyName = "UserUsername";
            this.ColEntryUser.HeaderText = "Utente";
            this.ColEntryUser.Name = "ColEntryUser";
            this.ColEntryUser.ReadOnly = true;
            this.ColEntryUser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEntryUser.Width = 80;
            // 
            // lblTotalTit
            // 
            this.lblTotalTit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalTit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalTit.Location = new System.Drawing.Point(3, 398);
            this.lblTotalTit.Name = "lblTotalTit";
            this.lblTotalTit.Size = new System.Drawing.Size(74, 18);
            this.lblTotalTit.TabIndex = 1;
            this.lblTotalTit.Text = "Totale";
            this.lblTotalTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(81, 398);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 18);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PageEntryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalTit);
            this.Controls.Add(this.dgvEntries);
            this.Name = "PageEntryList";
            this.Size = new System.Drawing.Size(640, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntries;
        private System.Windows.Forms.Label lblTotalTit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntryUser;
    }
}
