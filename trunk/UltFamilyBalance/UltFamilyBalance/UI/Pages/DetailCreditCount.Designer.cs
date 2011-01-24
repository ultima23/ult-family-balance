namespace Ult.FamilyBalance.UI.Pages
{
    partial class DetailCreditCount
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
            this.groupEntry = new System.Windows.Forms.GroupBox();
            this.tlpEntry = new System.Windows.Forms.TableLayoutPanel();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBalanceEuro = new System.Windows.Forms.Label();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.pnlIncoming = new System.Windows.Forms.Panel();
            this.lblIncomingEuro = new System.Windows.Forms.Label();
            this.numIncoming = new System.Windows.Forms.NumericUpDown();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.lblIncomingTitle = new System.Windows.Forms.Label();
            this.lblOutgoingTitle = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.labelYearTitle = new System.Windows.Forms.Label();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.lblOutgoingEuro = new System.Windows.Forms.Label();
            this.numOutgoing = new System.Windows.Forms.NumericUpDown();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupEntry.SuspendLayout();
            this.tlpEntry.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.pnlIncoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIncoming)).BeginInit();
            this.panelAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutgoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupEntry
            // 
            this.groupEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEntry.Controls.Add(this.tlpEntry);
            this.groupEntry.Location = new System.Drawing.Point(3, -2);
            this.groupEntry.Name = "groupEntry";
            this.groupEntry.Size = new System.Drawing.Size(408, 384);
            this.groupEntry.TabIndex = 0;
            this.groupEntry.TabStop = false;
            // 
            // tlpEntry
            // 
            this.tlpEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEntry.ColumnCount = 2;
            this.tlpEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEntry.Controls.Add(this.cmbMonth, 1, 1);
            this.tlpEntry.Controls.Add(this.panel1, 1, 4);
            this.tlpEntry.Controls.Add(this.pnlIncoming, 1, 2);
            this.tlpEntry.Controls.Add(this.lblMonthTitle, 0, 1);
            this.tlpEntry.Controls.Add(this.lblIncomingTitle, 0, 2);
            this.tlpEntry.Controls.Add(this.lblOutgoingTitle, 0, 3);
            this.tlpEntry.Controls.Add(this.lblBalance, 0, 4);
            this.tlpEntry.Controls.Add(this.labelYearTitle, 0, 0);
            this.tlpEntry.Controls.Add(this.panelAmount, 1, 3);
            this.tlpEntry.Controls.Add(this.cmbYear, 1, 0);
            this.tlpEntry.Location = new System.Drawing.Point(6, 19);
            this.tlpEntry.Name = "tlpEntry";
            this.tlpEntry.RowCount = 6;
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEntry.Size = new System.Drawing.Size(396, 359);
            this.tlpEntry.TabIndex = 0;
            this.tlpEntry.TabStop = true;
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
            this.cmbMonth.Location = new System.Drawing.Point(83, 33);
            this.cmbMonth.MaxDropDownItems = 12;
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(310, 21);
            this.cmbMonth.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblBalanceEuro);
            this.panel1.Controls.Add(this.numBalance);
            this.panel1.Location = new System.Drawing.Point(83, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 24);
            this.panel1.TabIndex = 4;
            this.panel1.TabStop = true;
            // 
            // lblBalanceEuro
            // 
            this.lblBalanceEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanceEuro.AutoSize = true;
            this.lblBalanceEuro.Location = new System.Drawing.Point(290, 6);
            this.lblBalanceEuro.Name = "lblBalanceEuro";
            this.lblBalanceEuro.Size = new System.Drawing.Size(13, 13);
            this.lblBalanceEuro.TabIndex = 10;
            this.lblBalanceEuro.Text = "€";
            // 
            // numBalance
            // 
            this.numBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numBalance.DecimalPlaces = 2;
            this.numBalance.Location = new System.Drawing.Point(0, 1);
            this.numBalance.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.numBalance.Name = "numBalance";
            this.numBalance.Size = new System.Drawing.Size(284, 20);
            this.numBalance.TabIndex = 1;
            this.numBalance.ThousandsSeparator = true;
            // 
            // pnlIncoming
            // 
            this.pnlIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIncoming.Controls.Add(this.lblIncomingEuro);
            this.pnlIncoming.Controls.Add(this.numIncoming);
            this.pnlIncoming.Location = new System.Drawing.Point(83, 63);
            this.pnlIncoming.Name = "pnlIncoming";
            this.pnlIncoming.Size = new System.Drawing.Size(310, 24);
            this.pnlIncoming.TabIndex = 2;
            this.pnlIncoming.TabStop = true;
            // 
            // lblIncomingEuro
            // 
            this.lblIncomingEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomingEuro.AutoSize = true;
            this.lblIncomingEuro.Location = new System.Drawing.Point(290, 6);
            this.lblIncomingEuro.Name = "lblIncomingEuro";
            this.lblIncomingEuro.Size = new System.Drawing.Size(13, 13);
            this.lblIncomingEuro.TabIndex = 10;
            this.lblIncomingEuro.Text = "€";
            // 
            // numIncoming
            // 
            this.numIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numIncoming.DecimalPlaces = 2;
            this.numIncoming.Location = new System.Drawing.Point(0, 1);
            this.numIncoming.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.numIncoming.Name = "numIncoming";
            this.numIncoming.Size = new System.Drawing.Size(284, 20);
            this.numIncoming.TabIndex = 1;
            this.numIncoming.ThousandsSeparator = true;
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthTitle.Location = new System.Drawing.Point(3, 30);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblMonthTitle.Size = new System.Drawing.Size(74, 30);
            this.lblMonthTitle.TabIndex = 1;
            this.lblMonthTitle.Text = "Mese";
            this.lblMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncomingTitle
            // 
            this.lblIncomingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomingTitle.Location = new System.Drawing.Point(3, 60);
            this.lblIncomingTitle.Name = "lblIncomingTitle";
            this.lblIncomingTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblIncomingTitle.Size = new System.Drawing.Size(74, 30);
            this.lblIncomingTitle.TabIndex = 2;
            this.lblIncomingTitle.Text = "Entrate";
            this.lblIncomingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutgoingTitle
            // 
            this.lblOutgoingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutgoingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutgoingTitle.Location = new System.Drawing.Point(3, 90);
            this.lblOutgoingTitle.Name = "lblOutgoingTitle";
            this.lblOutgoingTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblOutgoingTitle.Size = new System.Drawing.Size(74, 30);
            this.lblOutgoingTitle.TabIndex = 3;
            this.lblOutgoingTitle.Text = "Uscite";
            this.lblOutgoingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(3, 120);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblBalance.Size = new System.Drawing.Size(74, 30);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Saldo";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelYearTitle
            // 
            this.labelYearTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelYearTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearTitle.Location = new System.Drawing.Point(3, 0);
            this.labelYearTitle.Name = "labelYearTitle";
            this.labelYearTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelYearTitle.Size = new System.Drawing.Size(74, 30);
            this.labelYearTitle.TabIndex = 5;
            this.labelYearTitle.Text = "Anno";
            this.labelYearTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAmount
            // 
            this.panelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAmount.Controls.Add(this.lblOutgoingEuro);
            this.panelAmount.Controls.Add(this.numOutgoing);
            this.panelAmount.Location = new System.Drawing.Point(83, 93);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(310, 24);
            this.panelAmount.TabIndex = 3;
            this.panelAmount.TabStop = true;
            // 
            // lblOutgoingEuro
            // 
            this.lblOutgoingEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutgoingEuro.AutoSize = true;
            this.lblOutgoingEuro.Location = new System.Drawing.Point(290, 6);
            this.lblOutgoingEuro.Name = "lblOutgoingEuro";
            this.lblOutgoingEuro.Size = new System.Drawing.Size(13, 13);
            this.lblOutgoingEuro.TabIndex = 10;
            this.lblOutgoingEuro.Text = "€";
            // 
            // numOutgoing
            // 
            this.numOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numOutgoing.DecimalPlaces = 2;
            this.numOutgoing.Location = new System.Drawing.Point(0, 1);
            this.numOutgoing.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.numOutgoing.Name = "numOutgoing";
            this.numOutgoing.Size = new System.Drawing.Size(284, 20);
            this.numOutgoing.TabIndex = 1;
            this.numOutgoing.ThousandsSeparator = true;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(83, 3);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(310, 21);
            this.cmbYear.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // DetailCreditCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupEntry);
            this.Name = "DetailCreditCount";
            this.Size = new System.Drawing.Size(414, 385);
            this.groupEntry.ResumeLayout(false);
            this.tlpEntry.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.pnlIncoming.ResumeLayout(false);
            this.pnlIncoming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIncoming)).EndInit();
            this.panelAmount.ResumeLayout(false);
            this.panelAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOutgoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEntry;
        private System.Windows.Forms.TableLayoutPanel tlpEntry;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel pnlIncoming;
        private System.Windows.Forms.Label lblIncomingEuro;
        private System.Windows.Forms.NumericUpDown numIncoming;
        private System.Windows.Forms.Label lblIncomingTitle;
        private System.Windows.Forms.Label lblOutgoingTitle;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label labelYearTitle;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Label lblOutgoingEuro;
        private System.Windows.Forms.NumericUpDown numOutgoing;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBalanceEuro;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.ComboBox cmbYear;
    }
}
