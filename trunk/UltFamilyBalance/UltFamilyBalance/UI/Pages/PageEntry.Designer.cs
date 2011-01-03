namespace Ult.FamilyBalance.UI
{
    partial class PageEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupEntryList = new System.Windows.Forms.GroupBox();
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.groupDatesFilters = new System.Windows.Forms.GroupBox();
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
            this.contextGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrev = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupEntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.groupDatesFilters.SuspendLayout();
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
            this.groupEntryList.Controls.Add(this.dgvEntries);
            this.groupEntryList.Location = new System.Drawing.Point(3, 29);
            this.groupEntryList.Name = "groupEntryList";
            this.groupEntryList.Size = new System.Drawing.Size(489, 337);
            this.groupEntryList.TabIndex = 0;
            this.groupEntryList.TabStop = false;
            // 
            // dgvEntries
            // 
            this.dgvEntries.AllowUserToAddRows = false;
            this.dgvEntries.AllowUserToDeleteRows = false;
            this.dgvEntries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            this.dgvEntries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntries.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Amount,
            this.Type,
            this.LastUpdate});
            this.dgvEntries.Location = new System.Drawing.Point(3, 9);
            this.dgvEntries.MultiSelect = false;
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.ReadOnly = true;
            this.dgvEntries.RowHeadersVisible = false;
            this.dgvEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntries.Size = new System.Drawing.Size(483, 325);
            this.dgvEntries.TabIndex = 1;
            this.dgvEntries.SelectionChanged += new System.EventHandler(this.dgvEntries_SelectionChanged);
            this.dgvEntries.DoubleClick += new System.EventHandler(this.dgvOutgoing_DoubleClick);
            // 
            // groupDatesFilters
            // 
            this.groupDatesFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDatesFilters.Controls.Add(this.cbxUseDateTo);
            this.groupDatesFilters.Controls.Add(this.cbxUseDateFrom);
            this.groupDatesFilters.Controls.Add(this.label2);
            this.groupDatesFilters.Controls.Add(this.dtpDateFrom);
            this.groupDatesFilters.Controls.Add(this.label1);
            this.groupDatesFilters.Controls.Add(this.dtpDateTo);
            this.groupDatesFilters.Location = new System.Drawing.Point(498, 29);
            this.groupDatesFilters.Name = "groupDatesFilters";
            this.groupDatesFilters.Size = new System.Drawing.Size(167, 100);
            this.groupDatesFilters.TabIndex = 1;
            this.groupDatesFilters.TabStop = false;
            this.groupDatesFilters.Text = "Date";
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
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A partire dal";
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
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fino al";
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
            this.groupTypeFilter.Location = new System.Drawing.Point(498, 135);
            this.groupTypeFilter.Name = "groupTypeFilter";
            this.groupTypeFilter.Size = new System.Drawing.Size(167, 48);
            this.groupTypeFilter.TabIndex = 2;
            this.groupTypeFilter.TabStop = false;
            this.groupTypeFilter.Text = "Categorie";
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
            this.groupTitle.Size = new System.Drawing.Size(662, 32);
            this.groupTitle.TabIndex = 3;
            this.groupTitle.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(5, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Uscite";
            // 
            // groupAmountFilters
            // 
            this.groupAmountFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAmountFilters.Controls.Add(this.cbxMaxAmount);
            this.groupAmountFilters.Controls.Add(this.cbxMinAmount);
            this.groupAmountFilters.Controls.Add(this.numMaxAmount);
            this.groupAmountFilters.Controls.Add(this.numMinAmount);
            this.groupAmountFilters.Location = new System.Drawing.Point(498, 190);
            this.groupAmountFilters.Name = "groupAmountFilters";
            this.groupAmountFilters.Size = new System.Drawing.Size(167, 74);
            this.groupAmountFilters.TabIndex = 4;
            this.groupAmountFilters.TabStop = false;
            this.groupAmountFilters.Text = "Importo";
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
            // btnMoveLast
            // 
            this.btnMoveLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveLast.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_last;
            this.btnMoveLast.Location = new System.Drawing.Point(463, 371);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(26, 24);
            this.btnMoveLast.TabIndex = 11;
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveNext.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_next;
            this.btnMoveNext.Location = new System.Drawing.Point(431, 371);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(26, 24);
            this.btnMoveNext.TabIndex = 10;
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePrev
            // 
            this.btnMovePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMovePrev.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_previous;
            this.btnMovePrev.Location = new System.Drawing.Point(399, 371);
            this.btnMovePrev.Name = "btnMovePrev";
            this.btnMovePrev.Size = new System.Drawing.Size(26, 24);
            this.btnMovePrev.TabIndex = 9;
            this.btnMovePrev.UseVisualStyleBackColor = true;
            this.btnMovePrev.Click += new System.EventHandler(this.btnMovePrev_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveFirst.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_first;
            this.btnMoveFirst.Location = new System.Drawing.Point(367, 371);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(26, 24);
            this.btnMoveFirst.TabIndex = 8;
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Image = global::Ult.FamilyBalance.Properties.Resources.database_delete;
            this.btnDelete.Location = new System.Drawing.Point(165, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Image = global::Ult.FamilyBalance.Properties.Resources.database_edit;
            this.btnEdit.Location = new System.Drawing.Point(84, 371);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 24);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Modifica";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Image = global::Ult.FamilyBalance.Properties.Resources.database_add;
            this.btnNew.Location = new System.Drawing.Point(3, 371);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 24);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Nuovo";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 32;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.Date.DefaultCellStyle = dataGridViewCellStyle3;
            this.Date.HeaderText = "Data";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Date.Width = 75;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.HeaderText = "Importo";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Amount.Width = 80;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "TypeDescription";
            this.Type.HeaderText = "Categoria";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LastUpdate
            // 
            this.LastUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LastUpdate.DataPropertyName = "DateUpdate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm:ss";
            this.LastUpdate.DefaultCellStyle = dataGridViewCellStyle5;
            this.LastUpdate.HeaderText = "Ultima Modifica";
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.ReadOnly = true;
            this.LastUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LastUpdate.Width = 120;
            // 
            // PageEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePrev);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupAmountFilters);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.groupTypeFilter);
            this.Controls.Add(this.groupDatesFilters);
            this.Controls.Add(this.groupEntryList);
            this.Name = "PageEntry";
            this.Size = new System.Drawing.Size(670, 400);
            this.groupEntryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.groupDatesFilters.ResumeLayout(false);
            this.groupDatesFilters.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvEntries;
        private System.Windows.Forms.GroupBox groupDatesFilters;
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextGrid;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.Button btnMovePrev;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;

    }
}
