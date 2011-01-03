namespace Ult.FamilyBalance.UI.Pages
{
    partial class PageMonthReport
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
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabDataGrid = new System.Windows.Forms.TabPage();
            this.tabDataGraph = new System.Windows.Forms.TabPage();
            this.groupTitle = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabData.SuspendLayout();
            this.groupTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabData
            // 
            this.tabData.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabData.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabData.Controls.Add(this.tabDataGrid);
            this.tabData.Controls.Add(this.tabDataGraph);
            this.tabData.Location = new System.Drawing.Point(3, 36);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(662, 359);
            this.tabData.TabIndex = 0;
            // 
            // tabDataGrid
            // 
            this.tabDataGrid.Location = new System.Drawing.Point(4, 4);
            this.tabDataGrid.Name = "tabDataGrid";
            this.tabDataGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataGrid.Size = new System.Drawing.Size(654, 0);
            this.tabDataGrid.TabIndex = 0;
            this.tabDataGrid.Text = "Dati";
            this.tabDataGrid.UseVisualStyleBackColor = true;
            // 
            // tabDataGraph
            // 
            this.tabDataGraph.Location = new System.Drawing.Point(4, 4);
            this.tabDataGraph.Name = "tabDataGraph";
            this.tabDataGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataGraph.Size = new System.Drawing.Size(654, 0);
            this.tabDataGraph.TabIndex = 1;
            this.tabDataGraph.Text = "Grafico";
            this.tabDataGraph.UseVisualStyleBackColor = true;
            // 
            // groupTitle
            // 
            this.groupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTitle.Controls.Add(this.labelTitle);
            this.groupTitle.Location = new System.Drawing.Point(3, -2);
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
            this.labelTitle.Size = new System.Drawing.Size(103, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Report Mensile";
            // 
            // PageMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupTitle);
            this.Controls.Add(this.tabData);
            this.Name = "PageMonthReport";
            this.Size = new System.Drawing.Size(670, 400);
            this.tabData.ResumeLayout(false);
            this.groupTitle.ResumeLayout(false);
            this.groupTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabDataGrid;
        private System.Windows.Forms.TabPage tabDataGraph;
        private System.Windows.Forms.GroupBox groupTitle;
        private System.Windows.Forms.Label labelTitle;
    }
}
