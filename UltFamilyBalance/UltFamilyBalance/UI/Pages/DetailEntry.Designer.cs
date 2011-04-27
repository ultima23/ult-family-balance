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
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEntryType = new System.Windows.Forms.ComboBox();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.btnEntryAmountCalc = new System.Windows.Forms.Button();
            this.numEntryAmount = new System.Windows.Forms.NumericUpDown();
            this.txtEntryNote = new System.Windows.Forms.TextBox();
            this.lblentryNoteTitle = new System.Windows.Forms.Label();
            this.lblEntryUser = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbEntryUser = new System.Windows.Forms.ComboBox();
            this.groupEntry.SuspendLayout();
            this.tlpEntry.SuspendLayout();
            this.panelAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntryAmount)).BeginInit();
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
            this.groupEntry.Size = new System.Drawing.Size(394, 384);
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
            this.tlpEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEntry.Controls.Add(this.lblEntryAmountTitle, 0, 0);
            this.tlpEntry.Controls.Add(this.lblEntryDateTitle, 0, 1);
            this.tlpEntry.Controls.Add(this.lblEntryTypeTitle, 0, 2);
            this.tlpEntry.Controls.Add(this.dtpEntryDate, 1, 1);
            this.tlpEntry.Controls.Add(this.cmbEntryType, 1, 2);
            this.tlpEntry.Controls.Add(this.panelAmount, 1, 0);
            this.tlpEntry.Controls.Add(this.txtEntryNote, 1, 4);
            this.tlpEntry.Controls.Add(this.lblentryNoteTitle, 0, 4);
            this.tlpEntry.Controls.Add(this.lblEntryUser, 0, 3);
            this.tlpEntry.Controls.Add(this.cmbEntryUser, 1, 3);
            this.tlpEntry.Location = new System.Drawing.Point(6, 19);
            this.tlpEntry.Name = "tlpEntry";
            this.tlpEntry.RowCount = 5;
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEntry.Size = new System.Drawing.Size(382, 359);
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
            this.lblEntryAmountTitle.Text = "Importo";
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
            this.lblEntryDateTitle.Text = "Data";
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
            this.lblEntryTypeTitle.Text = "Categoria";
            this.lblEntryTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEntryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntryDate.Location = new System.Drawing.Point(83, 33);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(296, 20);
            this.dtpEntryDate.TabIndex = 1;
            // 
            // cmbEntryType
            // 
            this.cmbEntryType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEntryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryType.FormattingEnabled = true;
            this.cmbEntryType.Location = new System.Drawing.Point(83, 63);
            this.cmbEntryType.Name = "cmbEntryType";
            this.cmbEntryType.Size = new System.Drawing.Size(296, 21);
            this.cmbEntryType.TabIndex = 2;
            // 
            // panelAmount
            // 
            this.panelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAmount.Controls.Add(this.btnEntryAmountCalc);
            this.panelAmount.Controls.Add(this.numEntryAmount);
            this.panelAmount.Location = new System.Drawing.Point(83, 3);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(296, 24);
            this.panelAmount.TabIndex = 0;
            this.panelAmount.TabStop = true;
            // 
            // btnEntryAmountCalc
            // 
            this.btnEntryAmountCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntryAmountCalc.Image = global::Ult.FamilyBalance.Properties.Resources.coins_add;
            this.btnEntryAmountCalc.Location = new System.Drawing.Point(265, 0);
            this.btnEntryAmountCalc.Name = "btnEntryAmountCalc";
            this.btnEntryAmountCalc.Size = new System.Drawing.Size(29, 24);
            this.btnEntryAmountCalc.TabIndex = 12;
            this.btnEntryAmountCalc.UseVisualStyleBackColor = true;
            this.btnEntryAmountCalc.Click += new System.EventHandler(this.btnAmountCalc_Click);
            // 
            // numEntryAmount
            // 
            this.numEntryAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numEntryAmount.DecimalPlaces = 2;
            this.numEntryAmount.Location = new System.Drawing.Point(0, 1);
            this.numEntryAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.numEntryAmount.Name = "numEntryAmount";
            this.numEntryAmount.Size = new System.Drawing.Size(259, 20);
            this.numEntryAmount.TabIndex = 1;
            this.numEntryAmount.ThousandsSeparator = true;
            // 
            // txtEntryNote
            // 
            this.txtEntryNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntryNote.Location = new System.Drawing.Point(83, 123);
            this.txtEntryNote.Multiline = true;
            this.txtEntryNote.Name = "txtEntryNote";
            this.txtEntryNote.Size = new System.Drawing.Size(296, 233);
            this.txtEntryNote.TabIndex = 3;
            // 
            // lblentryNoteTitle
            // 
            this.lblentryNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblentryNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblentryNoteTitle.Location = new System.Drawing.Point(3, 120);
            this.lblentryNoteTitle.Name = "lblentryNoteTitle";
            this.lblentryNoteTitle.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblentryNoteTitle.Size = new System.Drawing.Size(74, 239);
            this.lblentryNoteTitle.TabIndex = 3;
            this.lblentryNoteTitle.Text = "Note";
            // 
            // lblEntryUser
            // 
            this.lblEntryUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntryUser.AutoSize = true;
            this.lblEntryUser.Location = new System.Drawing.Point(3, 90);
            this.lblEntryUser.Name = "lblEntryUser";
            this.lblEntryUser.Size = new System.Drawing.Size(74, 30);
            this.lblEntryUser.TabIndex = 4;
            this.lblEntryUser.Text = "Utente";
            this.lblEntryUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cmbEntryUser
            // 
            this.cmbEntryUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEntryUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntryUser.Location = new System.Drawing.Point(83, 93);
            this.cmbEntryUser.Name = "cmbEntryUser";
            this.cmbEntryUser.Size = new System.Drawing.Size(296, 21);
            this.cmbEntryUser.TabIndex = 5;
            // 
            // DetailEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupEntry);
            this.Name = "DetailEntry";
            this.Size = new System.Drawing.Size(400, 385);
            this.Load += new System.EventHandler(this.DetailEntry_Load);
            this.groupEntry.ResumeLayout(false);
            this.tlpEntry.ResumeLayout(false);
            this.tlpEntry.PerformLayout();
            this.panelAmount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEntryAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEntry;
        private System.Windows.Forms.TableLayoutPanel tlpEntry;
        private System.Windows.Forms.Label lblEntryAmountTitle;
        private System.Windows.Forms.Label lblEntryDateTitle;
        private System.Windows.Forms.Label lblEntryTypeTitle;
        private System.Windows.Forms.Label lblentryNoteTitle;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.ComboBox cmbEntryType;
        private System.Windows.Forms.TextBox txtEntryNote;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.NumericUpDown numEntryAmount;
        private System.Windows.Forms.Button btnEntryAmountCalc;
        private System.Windows.Forms.Label lblEntryUser;
        private System.Windows.Forms.ComboBox cmbEntryUser;
    }
}
