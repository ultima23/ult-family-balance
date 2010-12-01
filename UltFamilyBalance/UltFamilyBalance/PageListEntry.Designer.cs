namespace Ult.FamilyBalance
{
    partial class PageListEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupEntryList = new System.Windows.Forms.GroupBox();
            this.dgvIncoming = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIncomingFilters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.groupTypeFilter = new System.Windows.Forms.GroupBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupAmountFilters = new System.Windows.Forms.GroupBox();
            this.cbxMaxAmount = new System.Windows.Forms.CheckBox();
            this.cbxMinAmount = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupEntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncoming)).BeginInit();
            this.groupIncomingFilters.SuspendLayout();
            this.groupTypeFilter.SuspendLayout();
            this.groupTitle.SuspendLayout();
            this.groupAmountFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupEntryList
            // 
            this.groupEntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEntryList.Controls.Add(this.dgvIncoming);
            this.groupEntryList.Location = new System.Drawing.Point(3, 29);
            this.groupEntryList.Name = "groupEntryList";
            this.groupEntryList.Size = new System.Drawing.Size(490, 330);
            this.groupEntryList.TabIndex = 0;
            this.groupEntryList.TabStop = false;
            this.groupEntryList.Text = "List";
            // 
            // dgvIncoming
            // 
            this.dgvIncoming.AllowUserToAddRows = false;
            this.dgvIncoming.AllowUserToDeleteRows = false;
            this.dgvIncoming.AllowUserToResizeRows = false;
            this.dgvIncoming.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvIncoming.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncoming.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Type,
            this.Amount,
            this.LastUpdate});
            this.dgvIncoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncoming.Location = new System.Drawing.Point(3, 16);
            this.dgvIncoming.MultiSelect = false;
            this.dgvIncoming.Name = "dgvIncoming";
            this.dgvIncoming.RowHeadersVisible = false;
            this.dgvIncoming.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncoming.Size = new System.Drawing.Size(484, 311);
            this.dgvIncoming.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle17;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 32;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle18.Format = "dd-MM-yyyy";
            this.Date.DefaultCellStyle = dataGridViewCellStyle18;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "Name";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle19;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // LastUpdate
            // 
            this.LastUpdate.DataPropertyName = "DateUpdate";
            dataGridViewCellStyle20.Format = "dd-MM-yyyy HH:mm:ss";
            this.LastUpdate.DefaultCellStyle = dataGridViewCellStyle20;
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.Name = "LastUpdate";
            // 
            // groupIncomingFilters
            // 
            this.groupIncomingFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupIncomingFilters.Controls.Add(this.label2);
            this.groupIncomingFilters.Controls.Add(this.dtpFromDate);
            this.groupIncomingFilters.Controls.Add(this.label1);
            this.groupIncomingFilters.Controls.Add(this.dtpToDate);
            this.groupIncomingFilters.Location = new System.Drawing.Point(499, 29);
            this.groupIncomingFilters.Name = "groupIncomingFilters";
            this.groupIncomingFilters.Size = new System.Drawing.Size(167, 97);
            this.groupIncomingFilters.TabIndex = 1;
            this.groupIncomingFilters.TabStop = false;
            this.groupIncomingFilters.Text = "Date range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Checked = false;
            this.dtpFromDate.CustomFormat = "dd / MM / yyyy";
            this.dtpFromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(6, 69);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShowCheckBox = true;
            this.dtpFromDate.Size = new System.Drawing.Size(155, 20);
            this.dtpFromDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd / MM / yyyy";
            this.dtpToDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(6, 29);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(155, 20);
            this.dtpToDate.TabIndex = 0;
            // 
            // groupTypeFilter
            // 
            this.groupTypeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTypeFilter.Controls.Add(this.cmbTypes);
            this.groupTypeFilter.Location = new System.Drawing.Point(499, 132);
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
            // 
            // groupTitle
            // 
            this.groupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTitle.Controls.Add(this.label3);
            this.groupTitle.Location = new System.Drawing.Point(3, -2);
            this.groupTitle.Name = "groupTitle";
            this.groupTitle.Size = new System.Drawing.Size(663, 32);
            this.groupTitle.TabIndex = 3;
            this.groupTitle.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Incoming entries";
            // 
            // groupAmountFilters
            // 
            this.groupAmountFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAmountFilters.Controls.Add(this.cbxMaxAmount);
            this.groupAmountFilters.Controls.Add(this.cbxMinAmount);
            this.groupAmountFilters.Controls.Add(this.numericUpDown2);
            this.groupAmountFilters.Controls.Add(this.numericUpDown1);
            this.groupAmountFilters.Location = new System.Drawing.Point(499, 187);
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
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(64, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(64, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // PageListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupAmountFilters);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.groupTypeFilter);
            this.Controls.Add(this.groupIncomingFilters);
            this.Controls.Add(this.groupEntryList);
            this.Name = "PageListEntry";
            this.Size = new System.Drawing.Size(671, 362);
            this.groupEntryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncoming)).EndInit();
            this.groupIncomingFilters.ResumeLayout(false);
            this.groupIncomingFilters.PerformLayout();
            this.groupTypeFilter.ResumeLayout(false);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.groupAmountFilters.ResumeLayout(false);
            this.groupAmountFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEntryList;
        private System.Windows.Forms.DataGridView dgvIncoming;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.GroupBox groupIncomingFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.GroupBox groupTypeFilter;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupAmountFilters;
        private System.Windows.Forms.CheckBox cbxMaxAmount;
        private System.Windows.Forms.CheckBox cbxMinAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;

    }
}
