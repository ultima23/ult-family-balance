namespace Ult.FamilyBalance.UI
{
    partial class PageOutgoingList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupEntryList = new System.Windows.Forms.GroupBox();
            this.dgvOutgoing = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIncomingFilters = new System.Windows.Forms.GroupBox();
            this.cbxUseDateTo = new System.Windows.Forms.CheckBox();
            this.cbxUseDateFrom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.groupTypeFilter = new System.Windows.Forms.GroupBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupAmountFilters = new System.Windows.Forms.GroupBox();
            this.cbxMaxAmount = new System.Windows.Forms.CheckBox();
            this.cbxMinAmount = new System.Windows.Forms.CheckBox();
            this.numMaxAmount = new System.Windows.Forms.NumericUpDown();
            this.numMinAmount = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupEntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutgoing)).BeginInit();
            this.groupIncomingFilters.SuspendLayout();
            this.groupTypeFilter.SuspendLayout();
            this.groupTitle.SuspendLayout();
            this.groupAmountFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAmount)).BeginInit();
            this.contextGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupEntryList
            // 
            this.groupEntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEntryList.Controls.Add(this.dgvOutgoing);
            this.groupEntryList.Location = new System.Drawing.Point(3, 29);
            this.groupEntryList.Name = "groupEntryList";
            this.groupEntryList.Size = new System.Drawing.Size(490, 333);
            this.groupEntryList.TabIndex = 0;
            this.groupEntryList.TabStop = false;
            // 
            // dgvOutgoing
            // 
            this.dgvOutgoing.AllowUserToAddRows = false;
            this.dgvOutgoing.AllowUserToDeleteRows = false;
            this.dgvOutgoing.AllowUserToResizeRows = false;
            this.dgvOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutgoing.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOutgoing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOutgoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutgoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Amount,
            this.Type,
            this.LastUpdate});
            this.dgvOutgoing.Location = new System.Drawing.Point(3, 9);
            this.dgvOutgoing.MultiSelect = false;
            this.dgvOutgoing.Name = "dgvOutgoing";
            this.dgvOutgoing.RowHeadersVisible = false;
            this.dgvOutgoing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutgoing.Size = new System.Drawing.Size(484, 320);
            this.dgvOutgoing.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 32;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.Width = 75;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 80;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "Name";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LastUpdate
            // 
            this.LastUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LastUpdate.DataPropertyName = "DateUpdate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm:ss";
            this.LastUpdate.DefaultCellStyle = dataGridViewCellStyle4;
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Width = 120;
            // 
            // groupIncomingFilters
            // 
            this.groupIncomingFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupIncomingFilters.Controls.Add(this.cbxUseDateTo);
            this.groupIncomingFilters.Controls.Add(this.cbxUseDateFrom);
            this.groupIncomingFilters.Controls.Add(this.label2);
            this.groupIncomingFilters.Controls.Add(this.dtpDateFrom);
            this.groupIncomingFilters.Controls.Add(this.label1);
            this.groupIncomingFilters.Controls.Add(this.dtpDateTo);
            this.groupIncomingFilters.Location = new System.Drawing.Point(499, 29);
            this.groupIncomingFilters.Name = "groupIncomingFilters";
            this.groupIncomingFilters.Size = new System.Drawing.Size(167, 100);
            this.groupIncomingFilters.TabIndex = 1;
            this.groupIncomingFilters.TabStop = false;
            this.groupIncomingFilters.Text = "Date range";
            // 
            // cbxUseDateTo
            // 
            this.cbxUseDateTo.AutoSize = true;
            this.cbxUseDateTo.Location = new System.Drawing.Point(12, 35);
            this.cbxUseDateTo.Name = "cbxUseDateTo";
            this.cbxUseDateTo.Size = new System.Drawing.Size(15, 14);
            this.cbxUseDateTo.TabIndex = 5;
            this.cbxUseDateTo.UseVisualStyleBackColor = true;
            this.cbxUseDateTo.CheckedChanged += new System.EventHandler(this.chbUseDateTo_CheckedChanged);
            // 
            // cbxUseDateFrom
            // 
            this.cbxUseDateFrom.AutoSize = true;
            this.cbxUseDateFrom.Location = new System.Drawing.Point(12, 75);
            this.cbxUseDateFrom.Name = "cbxUseDateFrom";
            this.cbxUseDateFrom.Size = new System.Drawing.Size(15, 14);
            this.cbxUseDateFrom.TabIndex = 4;
            this.cbxUseDateFrom.UseVisualStyleBackColor = true;
            this.cbxUseDateFrom.CheckedChanged += new System.EventHandler(this.chbUseDateFrom_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.CustomFormat = "dd / MM / yyyy";
            this.dtpDateFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(31, 72);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(130, 20);
            this.dtpDateFrom.TabIndex = 2;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd / MM / yyyy";
            this.dtpDateTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(31, 32);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(130, 20);
            this.dtpDateTo.TabIndex = 0;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // groupTypeFilter
            // 
            this.groupTypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTypeFilter.Controls.Add(this.cmbTypes);
            this.groupTypeFilter.Location = new System.Drawing.Point(499, 135);
            this.groupTypeFilter.Name = "groupTypeFilter";
            this.groupTypeFilter.Size = new System.Drawing.Size(167, 48);
            this.groupTypeFilter.TabIndex = 2;
            this.groupTypeFilter.TabStop = false;
            this.groupTypeFilter.Text = "Categories";
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(7, 20);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(154, 21);
            this.cmbTypes.TabIndex = 6;
            this.cmbTypes.SelectedIndexChanged += new System.EventHandler(this.cmbTypes_SelectedIndexChanged);
            // 
            // groupTitle
            // 
            this.groupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTitle.Controls.Add(this.labelTitle);
            this.groupTitle.Location = new System.Drawing.Point(3, -2);
            this.groupTitle.Name = "groupTitle";
            this.groupTitle.Size = new System.Drawing.Size(663, 32);
            this.groupTitle.TabIndex = 3;
            this.groupTitle.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(5, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(114, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Outgoing Entries";
            // 
            // groupAmountFilters
            // 
            this.groupAmountFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAmountFilters.Controls.Add(this.cbxMaxAmount);
            this.groupAmountFilters.Controls.Add(this.cbxMinAmount);
            this.groupAmountFilters.Controls.Add(this.numMaxAmount);
            this.groupAmountFilters.Controls.Add(this.numMinAmount);
            this.groupAmountFilters.Location = new System.Drawing.Point(499, 190);
            this.groupAmountFilters.Name = "groupAmountFilters";
            this.groupAmountFilters.Size = new System.Drawing.Size(167, 74);
            this.groupAmountFilters.TabIndex = 4;
            this.groupAmountFilters.TabStop = false;
            this.groupAmountFilters.Text = "Amount";
            // 
            // cbxMaxAmount
            // 
            this.cbxMaxAmount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxMaxAmount.Location = new System.Drawing.Point(7, 48);
            this.cbxMaxAmount.Name = "cbxMaxAmount";
            this.cbxMaxAmount.Size = new System.Drawing.Size(46, 17);
            this.cbxMaxAmount.TabIndex = 3;
            this.cbxMaxAmount.Text = "Max";
            this.cbxMaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxMaxAmount.UseVisualStyleBackColor = true;
            this.cbxMaxAmount.CheckedChanged += new System.EventHandler(this.cbxMaxAmount_CheckedChanged);
            // 
            // cbxMinAmount
            // 
            this.cbxMinAmount.AutoSize = true;
            this.cbxMinAmount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxMinAmount.Location = new System.Drawing.Point(10, 22);
            this.cbxMinAmount.Name = "cbxMinAmount";
            this.cbxMinAmount.Size = new System.Drawing.Size(43, 17);
            this.cbxMinAmount.TabIndex = 2;
            this.cbxMinAmount.Text = "Min";
            this.cbxMinAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxMinAmount.UseVisualStyleBackColor = true;
            this.cbxMinAmount.CheckedChanged += new System.EventHandler(this.cbxMinAmount_CheckedChanged);
            // 
            // numMaxAmount
            // 
            this.numMaxAmount.Enabled = false;
            this.numMaxAmount.Location = new System.Drawing.Point(64, 45);
            this.numMaxAmount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numMaxAmount.Name = "numMaxAmount";
            this.numMaxAmount.Size = new System.Drawing.Size(96, 20);
            this.numMaxAmount.TabIndex = 1;
            this.numMaxAmount.ValueChanged += new System.EventHandler(this.numMaxAmount_ValueChanged);
            // 
            // numMinAmount
            // 
            this.numMinAmount.Enabled = false;
            this.numMinAmount.Location = new System.Drawing.Point(64, 19);
            this.numMinAmount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numMinAmount.Name = "numMinAmount";
            this.numMinAmount.Size = new System.Drawing.Size(96, 20);
            this.numMinAmount.TabIndex = 0;
            this.numMinAmount.ValueChanged += new System.EventHandler(this.numMinAmount_ValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Location = new System.Drawing.Point(3, 368);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(84, 368);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(165, 368);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // contextGrid
            // 
            this.contextGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextGrid.Name = "contextGrid";
            this.contextGrid.Size = new System.Drawing.Size(108, 70);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // PageOutgoingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupAmountFilters);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.groupTypeFilter);
            this.Controls.Add(this.groupIncomingFilters);
            this.Controls.Add(this.groupEntryList);
            this.Name = "PageOutgoingList";
            this.Size = new System.Drawing.Size(671, 396);
            this.groupEntryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutgoing)).EndInit();
            this.groupIncomingFilters.ResumeLayout(false);
            this.groupIncomingFilters.PerformLayout();
            this.groupTypeFilter.ResumeLayout(false);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.groupAmountFilters.ResumeLayout(false);
            this.groupAmountFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAmount)).EndInit();
            this.contextGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEntryList;
        private System.Windows.Forms.DataGridView dgvOutgoing;
        private System.Windows.Forms.GroupBox groupIncomingFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.GroupBox groupTypeFilter;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupAmountFilters;
        private System.Windows.Forms.CheckBox cbxMaxAmount;
        private System.Windows.Forms.CheckBox cbxMinAmount;
        private System.Windows.Forms.NumericUpDown numMaxAmount;
        private System.Windows.Forms.NumericUpDown numMinAmount;
        private System.Windows.Forms.CheckBox cbxUseDateFrom;
        private System.Windows.Forms.CheckBox cbxUseDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextGrid;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

    }
}
