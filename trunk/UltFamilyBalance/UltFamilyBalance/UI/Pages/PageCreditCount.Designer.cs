namespace Ult.FamilyBalance.UI
{
    partial class PageCreditCount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupEntryList = new System.Windows.Forms.GroupBox();
            this.dgvCreditCounts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incoming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outgoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupAmountFilters = new System.Windows.Forms.GroupBox();
            this.cbxMaxAmount = new System.Windows.Forms.CheckBox();
            this.cbxMinAmount = new System.Windows.Forms.CheckBox();
            this.numMaxAmount = new System.Windows.Forms.NumericUpDown();
            this.numMinAmount = new System.Windows.Forms.NumericUpDown();
            this.groupDatesFilters = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cbxUseYear = new System.Windows.Forms.CheckBox();
            this.cbxUseMonth = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrev = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.groupTitle.SuspendLayout();
            this.groupEntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCounts)).BeginInit();
            this.groupAmountFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAmount)).BeginInit();
            this.groupDatesFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTitle
            // 
            this.groupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTitle.Controls.Add(this.labelTitle);
            this.groupTitle.Location = new System.Drawing.Point(3, -1);
            this.groupTitle.Name = "groupTitle";
            this.groupTitle.Size = new System.Drawing.Size(662, 32);
            this.groupTitle.TabIndex = 4;
            this.groupTitle.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(5, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(104, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Conto Corrente";
            // 
            // groupEntryList
            // 
            this.groupEntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEntryList.Controls.Add(this.dgvCreditCounts);
            this.groupEntryList.Location = new System.Drawing.Point(3, 29);
            this.groupEntryList.Name = "groupEntryList";
            this.groupEntryList.Size = new System.Drawing.Size(489, 337);
            this.groupEntryList.TabIndex = 5;
            this.groupEntryList.TabStop = false;
            // 
            // dgvCreditCounts
            // 
            this.dgvCreditCounts.AllowUserToAddRows = false;
            this.dgvCreditCounts.AllowUserToDeleteRows = false;
            this.dgvCreditCounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            this.dgvCreditCounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreditCounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCreditCounts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCreditCounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCreditCounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditCounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Year,
            this.Month,
            this.Incoming,
            this.Outgoing,
            this.Total,
            this.User,
            this.LastUpdate});
            this.dgvCreditCounts.Location = new System.Drawing.Point(3, 9);
            this.dgvCreditCounts.MultiSelect = false;
            this.dgvCreditCounts.Name = "dgvCreditCounts";
            this.dgvCreditCounts.ReadOnly = true;
            this.dgvCreditCounts.RowHeadersVisible = false;
            this.dgvCreditCounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditCounts.Size = new System.Drawing.Size(483, 325);
            this.dgvCreditCounts.TabIndex = 1;
            this.dgvCreditCounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCreditCounts_CellDoubleClick);
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
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Year.DefaultCellStyle = dataGridViewCellStyle3;
            this.Year.HeaderText = "Anno";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Year.Width = 42;
            // 
            // Month
            // 
            this.Month.DataPropertyName = "MonthName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.Month.DefaultCellStyle = dataGridViewCellStyle4;
            this.Month.HeaderText = "Mese";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Month.Width = 50;
            // 
            // Incoming
            // 
            this.Incoming.DataPropertyName = "Incoming";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Incoming.DefaultCellStyle = dataGridViewCellStyle5;
            this.Incoming.HeaderText = "Entrate";
            this.Incoming.Name = "Incoming";
            this.Incoming.ReadOnly = true;
            this.Incoming.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Incoming.Width = 70;
            // 
            // Outgoing
            // 
            this.Outgoing.DataPropertyName = "Outgoing";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Outgoing.DefaultCellStyle = dataGridViewCellStyle6;
            this.Outgoing.HeaderText = "Uscite";
            this.Outgoing.Name = "Outgoing";
            this.Outgoing.ReadOnly = true;
            this.Outgoing.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Outgoing.Width = 70;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Balance";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle7;
            this.Total.HeaderText = "Saldo";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.Width = 70;
            // 
            // User
            // 
            this.User.DataPropertyName = "UserName";
            this.User.HeaderText = "Utente";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.User.Width = 70;
            // 
            // LastUpdate
            // 
            this.LastUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastUpdate.DataPropertyName = "DateUpdate";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Format = "dd/MM/yyyy HH:mm:ss";
            this.LastUpdate.DefaultCellStyle = dataGridViewCellStyle8;
            this.LastUpdate.HeaderText = "Ultima Modifica";
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Image = global::Ult.FamilyBalance.Properties.Resources.database_delete;
            this.btnDelete.Location = new System.Drawing.Point(165, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 10;
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
            this.btnEdit.TabIndex = 9;
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
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Nuovo";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupAmountFilters
            // 
            this.groupAmountFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAmountFilters.Controls.Add(this.cbxMaxAmount);
            this.groupAmountFilters.Controls.Add(this.cbxMinAmount);
            this.groupAmountFilters.Controls.Add(this.numMaxAmount);
            this.groupAmountFilters.Controls.Add(this.numMinAmount);
            this.groupAmountFilters.Location = new System.Drawing.Point(498, 135);
            this.groupAmountFilters.Name = "groupAmountFilters";
            this.groupAmountFilters.Size = new System.Drawing.Size(167, 74);
            this.groupAmountFilters.TabIndex = 11;
            this.groupAmountFilters.TabStop = false;
            this.groupAmountFilters.Text = "Saldo";
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
            // 
            // groupDatesFilters
            // 
            this.groupDatesFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDatesFilters.Controls.Add(this.cmbMonth);
            this.groupDatesFilters.Controls.Add(this.cmbYear);
            this.groupDatesFilters.Controls.Add(this.cbxUseYear);
            this.groupDatesFilters.Controls.Add(this.cbxUseMonth);
            this.groupDatesFilters.Controls.Add(this.label2);
            this.groupDatesFilters.Controls.Add(this.label1);
            this.groupDatesFilters.Location = new System.Drawing.Point(498, 29);
            this.groupDatesFilters.Name = "groupDatesFilters";
            this.groupDatesFilters.Size = new System.Drawing.Size(167, 100);
            this.groupDatesFilters.TabIndex = 12;
            this.groupDatesFilters.TabStop = false;
            this.groupDatesFilters.Text = "Date";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Ottobre",
            "Novembre",
            "Dicembre"});
            this.cmbMonth.Location = new System.Drawing.Point(33, 72);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(127, 21);
            this.cmbMonth.TabIndex = 7;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(33, 32);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(127, 21);
            this.cmbYear.TabIndex = 6;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cbxUseYear
            // 
            this.cbxUseYear.AutoSize = true;
            this.cbxUseYear.Location = new System.Drawing.Point(12, 35);
            this.cbxUseYear.Name = "cbxUseYear";
            this.cbxUseYear.Size = new System.Drawing.Size(15, 14);
            this.cbxUseYear.TabIndex = 5;
            this.cbxUseYear.UseVisualStyleBackColor = true;
            this.cbxUseYear.CheckedChanged += new System.EventHandler(this.cbxUseYear_CheckedChanged);
            // 
            // cbxUseMonth
            // 
            this.cbxUseMonth.AutoSize = true;
            this.cbxUseMonth.Location = new System.Drawing.Point(12, 75);
            this.cbxUseMonth.Name = "cbxUseMonth";
            this.cbxUseMonth.Size = new System.Drawing.Size(15, 14);
            this.cbxUseMonth.TabIndex = 4;
            this.cbxUseMonth.UseVisualStyleBackColor = true;
            this.cbxUseMonth.CheckedChanged += new System.EventHandler(this.cbxUseMonth_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mese";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anno";
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveLast.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_last;
            this.btnMoveLast.Location = new System.Drawing.Point(466, 371);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(26, 25);
            this.btnMoveLast.TabIndex = 16;
            this.btnMoveLast.UseVisualStyleBackColor = true;
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveNext.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_next;
            this.btnMoveNext.Location = new System.Drawing.Point(434, 371);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(26, 25);
            this.btnMoveNext.TabIndex = 15;
            this.btnMoveNext.UseVisualStyleBackColor = true;
            // 
            // btnMovePrev
            // 
            this.btnMovePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMovePrev.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_previous;
            this.btnMovePrev.Location = new System.Drawing.Point(402, 371);
            this.btnMovePrev.Name = "btnMovePrev";
            this.btnMovePrev.Size = new System.Drawing.Size(26, 25);
            this.btnMovePrev.TabIndex = 14;
            this.btnMovePrev.UseVisualStyleBackColor = true;
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveFirst.Image = global::Ult.FamilyBalance.Properties.Resources.resultset_first;
            this.btnMoveFirst.Location = new System.Drawing.Point(370, 371);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(26, 25);
            this.btnMoveFirst.TabIndex = 13;
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            // 
            // PageCreditCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePrev);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.groupDatesFilters);
            this.Controls.Add(this.groupAmountFilters);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupEntryList);
            this.Name = "PageCreditCount";
            this.Size = new System.Drawing.Size(670, 400);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.groupEntryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCounts)).EndInit();
            this.groupAmountFilters.ResumeLayout(false);
            this.groupAmountFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAmount)).EndInit();
            this.groupDatesFilters.ResumeLayout(false);
            this.groupDatesFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupEntryList;
        private System.Windows.Forms.DataGridView dgvCreditCounts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupAmountFilters;
        private System.Windows.Forms.CheckBox cbxMaxAmount;
        private System.Windows.Forms.CheckBox cbxMinAmount;
        private System.Windows.Forms.NumericUpDown numMaxAmount;
        private System.Windows.Forms.NumericUpDown numMinAmount;
        private System.Windows.Forms.GroupBox groupDatesFilters;
        private System.Windows.Forms.CheckBox cbxUseYear;
        private System.Windows.Forms.CheckBox cbxUseMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveLast;
        private System.Windows.Forms.Button btnMoveNext;
        private System.Windows.Forms.Button btnMovePrev;
        private System.Windows.Forms.Button btnMoveFirst;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incoming;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outgoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;

    }
}
