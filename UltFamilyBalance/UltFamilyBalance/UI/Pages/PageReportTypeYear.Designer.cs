namespace Ult.FamilyBalance.UI.Pages
{
    partial class PageReportTypeYear
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.grpTypeYear = new System.Windows.Forms.GroupBox();
            this.dgvTypeYear = new System.Windows.Forms.DataGridView();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTypeYearDetail = new System.Windows.Forms.GroupBox();
            this.dgvTypeYearDetail = new System.Windows.Forms.DataGridView();
            this.ColTypeDetailMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartTypeYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypePerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvgCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvgMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTitle.SuspendLayout();
            this.grpTypeYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeYear)).BeginInit();
            this.groupFilters.SuspendLayout();
            this.grpTypeYearDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeYearDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeYear)).BeginInit();
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
            // grpTypeYear
            // 
            this.grpTypeYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTypeYear.Controls.Add(this.dgvTypeYear);
            this.grpTypeYear.Location = new System.Drawing.Point(3, 31);
            this.grpTypeYear.Name = "grpTypeYear";
            this.grpTypeYear.Size = new System.Drawing.Size(485, 294);
            this.grpTypeYear.TabIndex = 16;
            this.grpTypeYear.TabStop = false;
            // 
            // dgvTypeYear
            // 
            this.dgvTypeYear.AllowUserToAddRows = false;
            this.dgvTypeYear.AllowUserToDeleteRows = false;
            this.dgvTypeYear.AllowUserToResizeColumns = false;
            this.dgvTypeYear.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.dgvTypeYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTypeYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypeYear.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTypeYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTypeYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTypeName,
            this.ColTypeTotal,
            this.ColTypePerc,
            this.ColTypeAvg,
            this.ColAvgCurr,
            this.ColAvgMonth,
            this.ColTypeMax,
            this.ColTypeMin});
            this.dgvTypeYear.Location = new System.Drawing.Point(3, 9);
            this.dgvTypeYear.MultiSelect = false;
            this.dgvTypeYear.Name = "dgvTypeYear";
            this.dgvTypeYear.ReadOnly = true;
            this.dgvTypeYear.RowHeadersVisible = false;
            this.dgvTypeYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeYear.Size = new System.Drawing.Size(479, 282);
            this.dgvTypeYear.TabIndex = 1;
            this.dgvTypeYear.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeYear_CellDoubleClick);
            // 
            // groupFilters
            // 
            this.groupFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilters.Controls.Add(this.cmbYear);
            this.groupFilters.Controls.Add(this.label1);
            this.groupFilters.Location = new System.Drawing.Point(695, 31);
            this.groupFilters.Name = "groupFilters";
            this.groupFilters.Size = new System.Drawing.Size(100, 294);
            this.groupFilters.TabIndex = 17;
            this.groupFilters.TabStop = false;
            this.groupFilters.Text = "Filtro";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(9, 32);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(85, 21);
            this.cmbYear.TabIndex = 6;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
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
            // grpTypeYearDetail
            // 
            this.grpTypeYearDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTypeYearDetail.Controls.Add(this.dgvTypeYearDetail);
            this.grpTypeYearDetail.Location = new System.Drawing.Point(491, 31);
            this.grpTypeYearDetail.Name = "grpTypeYearDetail";
            this.grpTypeYearDetail.Size = new System.Drawing.Size(201, 294);
            this.grpTypeYearDetail.TabIndex = 18;
            this.grpTypeYearDetail.TabStop = false;
            // 
            // dgvTypeYearDetail
            // 
            this.dgvTypeYearDetail.AllowUserToAddRows = false;
            this.dgvTypeYearDetail.AllowUserToDeleteRows = false;
            this.dgvTypeYearDetail.AllowUserToResizeColumns = false;
            this.dgvTypeYearDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightYellow;
            this.dgvTypeYearDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTypeYearDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypeYearDetail.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTypeYearDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTypeYearDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeYearDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTypeDetailMonth,
            this.ColTypeDetailTotal,
            this.ColTypeDetailAvg,
            this.ColTypeDetailMax,
            this.ColTypeDetailMin});
            this.dgvTypeYearDetail.Location = new System.Drawing.Point(3, 9);
            this.dgvTypeYearDetail.MultiSelect = false;
            this.dgvTypeYearDetail.Name = "dgvTypeYearDetail";
            this.dgvTypeYearDetail.ReadOnly = true;
            this.dgvTypeYearDetail.RowHeadersVisible = false;
            this.dgvTypeYearDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTypeYearDetail.Size = new System.Drawing.Size(195, 282);
            this.dgvTypeYearDetail.TabIndex = 1;
            this.dgvTypeYearDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTypeYearDetail_CellDoubleClick);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            this.ColTypeDetailTotal.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            this.ColTypeDetailAvg.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColTypeDetailAvg.HeaderText = "Media";
            this.ColTypeDetailAvg.Name = "ColTypeDetailAvg";
            this.ColTypeDetailAvg.ReadOnly = true;
            this.ColTypeDetailAvg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeDetailAvg.Visible = false;
            this.ColTypeDetailAvg.Width = 62;
            // 
            // ColTypeDetailMax
            // 
            this.ColTypeDetailMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeDetailMax.DataPropertyName = "Max";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C2";
            this.ColTypeDetailMax.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColTypeDetailMax.HeaderText = "Max.";
            this.ColTypeDetailMax.Name = "ColTypeDetailMax";
            this.ColTypeDetailMax.ReadOnly = true;
            this.ColTypeDetailMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeDetailMax.Visible = false;
            this.ColTypeDetailMax.Width = 62;
            // 
            // ColTypeDetailMin
            // 
            this.ColTypeDetailMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeDetailMin.DataPropertyName = "Min";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "C2";
            this.ColTypeDetailMin.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColTypeDetailMin.HeaderText = "Min.";
            this.ColTypeDetailMin.Name = "ColTypeDetailMin";
            this.ColTypeDetailMin.ReadOnly = true;
            this.ColTypeDetailMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeDetailMin.Visible = false;
            this.ColTypeDetailMin.Width = 62;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chartTypeYear);
            this.groupBox3.Location = new System.Drawing.Point(3, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 294);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // chartTypeYear
            // 
            this.chartTypeYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.Inclination = 50;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelStyle.IsStaggered = true;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Format = "#0.00 \'€\'";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY2.LabelStyle.Format = "#0.00 \'€\'";
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "AreaTypeYearDetail";
            this.chartTypeYear.ChartAreas.Add(chartArea1);
            this.chartTypeYear.Location = new System.Drawing.Point(3, 8);
            this.chartTypeYear.Name = "chartTypeYear";
            series1.ChartArea = "AreaTypeYearDetail";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "SerieTypeYear";
            this.chartTypeYear.Series.Add(series1);
            this.chartTypeYear.Size = new System.Drawing.Size(478, 283);
            this.chartTypeYear.TabIndex = 0;
            this.chartTypeYear.Text = "chartReportByType";
            // 
            // ColTypeName
            // 
            this.ColTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTypeName.DataPropertyName = "Type";
            this.ColTypeName.HeaderText = "Categoria";
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
            this.ColTypeTotal.Width = 62;
            // 
            // ColTypePerc
            // 
            this.ColTypePerc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypePerc.DataPropertyName = "Perc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#0.## \'%\'";
            this.ColTypePerc.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTypePerc.HeaderText = "%";
            this.ColTypePerc.Name = "ColTypePerc";
            this.ColTypePerc.ReadOnly = true;
            this.ColTypePerc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypePerc.Width = 52;
            // 
            // ColTypeAvg
            // 
            this.ColTypeAvg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeAvg.DataPropertyName = "Avg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            this.ColTypeAvg.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColTypeAvg.HeaderText = "Media";
            this.ColTypeAvg.Name = "ColTypeAvg";
            this.ColTypeAvg.ReadOnly = true;
            this.ColTypeAvg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeAvg.ToolTipText = "Media";
            this.ColTypeAvg.Width = 62;
            // 
            // ColAvgCurr
            // 
            this.ColAvgCurr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColAvgCurr.DataPropertyName = "CurrAvg";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            this.ColAvgCurr.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColAvgCurr.HeaderText = "Media C";
            this.ColAvgCurr.Name = "ColAvgCurr";
            this.ColAvgCurr.ReadOnly = true;
            this.ColAvgCurr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAvgCurr.ToolTipText = "Media sui mesi passati";
            this.ColAvgCurr.Width = 72;
            // 
            // ColAvgMonth
            // 
            this.ColAvgMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColAvgMonth.DataPropertyName = "MonthAvg";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            this.ColAvgMonth.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColAvgMonth.HeaderText = "Media 12";
            this.ColAvgMonth.Name = "ColAvgMonth";
            this.ColAvgMonth.ReadOnly = true;
            this.ColAvgMonth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAvgMonth.ToolTipText = "Media su 12 mesi";
            this.ColAvgMonth.Width = 78;
            // 
            // ColTypeMax
            // 
            this.ColTypeMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeMax.DataPropertyName = "Max";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            this.ColTypeMax.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColTypeMax.HeaderText = "Max.";
            this.ColTypeMax.Name = "ColTypeMax";
            this.ColTypeMax.ReadOnly = true;
            this.ColTypeMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeMax.Visible = false;
            this.ColTypeMax.Width = 62;
            // 
            // ColTypeMin
            // 
            this.ColTypeMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeMin.DataPropertyName = "Min";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            this.ColTypeMin.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColTypeMin.HeaderText = "Min.";
            this.ColTypeMin.Name = "ColTypeMin";
            this.ColTypeMin.ReadOnly = true;
            this.ColTypeMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeMin.Visible = false;
            this.ColTypeMin.Width = 62;
            // 
            // PageReportTypeYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTypeYearDetail);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.groupFilters);
            this.Controls.Add(this.grpTypeYear);
            this.Controls.Add(this.groupBox3);
            this.Name = "PageReportTypeYear";
            this.Size = new System.Drawing.Size(800, 620);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.grpTypeYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeYear)).EndInit();
            this.groupFilters.ResumeLayout(false);
            this.groupFilters.PerformLayout();
            this.grpTypeYearDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeYearDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox grpTypeYear;
        private System.Windows.Forms.DataGridView dgvTypeYear;
        private System.Windows.Forms.GroupBox groupFilters;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTypeYearDetail;
        private System.Windows.Forms.DataGridView dgvTypeYearDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTypeYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypePerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvgCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvgMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeMin;
    }
}
