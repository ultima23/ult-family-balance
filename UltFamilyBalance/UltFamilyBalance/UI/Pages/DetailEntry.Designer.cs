namespace Ult.FamilyBalance.UI.Pages
{
    partial class DetailEntry
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
            this.lblEntryAmountTitle = new System.Windows.Forms.Label();
            this.lblEntryDateTitle = new System.Windows.Forms.Label();
            this.lblEntryTypeTitle = new System.Windows.Forms.Label();
            this.lblentryNoteTitle = new System.Windows.Forms.Label();
            this.dtpEntityDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEntityType = new System.Windows.Forms.ComboBox();
            this.txtEntryNote = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAmount = new System.Windows.Forms.Panel();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblEntryAmount = new System.Windows.Forms.Label();
            this.groupEntry.SuspendLayout();
            this.tlpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
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
            this.tlpEntry.Controls.Add(this.lblEntryAmountTitle, 0, 0);
            this.tlpEntry.Controls.Add(this.lblEntryDateTitle, 0, 1);
            this.tlpEntry.Controls.Add(this.lblEntryTypeTitle, 0, 2);
            this.tlpEntry.Controls.Add(this.lblentryNoteTitle, 0, 3);
            this.tlpEntry.Controls.Add(this.dtpEntityDate, 1, 1);
            this.tlpEntry.Controls.Add(this.cmbEntityType, 1, 2);
            this.tlpEntry.Controls.Add(this.txtEntryNote, 1, 3);
            this.tlpEntry.Controls.Add(this.panelAmount, 1, 0);
            this.tlpEntry.Location = new System.Drawing.Point(6, 19);
            this.tlpEntry.Name = "tlpEntry";
            this.tlpEntry.RowCount = 4;
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEntry.Size = new System.Drawing.Size(396, 359);
            this.tlpEntry.TabIndex = 0;
            this.tlpEntry.TabStop = true;
            // 
            // lblEntryAmountTitle
            // 
            this.lblEntryAmountTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntryAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryAmountTitle.Location = new System.Drawing.Point(3, 0);
            this.lblEntryAmountTitle.Name = "lblEntryAmountTitle";
            this.lblEntryAmountTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEntryAmountTitle.Size = new System.Drawing.Size(74, 30);
            this.lblEntryAmountTitle.TabIndex = 0;
            this.lblEntryAmountTitle.Text = "Amount";
            this.lblEntryAmountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntryDateTitle
            // 
            this.lblEntryDateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntryDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDateTitle.Location = new System.Drawing.Point(3, 30);
            this.lblEntryDateTitle.Name = "lblEntryDateTitle";
            this.lblEntryDateTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEntryDateTitle.Size = new System.Drawing.Size(74, 30);
            this.lblEntryDateTitle.TabIndex = 1;
            this.lblEntryDateTitle.Text = "Date";
            this.lblEntryDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntryTypeTitle
            // 
            this.lblEntryTypeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntryTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTypeTitle.Location = new System.Drawing.Point(3, 60);
            this.lblEntryTypeTitle.Name = "lblEntryTypeTitle";
            this.lblEntryTypeTitle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEntryTypeTitle.Size = new System.Drawing.Size(74, 30);
            this.lblEntryTypeTitle.TabIndex = 2;
            this.lblEntryTypeTitle.Text = "Type";
            this.lblEntryTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblentryNoteTitle
            // 
            this.lblentryNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblentryNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentryNoteTitle.Location = new System.Drawing.Point(3, 90);
            this.lblentryNoteTitle.Name = "lblentryNoteTitle";
            this.lblentryNoteTitle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblentryNoteTitle.Size = new System.Drawing.Size(74, 269);
            this.lblentryNoteTitle.TabIndex = 3;
            this.lblentryNoteTitle.Text = "Note";
            // 
            // dtpEntityDate
            // 
            this.dtpEntityDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEntityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntityDate.Location = new System.Drawing.Point(83, 33);
            this.dtpEntityDate.Name = "dtpEntityDate";
            this.dtpEntityDate.Size = new System.Drawing.Size(303, 20);
            this.dtpEntityDate.TabIndex = 1;
            // 
            // cmbEntityType
            // 
            this.cmbEntityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntityType.FormattingEnabled = true;
            this.cmbEntityType.Location = new System.Drawing.Point(83, 63);
            this.cmbEntityType.Name = "cmbEntityType";
            this.cmbEntityType.Size = new System.Drawing.Size(303, 21);
            this.cmbEntityType.TabIndex = 2;
            // 
            // txtEntryNote
            // 
            this.txtEntryNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEntryNote.Location = new System.Drawing.Point(83, 93);
            this.txtEntryNote.Multiline = true;
            this.txtEntryNote.Name = "txtEntryNote";
            this.txtEntryNote.Size = new System.Drawing.Size(303, 263);
            this.txtEntryNote.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panelAmount
            // 
            this.panelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAmount.Controls.Add(this.lblEntryAmount);
            this.panelAmount.Controls.Add(this.numAmount);
            this.panelAmount.Location = new System.Drawing.Point(83, 3);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(310, 24);
            this.panelAmount.TabIndex = 0;
            this.panelAmount.TabStop = true;
            // 
            // numAmount
            // 
            this.numAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(0, 1);
            this.numAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(284, 20);
            this.numAmount.TabIndex = 1;
            this.numAmount.ThousandsSeparator = true;
            // 
            // lblEntryAmount
            // 
            this.lblEntryAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntryAmount.AutoSize = true;
            this.lblEntryAmount.Location = new System.Drawing.Point(290, 6);
            this.lblEntryAmount.Name = "lblEntryAmount";
            this.lblEntryAmount.Size = new System.Drawing.Size(13, 13);
            this.lblEntryAmount.TabIndex = 10;
            this.lblEntryAmount.Text = "€";
            // 
            // DetailOutgoingEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupEntry);
            this.Name = "DetailOutgoingEntry";
            this.Size = new System.Drawing.Size(414, 385);
            this.groupEntry.ResumeLayout(false);
            this.tlpEntry.ResumeLayout(false);
            this.tlpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelAmount.ResumeLayout(false);
            this.panelAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEntry;
        private System.Windows.Forms.TableLayoutPanel tlpEntry;
        private System.Windows.Forms.Label lblEntryAmountTitle;
        private System.Windows.Forms.Label lblEntryDateTitle;
        private System.Windows.Forms.Label lblEntryTypeTitle;
        private System.Windows.Forms.Label lblentryNoteTitle;
        private System.Windows.Forms.DateTimePicker dtpEntityDate;
        private System.Windows.Forms.ComboBox cmbEntityType;
        private System.Windows.Forms.TextBox txtEntryNote;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.Label lblEntryAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
    }
}
