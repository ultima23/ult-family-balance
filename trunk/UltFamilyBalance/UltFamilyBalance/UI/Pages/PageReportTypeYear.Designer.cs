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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.grpTypeYear = new System.Windows.Forms.GroupBox();
            this.dgvTypeYear = new System.Windows.Forms.DataGridView();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTypeYearDetail = new System.Windows.Forms.GroupBox();
            this.dgvTypeYearDetail = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartTypeDetail = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColTypeDetailMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeDetailMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypePerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSpacer01 = new System.Windows.Forms.Label();
            this.lblMonthAvg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupTitle.SuspendLayout();
            this.grpTypeYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeYear)).BeginInit();
            this.groupFilters.SuspendLayout();
            this.grpTypeYearDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeYearDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeDetail)).BeginInit();
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
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(238)))));
            this.dgvTypeYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LightYellow;
            this.dgvTypeYearDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chartTypeDetail);
            this.groupBox3.Location = new System.Drawing.Point(491, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 292);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // chartTypeDetail
            // 
            this.chartTypeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Area3DStyle.Inclination = 50;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.LabelStyle.IsStaggered = true;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.LabelStyle.Format = "#0.00 \'€\'";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY2.LabelStyle.Format = "#0.00 \'€\'";
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "AreaTypeYearDetail";
            this.chartTypeDetail.ChartAreas.Add(chartArea2);
            this.chartTypeDetail.Location = new System.Drawing.Point(3, 8);
            this.chartTypeDetail.Name = "chartTypeDetail";
            series2.BorderWidth = 2;
            series2.ChartArea = "AreaTypeYearDetail";
            series2.Color = System.Drawing.Color.Teal;
            series2.CustomProperties = "EmptyPointValue=Zero";
            series2.Enabled = false;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "#0.00 \'€\'";
            series2.Name = "SerieOutgoingCount";
            series2.XValueMember = "MonthName";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueMembers = "Avg";
            this.chartTypeDetail.Series.Add(series2);
            this.chartTypeDetail.Size = new System.Drawing.Size(297, 281);
            this.chartTypeDetail.TabIndex = 0;
            this.chartTypeDetail.Text = "chartReportByType";
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "C2";
            this.ColTypeDetailTotal.DefaultCellStyle = dataGridViewCellStyle19;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "C2";
            this.ColTypeDetailAvg.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "C2";
            this.ColTypeDetailMax.DefaultCellStyle = dataGridViewCellStyle21;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "C2";
            this.ColTypeDetailMin.DefaultCellStyle = dataGridViewCellStyle22;
            this.ColTypeDetailMin.HeaderText = "Min.";
            this.ColTypeDetailMin.Name = "ColTypeDetailMin";
            this.ColTypeDetailMin.ReadOnly = true;
            this.ColTypeDetailMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeDetailMin.Visible = false;
            this.ColTypeDetailMin.Width = 62;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "C2";
            this.ColTypeTotal.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "#0.## \'%\'";
            this.ColTypePerc.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "C2";
            this.ColTypeAvg.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColTypeAvg.HeaderText = "Media";
            this.ColTypeAvg.Name = "ColTypeAvg";
            this.ColTypeAvg.ReadOnly = true;
            this.ColTypeAvg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeAvg.Width = 62;
            // 
            // ColTypeMax
            // 
            this.ColTypeMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeMax.DataPropertyName = "Max";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "C2";
            this.ColTypeMax.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColTypeMax.HeaderText = "Max.";
            this.ColTypeMax.Name = "ColTypeMax";
            this.ColTypeMax.ReadOnly = true;
            this.ColTypeMax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeMax.Width = 62;
            // 
            // ColTypeMin
            // 
            this.ColTypeMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTypeMin.DataPropertyName = "Min";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "C2";
            this.ColTypeMin.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColTypeMin.HeaderText = "Min.";
            this.ColTypeMin.Name = "ColTypeMin";
            this.ColTypeMin.ReadOnly = true;
            this.ColTypeMin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTypeMin.Width = 62;
            // 
            // lblSpacer01
            // 
            this.lblSpacer01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpacer01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpacer01.Location = new System.Drawing.Point(3, 329);
            this.lblSpacer01.Name = "lblSpacer01";
            this.lblSpacer01.Size = new System.Drawing.Size(304, 81);
            this.lblSpacer01.TabIndex = 20;
            this.lblSpacer01.Text = " Proiezione mensile";
            this.lblSpacer01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonthAvg
            // 
            this.lblMonthAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthAvg.Location = new System.Drawing.Point(311, 329);
            this.lblMonthAvg.Name = "lblMonthAvg";
            this.lblMonthAvg.Size = new System.Drawing.Size(88, 18);
            this.lblMonthAvg.TabIndex = 21;
            this.lblMonthAvg.Text = "Media Entrate";
            this.lblMonthAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(311, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Media Uscite";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(311, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Max Uscite";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(311, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Min Uscite";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(402, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Min Uscite";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(402, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Max Uscite";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(402, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Media Uscite";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(402, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Media Entrate";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PageReportTypeYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMonthAvg);
            this.Controls.Add(this.lblSpacer01);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeDetail)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTypeDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeDetailMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypePerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeMin;
        private System.Windows.Forms.Label lblSpacer01;
        private System.Windows.Forms.Label lblMonthAvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
