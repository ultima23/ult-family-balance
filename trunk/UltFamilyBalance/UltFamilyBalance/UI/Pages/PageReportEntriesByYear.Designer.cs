namespace Ult.FamilyBalance.UI
{
    partial class PageReportEntriesByYear
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupEntryList = new System.Windows.Forms.GroupBox();
            this.dgvEntriesReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEntriesReportByType = new System.Windows.Forms.DataGridView();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypePerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chrReportByType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNrEntries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTitle.SuspendLayout();
            this.groupEntryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntriesReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntriesReportByType)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrReportByType)).BeginInit();
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
            this.labelTitle.Size = new System.Drawing.Size(107, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Report Annuale";
            // 
            // groupEntryList
            // 
            this.groupEntryList.Controls.Add(this.dgvEntriesReport);
            this.groupEntryList.Location = new System.Drawing.Point(3, 30);
            this.groupEntryList.Name = "groupEntryList";
            this.groupEntryList.Size = new System.Drawing.Size(224, 247);
            this.groupEntryList.TabIndex = 14;
            this.groupEntryList.TabStop = false;
            // 
            // dgvEntriesReport
            // 
            this.dgvEntriesReport.AllowUserToAddRows = false;
            this.dgvEntriesReport.AllowUserToDeleteRows = false;
            this.dgvEntriesReport.AllowUserToResizeColumns = false;
            this.dgvEntriesReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            this.dgvEntriesReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntriesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntriesReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEntriesReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntriesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntriesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMonth,
            this.ColNrEntries,
            this.ColTotal});
            this.dgvEntriesReport.Location = new System.Drawing.Point(3, 9);
            this.dgvEntriesReport.MultiSelect = false;
            this.dgvEntriesReport.Name = "dgvEntriesReport";
            this.dgvEntriesReport.ReadOnly = true;
            this.dgvEntriesReport.RowHeadersVisible = false;
            this.dgvEntriesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntriesReport.Size = new System.Drawing.Size(218, 235);
            this.dgvEntriesReport.TabIndex = 1;
            this.dgvEntriesReport.SelectionChanged += new System.EventHandler(this.dgvEntriesReport_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvEntriesReportByType);
            this.groupBox1.Location = new System.Drawing.Point(231, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 247);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dgvEntriesReportByType
            // 
            this.dgvEntriesReportByType.AllowUserToAddRows = false;
            this.dgvEntriesReportByType.AllowUserToDeleteRows = false;
            this.dgvEntriesReportByType.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightYellow;
            this.dgvEntriesReportByType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntriesReportByType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntriesReportByType.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEntriesReportByType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntriesReportByType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntriesReportByType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColType,
            this.ColNr,
            this.ColTypeTotal,
            this.ColTypePerc});
            this.dgvEntriesReportByType.Location = new System.Drawing.Point(3, 9);
            this.dgvEntriesReportByType.MultiSelect = false;
            this.dgvEntriesReportByType.Name = "dgvEntriesReportByType";
            this.dgvEntriesReportByType.ReadOnly = true;
            this.dgvEntriesReportByType.RowHeadersVisible = false;
            this.dgvEntriesReportByType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntriesReportByType.Size = new System.Drawing.Size(558, 235);
            this.dgvEntriesReportByType.TabIndex = 1;
            this.dgvEntriesReportByType.SelectionChanged += new System.EventHandler(this.dgvEntriesReportByType_SelectionChanged);
            // 
            // ColType
            // 
            this.ColType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColType.DataPropertyName = "Type";
            dataGridViewCellStyle4.NullValue = null;
            this.ColType.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColType.HeaderText = "Categoria";
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            this.ColType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColNr
            // 
            this.ColNr.DataPropertyName = "Count";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNr.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColNr.HeaderText = "Nr.";
            this.ColNr.Name = "ColNr";
            this.ColNr.ReadOnly = true;
            this.ColNr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNr.Width = 26;
            // 
            // ColTypeTotal
            // 
            this.ColTypeTotal.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.ColTypeTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColTypeTotal.HeaderText = "Totale";
            this.ColTypeTotal.Name = "ColTypeTotal";
            this.ColTypeTotal.ReadOnly = true;
            this.ColTypeTotal.Width = 70;
            // 
            // ColTypePerc
            // 
            this.ColTypePerc.DataPropertyName = "Perc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#0.## \'%\'";
            dataGridViewCellStyle7.NullValue = null;
            this.ColTypePerc.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColTypePerc.HeaderText = "%";
            this.ColTypePerc.Name = "ColTypePerc";
            this.ColTypePerc.ReadOnly = true;
            this.ColTypePerc.Width = 54;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chrReportByType);
            this.groupBox2.Location = new System.Drawing.Point(3, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 338);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // chrReportByType
            // 
            this.chrReportByType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Area3DStyle.Inclination = 50;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Name = "ChartReport";
            this.chrReportByType.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend1.DockedToChartArea = "ChartReport";
            legend1.Name = "Legend1";
            this.chrReportByType.Legends.Add(legend1);
            this.chrReportByType.Location = new System.Drawing.Point(3, 8);
            this.chrReportByType.Name = "chrReportByType";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartReport";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "PieReport";
            series1.ShadowOffset = 1;
            this.chrReportByType.Series.Add(series1);
            this.chrReportByType.Size = new System.Drawing.Size(786, 327);
            this.chrReportByType.TabIndex = 0;
            this.chrReportByType.Text = "chartReportByType";
            // 
            // ColMonth
            // 
            this.ColMonth.DataPropertyName = "Year";
            this.ColMonth.HeaderText = "Anno";
            this.ColMonth.Name = "ColMonth";
            this.ColMonth.ReadOnly = true;
            this.ColMonth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMonth.Width = 90;
            // 
            // ColNrEntries
            // 
            this.ColNrEntries.DataPropertyName = "Count";
            this.ColNrEntries.HeaderText = "Nr";
            this.ColNrEntries.Name = "ColNrEntries";
            this.ColNrEntries.ReadOnly = true;
            this.ColNrEntries.Width = 26;
            // 
            // ColTotal
            // 
            this.ColTotal.DataPropertyName = "Total";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColTotal.HeaderText = "Totale";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            this.ColTotal.Width = 80;
            // 
            // PageReportEntriesByYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.groupEntryList);
            this.Controls.Add(this.groupBox1);
            this.Name = "PageEntryYearReport";
            this.Size = new System.Drawing.Size(800, 620);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.groupEntryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntriesReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntriesReportByType)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrReportByType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupEntryList;
        private System.Windows.Forms.DataGridView dgvEntriesReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEntriesReportByType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrReportByType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypePerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNrEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
    }
}
