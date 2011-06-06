namespace Ult.FamilyBalance.UI.Pages
{
    partial class PageReportGroupYear
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGroupsYear = new System.Windows.Forms.GroupBox();
            this.dgvGroupsYear = new System.Windows.Forms.DataGridView();
            this.grpTypeYearDetail = new System.Windows.Forms.GroupBox();
            this.dgvGroupsYearDetail = new System.Windows.Forms.DataGridView();
            this.ColSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalCorrect = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCorrection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupTitle.SuspendLayout();
            this.groupFilters.SuspendLayout();
            this.grpGroupsYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsYear)).BeginInit();
            this.grpTypeYearDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsYearDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTitle
            // 
            this.groupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTitle.Controls.Add(this.labelTitle);
            this.groupTitle.Location = new System.Drawing.Point(3, -1);
            this.groupTitle.Name = "groupTitle";
            this.groupTitle.Size = new System.Drawing.Size(792, 32);
            this.groupTitle.TabIndex = 5;
            this.groupTitle.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(5, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(116, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Report Categorie";
            // 
            // groupFilters
            // 
            this.groupFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilters.Controls.Add(this.cmbYear);
            this.groupFilters.Controls.Add(this.label1);
            this.groupFilters.Location = new System.Drawing.Point(3, 31);
            this.groupFilters.Name = "groupFilters";
            this.groupFilters.Size = new System.Drawing.Size(792, 42);
            this.groupFilters.TabIndex = 17;
            this.groupFilters.TabStop = false;
            this.groupFilters.Text = "Filtro";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(44, 15);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(85, 21);
            this.cmbYear.TabIndex = 6;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anno";
            // 
            // grpGroupsYear
            // 
            this.grpGroupsYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGroupsYear.Controls.Add(this.dgvGroupsYear);
            this.grpGroupsYear.Location = new System.Drawing.Point(3, 73);
            this.grpGroupsYear.Name = "grpGroupsYear";
            this.grpGroupsYear.Size = new System.Drawing.Size(586, 294);
            this.grpGroupsYear.TabIndex = 18;
            this.grpGroupsYear.TabStop = false;
            // 
            // dgvGroupsYear
            // 
            this.dgvGroupsYear.AllowUserToAddRows = false;
            this.dgvGroupsYear.AllowUserToDeleteRows = false;
            this.dgvGroupsYear.AllowUserToResizeColumns = false;
            this.dgvGroupsYear.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.dgvGroupsYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroupsYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupsYear.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGroupsYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGroupsYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelected,
            this.ColTypeName,
            this.ColTypeTotal,
            this.ColTypeAvg});
            this.dgvGroupsYear.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvGroupsYear.Location = new System.Drawing.Point(3, 8);
            this.dgvGroupsYear.MultiSelect = false;
            this.dgvGroupsYear.Name = "dgvGroupsYear";
            this.dgvGroupsYear.RowHeadersVisible = false;
            this.dgvGroupsYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupsYear.Size = new System.Drawing.Size(580, 283);
            this.dgvGroupsYear.TabIndex = 1;
            this.dgvGroupsYear.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupsYear_CellValueChanged);
            this.dgvGroupsYear.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvGroupsYear_CurrentCellDirtyStateChanged);
            // 
            // grpTypeYearDetail
            // 
            this.grpTypeYearDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTypeYearDetail.Controls.Add(this.dgvGroupsYearDetail);
            this.grpTypeYearDetail.Location = new System.Drawing.Point(594, 73);
            this.grpTypeYearDetail.Name = "grpTypeYearDetail";
            this.grpTypeYearDetail.Size = new System.Drawing.Size(201, 294);
            this.grpTypeYearDetail.TabIndex = 19;
            this.grpTypeYearDetail.TabStop = false;
            // 
            // dgvGroupsYearDetail
            // 
            this.dgvGroupsYearDetail.AllowUserToAddRows = false;
            this.dgvGroupsYearDetail.AllowUserToDeleteRows = false;
            this.dgvGroupsYearDetail.AllowUserToResizeColumns = false;
            this.dgvGroupsYearDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightYellow;
            this.dgvGroupsYearDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroupsYearDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroupsYearDetail.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGroupsYearDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGroupsYearDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsYearDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTypeDetailMonth,
            this.ColTypeDetailTotal,
            this.ColTypeDetailAvg});
            this.dgvGroupsYearDetail.Location = new System.Drawing.Point(3, 8);
            this.dgvGroupsYearDetail.MultiSelect = false;
            this.dgvGroupsYearDetail.Name = "dgvGroupsYearDetail";
            this.dgvGroupsYearDetail.RowHeadersVisible = false;
            this.dgvGroupsYearDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupsYearDetail.Size = new System.Drawing.Size(195, 283);
            this.dgvGroupsYearDetail.TabIndex = 1;
            // 
            // ColSelected
            // 
            this.ColSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSelected.DataPropertyName = "Selected";
            this.ColSelected.FalseValue = "0";
            this.ColSelected.HeaderText = "";
            this.ColSelected.Name = "ColSelected";
            this.ColSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSelected.TrueValue = "1";
            this.ColSelected.Width = 32;
            // 
            // ColTypeName
            // 
            this.ColTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTypeName.DataPropertyName = "Group";
            this.ColTypeName.HeaderText = "Gruppo";
            this.ColTypeName.Name = "ColTypeName";
            this.ColTypeName.ReadOnly = true;
            this.ColTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColTypeTotal
            // 
            this.ColTypeTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeTotal.DataPropertyName = "Total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            this.ColTypeTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColTypeTotal.HeaderText = "Totale";
            this.ColTypeTotal.Name = "ColTypeTotal";
            this.ColTypeTotal.ReadOnly = true;
            this.ColTypeTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeTotal.Width = 90;
            // 
            // ColTypeAvg
            // 
            this.ColTypeAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeAvg.DataPropertyName = "Avg";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.ColTypeAvg.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTypeAvg.HeaderText = "Media";
            this.ColTypeAvg.Name = "ColTypeAvg";
            this.ColTypeAvg.ReadOnly = true;
            this.ColTypeAvg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeAvg.ToolTipText = "Media";
            this.ColTypeAvg.Width = 90;
            // 
            // ColTypeDetailMonth
            // 
            this.ColTypeDetailMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTypeDetailMonth.DataPropertyName = "MonthName";
            this.ColTypeDetailMonth.HeaderText = "Mese";
            this.ColTypeDetailMonth.Name = "ColTypeDetailMonth";
            this.ColTypeDetailMonth.ReadOnly = true;
            this.ColTypeDetailMonth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColTypeDetailTotal
            // 
            this.ColTypeDetailTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeDetailTotal.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            this.ColTypeDetailTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColTypeDetailTotal.HeaderText = "Total";
            this.ColTypeDetailTotal.Name = "ColTypeDetailTotal";
            this.ColTypeDetailTotal.ReadOnly = true;
            this.ColTypeDetailTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeDetailTotal.Width = 70;
            // 
            // ColTypeDetailAvg
            // 
            this.ColTypeDetailAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeDetailAvg.DataPropertyName = "Avg";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            this.ColTypeDetailAvg.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColTypeDetailAvg.HeaderText = "Media";
            this.ColTypeDetailAvg.Name = "ColTypeDetailAvg";
            this.ColTypeDetailAvg.ReadOnly = true;
            this.ColTypeDetailAvg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeDetailAvg.Visible = false;
            this.ColTypeDetailAvg.Width = 62;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Bilancio Corretto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCorrect
            // 
            this.lblTotalCorrect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCorrect.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalCorrect.Location = new System.Drawing.Point(178, 449);
            this.lblTotalCorrect.Name = "lblTotalCorrect";
            this.lblTotalCorrect.Size = new System.Drawing.Size(94, 23);
            this.lblTotalCorrect.TabIndex = 41;
            this.lblTotalCorrect.Text = "0.00 €";
            this.lblTotalCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrection
            // 
            this.lblCorrection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrection.Location = new System.Drawing.Point(178, 419);
            this.lblCorrection.Name = "lblCorrection";
            this.lblCorrection.Size = new System.Drawing.Size(94, 23);
            this.lblCorrection.TabIndex = 39;
            this.lblCorrection.Text = "0.00 €";
            this.lblCorrection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Correzione";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(178, 389);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 23);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "0.00 €";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Bilancio Reale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageReportGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalCorrect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCorrection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupFilters);
            this.Controls.Add(this.grpTypeYearDetail);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.grpGroupsYear);
            this.Name = "PageReportGroup";
            this.Size = new System.Drawing.Size(800, 620);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.groupFilters.ResumeLayout(false);
            this.groupFilters.PerformLayout();
            this.grpGroupsYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsYear)).EndInit();
            this.grpTypeYearDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsYearDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupFilters;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGroupsYear;
        private System.Windows.Forms.DataGridView dgvGroupsYear;
        private System.Windows.Forms.GroupBox grpTypeYearDetail;
        private System.Windows.Forms.DataGridView dgvGroupsYearDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalCorrect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCorrection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
    }
}
