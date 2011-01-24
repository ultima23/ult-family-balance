namespace Ult.FamilyBalance.UI
{
    partial class PageReportTrendYear
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTrendYear = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chrTrendYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupTrendType = new System.Windows.Forms.GroupBox();
            this.rbtBalance = new System.Windows.Forms.RadioButton();
            this.rbtOutgoing = new System.Windows.Forms.RadioButton();
            this.rbtIncoming = new System.Windows.Forms.RadioButton();
            this.rbtDelta = new System.Windows.Forms.RadioButton();
            this.rbtMissing = new System.Windows.Forms.RadioButton();
            this.ColReportMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReportBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCountInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntriesDelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntriesOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntriesInc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntriesMiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFiller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTitle.SuspendLayout();
            this.groupFilters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrendYear)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrTrendYear)).BeginInit();
            this.groupTrendType.SuspendLayout();
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
            this.groupTitle.TabIndex = 4;
            this.groupTitle.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(5, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Trend Annuale";
            // 
            // groupFilters
            // 
            this.groupFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilters.Controls.Add(this.cmbYear);
            this.groupFilters.Controls.Add(this.label1);
            this.groupFilters.Location = new System.Drawing.Point(628, 30);
            this.groupFilters.Name = "groupFilters";
            this.groupFilters.Size = new System.Drawing.Size(167, 294);
            this.groupFilters.TabIndex = 13;
            this.groupFilters.TabStop = false;
            this.groupFilters.Text = "Filtro";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(9, 32);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(151, 21);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvTrendYear);
            this.groupBox1.Location = new System.Drawing.Point(3, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 295);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dgvTrendYear
            // 
            this.dgvTrendYear.AllowUserToAddRows = false;
            this.dgvTrendYear.AllowUserToDeleteRows = false;
            this.dgvTrendYear.AllowUserToResizeColumns = false;
            this.dgvTrendYear.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            this.dgvTrendYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrendYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrendYear.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTrendYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrendYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrendYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColReportMonth,
            this.ColReportBalance,
            this.ColCountDelta,
            this.ColCountOut,
            this.ColCountInc,
            this.ColEntriesDelta,
            this.ColEntriesOut,
            this.ColEntriesInc,
            this.ColEntriesMiss,
            this.ColFiller});
            this.dgvTrendYear.Location = new System.Drawing.Point(3, 9);
            this.dgvTrendYear.MultiSelect = false;
            this.dgvTrendYear.Name = "dgvTrendYear";
            this.dgvTrendYear.ReadOnly = true;
            this.dgvTrendYear.RowHeadersVisible = false;
            this.dgvTrendYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrendYear.Size = new System.Drawing.Size(615, 283);
            this.dgvTrendYear.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chrTrendYear);
            this.groupBox2.Location = new System.Drawing.Point(3, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 292);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // chrTrendYear
            // 
            this.chrTrendYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
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
            chartArea1.Name = "AreaTrendYear";
            this.chrTrendYear.ChartAreas.Add(chartArea1);
            this.chrTrendYear.Location = new System.Drawing.Point(3, 8);
            this.chrTrendYear.Name = "chrTrendYear";
            series1.BorderWidth = 2;
            series1.ChartArea = "AreaTrendYear";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "#0.00 \'€\'";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "SerieBalance";
            series1.XValueMember = "MonthName";
            series1.YValueMembers = "CountBalance";
            series2.BorderWidth = 2;
            series2.ChartArea = "AreaTrendYear";
            series2.Color = System.Drawing.Color.Teal;
            series2.CustomProperties = "EmptyPointValue=Zero";
            series2.Enabled = false;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "#0.00 \'€\'";
            series2.Name = "SerieOutgoingCount";
            series2.XValueMember = "MonthName";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueMembers = "CountOutgoing";
            series3.ChartArea = "AreaTrendYear";
            series3.CustomProperties = "EmptyPointValue=Zero";
            series3.Enabled = false;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "#0.00 \'€\'";
            series3.Name = "SerieOutgoingEntries";
            series3.XValueMember = "MonthName";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueMembers = "EntriesOutgoing";
            series4.ChartArea = "AreaTrendYear";
            series4.Enabled = false;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "#0.00 \'€\'";
            series4.Name = "SerieIncomingCount";
            series4.XValueMember = "MonthName";
            series4.YValueMembers = "CountIncoming";
            series5.ChartArea = "AreaTrendYear";
            series5.Enabled = false;
            series5.IsValueShownAsLabel = true;
            series5.LabelFormat = "#0.00 \'€\'";
            series5.Name = "SerieIncomingEntries";
            series5.XValueMember = "MonthName";
            series5.YValueMembers = "EntriesIncoming";
            series6.ChartArea = "AreaTrendYear";
            series6.Color = System.Drawing.Color.LimeGreen;
            series6.Enabled = false;
            series6.IsValueShownAsLabel = true;
            series6.LabelFormat = "#0.00 \'€\'";
            series6.Name = "SerieDeltaCount";
            series6.XValueMember = "MonthName";
            series6.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.YValueMembers = "CountDelta";
            series7.ChartArea = "AreaTrendYear";
            series7.Color = System.Drawing.Color.Gold;
            series7.Enabled = false;
            series7.IsValueShownAsLabel = true;
            series7.LabelFormat = "#0.00 \'€\'";
            series7.Name = "SerieDeltaEntries";
            series7.XValueMember = "MonthName";
            series7.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series7.YValueMembers = "EntriesDelta";
            series8.ChartArea = "AreaTrendYear";
            series8.Color = System.Drawing.Color.Gray;
            series8.Enabled = false;
            series8.IsValueShownAsLabel = true;
            series8.LabelFormat = "#0.00 \'€\'";
            series8.Name = "SerieMissingIncoming";
            series8.XValueMember = "MonthName";
            series8.YValueMembers = "MissingIncoming";
            series9.ChartArea = "AreaTrendYear";
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.Enabled = false;
            series9.IsValueShownAsLabel = true;
            series9.LabelFormat = "#0.00 \'€\'";
            series9.Name = "SerieMissingOutgoing";
            series9.XValueMember = "MonthName";
            series9.YValueMembers = "MissingIncoming";
            this.chrTrendYear.Series.Add(series1);
            this.chrTrendYear.Series.Add(series2);
            this.chrTrendYear.Series.Add(series3);
            this.chrTrendYear.Series.Add(series4);
            this.chrTrendYear.Series.Add(series5);
            this.chrTrendYear.Series.Add(series6);
            this.chrTrendYear.Series.Add(series7);
            this.chrTrendYear.Series.Add(series8);
            this.chrTrendYear.Series.Add(series9);
            this.chrTrendYear.Size = new System.Drawing.Size(614, 281);
            this.chrTrendYear.TabIndex = 0;
            this.chrTrendYear.Text = "chartReportByType";
            // 
            // groupTrendType
            // 
            this.groupTrendType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTrendType.Controls.Add(this.rbtMissing);
            this.groupTrendType.Controls.Add(this.rbtDelta);
            this.groupTrendType.Controls.Add(this.rbtIncoming);
            this.groupTrendType.Controls.Add(this.rbtOutgoing);
            this.groupTrendType.Controls.Add(this.rbtBalance);
            this.groupTrendType.Location = new System.Drawing.Point(628, 324);
            this.groupTrendType.Name = "groupTrendType";
            this.groupTrendType.Size = new System.Drawing.Size(167, 292);
            this.groupTrendType.TabIndex = 17;
            this.groupTrendType.TabStop = false;
            this.groupTrendType.Text = "Grafico";
            // 
            // rbtBalance
            // 
            this.rbtBalance.AutoSize = true;
            this.rbtBalance.Checked = true;
            this.rbtBalance.Location = new System.Drawing.Point(9, 19);
            this.rbtBalance.Name = "rbtBalance";
            this.rbtBalance.Size = new System.Drawing.Size(62, 17);
            this.rbtBalance.TabIndex = 0;
            this.rbtBalance.TabStop = true;
            this.rbtBalance.Text = "Bilancio";
            this.rbtBalance.UseVisualStyleBackColor = true;
            this.rbtBalance.CheckedChanged += new System.EventHandler(this.rbtBalance_CheckedChanged);
            // 
            // rbtOutgoing
            // 
            this.rbtOutgoing.AutoSize = true;
            this.rbtOutgoing.Location = new System.Drawing.Point(9, 42);
            this.rbtOutgoing.Name = "rbtOutgoing";
            this.rbtOutgoing.Size = new System.Drawing.Size(55, 17);
            this.rbtOutgoing.TabIndex = 1;
            this.rbtOutgoing.Text = "Uscite";
            this.rbtOutgoing.UseVisualStyleBackColor = true;
            this.rbtOutgoing.CheckedChanged += new System.EventHandler(this.rbtOutgoing_CheckedChanged);
            // 
            // rbtIncoming
            // 
            this.rbtIncoming.AutoSize = true;
            this.rbtIncoming.Location = new System.Drawing.Point(9, 65);
            this.rbtIncoming.Name = "rbtIncoming";
            this.rbtIncoming.Size = new System.Drawing.Size(59, 17);
            this.rbtIncoming.TabIndex = 2;
            this.rbtIncoming.Text = "Entrate";
            this.rbtIncoming.UseVisualStyleBackColor = true;
            this.rbtIncoming.CheckedChanged += new System.EventHandler(this.rbtIncoming_CheckedChanged);
            // 
            // rbtDelta
            // 
            this.rbtDelta.AutoSize = true;
            this.rbtDelta.Location = new System.Drawing.Point(9, 88);
            this.rbtDelta.Name = "rbtDelta";
            this.rbtDelta.Size = new System.Drawing.Size(50, 17);
            this.rbtDelta.TabIndex = 3;
            this.rbtDelta.Text = "Delta";
            this.rbtDelta.UseVisualStyleBackColor = true;
            this.rbtDelta.CheckedChanged += new System.EventHandler(this.rbtDelta_CheckedChanged);
            // 
            // rbtMissing
            // 
            this.rbtMissing.AutoSize = true;
            this.rbtMissing.Location = new System.Drawing.Point(9, 111);
            this.rbtMissing.Name = "rbtMissing";
            this.rbtMissing.Size = new System.Drawing.Size(73, 17);
            this.rbtMissing.TabIndex = 4;
            this.rbtMissing.Text = "Mancante";
            this.rbtMissing.UseVisualStyleBackColor = true;
            this.rbtMissing.CheckedChanged += new System.EventHandler(this.rbtMissing_CheckedChanged);
            // 
            // ColReportMonth
            // 
            this.ColReportMonth.DataPropertyName = "MonthName";
            this.ColReportMonth.HeaderText = "Mese";
            this.ColReportMonth.Name = "ColReportMonth";
            this.ColReportMonth.ReadOnly = true;
            this.ColReportMonth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColReportMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColReportMonth.Width = 62;
            // 
            // ColReportBalance
            // 
            this.ColReportBalance.DataPropertyName = "CountBalance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "#0.00 \'€\'";
            this.ColReportBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColReportBalance.HeaderText = "Totale";
            this.ColReportBalance.Name = "ColReportBalance";
            this.ColReportBalance.ReadOnly = true;
            this.ColReportBalance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColReportBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColReportBalance.Width = 80;
            // 
            // ColCountDelta
            // 
            this.ColCountDelta.DataPropertyName = "CountDelta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#0.00 \'€\'";
            this.ColCountDelta.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCountDelta.HeaderText = "Delta";
            this.ColCountDelta.Name = "ColCountDelta";
            this.ColCountDelta.ReadOnly = true;
            this.ColCountDelta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCountDelta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCountDelta.Width = 70;
            // 
            // ColCountOut
            // 
            this.ColCountOut.DataPropertyName = "CountOutgoing";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#0.00 \'€\'";
            this.ColCountOut.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCountOut.HeaderText = "Uscite";
            this.ColCountOut.Name = "ColCountOut";
            this.ColCountOut.ReadOnly = true;
            this.ColCountOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCountOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCountOut.Width = 70;
            // 
            // ColCountInc
            // 
            this.ColCountInc.DataPropertyName = "CountIncoming";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#0.00 \'€\'";
            this.ColCountInc.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColCountInc.HeaderText = "Entrate";
            this.ColCountInc.Name = "ColCountInc";
            this.ColCountInc.ReadOnly = true;
            this.ColCountInc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCountInc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCountInc.Width = 70;
            // 
            // ColEntriesDelta
            // 
            this.ColEntriesDelta.DataPropertyName = "EntriesDelta";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#0.00 \'€\'";
            this.ColEntriesDelta.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColEntriesDelta.HeaderText = "Delta";
            this.ColEntriesDelta.Name = "ColEntriesDelta";
            this.ColEntriesDelta.ReadOnly = true;
            this.ColEntriesDelta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEntriesDelta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColEntriesDelta.Width = 60;
            // 
            // ColEntriesOut
            // 
            this.ColEntriesOut.DataPropertyName = "EntriesOutgoing";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#0.00 \'€\'";
            this.ColEntriesOut.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColEntriesOut.HeaderText = "Uscite";
            this.ColEntriesOut.Name = "ColEntriesOut";
            this.ColEntriesOut.ReadOnly = true;
            this.ColEntriesOut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEntriesOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColEntriesOut.Width = 60;
            // 
            // ColEntriesInc
            // 
            this.ColEntriesInc.DataPropertyName = "EntriesIncoming";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#0.00 \'€\'";
            this.ColEntriesInc.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColEntriesInc.HeaderText = "Entrate";
            this.ColEntriesInc.Name = "ColEntriesInc";
            this.ColEntriesInc.ReadOnly = true;
            this.ColEntriesInc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEntriesInc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColEntriesInc.Width = 60;
            // 
            // ColEntriesMiss
            // 
            this.ColEntriesMiss.DataPropertyName = "MissingOutgoing";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#0.00 \'€\'";
            this.ColEntriesMiss.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColEntriesMiss.HeaderText = "Mancante";
            this.ColEntriesMiss.Name = "ColEntriesMiss";
            this.ColEntriesMiss.ReadOnly = true;
            this.ColEntriesMiss.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEntriesMiss.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColEntriesMiss.Width = 70;
            // 
            // ColFiller
            // 
            this.ColFiller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFiller.HeaderText = "";
            this.ColFiller.Name = "ColFiller";
            this.ColFiller.ReadOnly = true;
            this.ColFiller.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColFiller.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PageReportTrendYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupTrendType);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.groupFilters);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PageReportTrendYear";
            this.Size = new System.Drawing.Size(800, 620);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.groupFilters.ResumeLayout(false);
            this.groupFilters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrendYear)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrTrendYear)).EndInit();
            this.groupTrendType.ResumeLayout(false);
            this.groupTrendType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupFilters;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTrendYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrTrendYear;
        private System.Windows.Forms.GroupBox groupTrendType;
        private System.Windows.Forms.RadioButton rbtDelta;
        private System.Windows.Forms.RadioButton rbtIncoming;
        private System.Windows.Forms.RadioButton rbtOutgoing;
        private System.Windows.Forms.RadioButton rbtBalance;
        private System.Windows.Forms.RadioButton rbtMissing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReportMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReportBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountDelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCountInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntriesDelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntriesOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntriesInc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntriesMiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFiller;
    }
}
