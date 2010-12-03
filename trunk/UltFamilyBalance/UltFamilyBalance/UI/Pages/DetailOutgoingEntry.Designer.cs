namespace Ult.FamilyBalance.UI.Pages
{
    partial class DetailOutgoingEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedEntityAmount = new System.Windows.Forms.MaskedTextBox();
            this.dateEntityDate = new System.Windows.Forms.DateTimePicker();
            this.comboEntityType = new System.Windows.Forms.ComboBox();
            this.textEntryNote = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupEntry.SuspendLayout();
            this.tlpEntry.SuspendLayout();
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
            this.groupEntry.Size = new System.Drawing.Size(512, 384);
            this.groupEntry.TabIndex = 0;
            this.groupEntry.TabStop = false;
            // 
            // tlpEntry
            // 
            this.tlpEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEntry.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpEntry.ColumnCount = 2;
            this.tlpEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEntry.Controls.Add(this.label1, 0, 0);
            this.tlpEntry.Controls.Add(this.label2, 0, 1);
            this.tlpEntry.Controls.Add(this.label3, 0, 2);
            this.tlpEntry.Controls.Add(this.label4, 0, 3);
            this.tlpEntry.Controls.Add(this.maskedEntityAmount, 1, 0);
            this.tlpEntry.Controls.Add(this.dateEntityDate, 1, 1);
            this.tlpEntry.Controls.Add(this.comboEntityType, 1, 2);
            this.tlpEntry.Controls.Add(this.textEntryNote, 1, 3);
            this.tlpEntry.Location = new System.Drawing.Point(6, 19);
            this.tlpEntry.Name = "tlpEntry";
            this.tlpEntry.RowCount = 4;
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEntry.Size = new System.Drawing.Size(500, 359);
            this.tlpEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 98);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.label4.Size = new System.Drawing.Size(74, 259);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note";
            // 
            // maskedEntityAmount
            // 
            this.maskedEntityAmount.Location = new System.Drawing.Point(87, 5);
            this.maskedEntityAmount.Name = "maskedEntityAmount";
            this.maskedEntityAmount.Size = new System.Drawing.Size(271, 20);
            this.maskedEntityAmount.TabIndex = 4;
            // 
            // dateEntityDate
            // 
            this.dateEntityDate.CustomFormat = "dd/MM/yyyy";
            this.dateEntityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEntityDate.Location = new System.Drawing.Point(87, 37);
            this.dateEntityDate.Name = "dateEntityDate";
            this.dateEntityDate.Size = new System.Drawing.Size(271, 20);
            this.dateEntityDate.TabIndex = 5;
            // 
            // comboEntityType
            // 
            this.comboEntityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEntityType.FormattingEnabled = true;
            this.comboEntityType.Location = new System.Drawing.Point(87, 69);
            this.comboEntityType.Name = "comboEntityType";
            this.comboEntityType.Size = new System.Drawing.Size(271, 21);
            this.comboEntityType.TabIndex = 6;
            // 
            // textEntryNote
            // 
            this.textEntryNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textEntryNote.Location = new System.Drawing.Point(87, 101);
            this.textEntryNote.Multiline = true;
            this.textEntryNote.Name = "textEntryNote";
            this.textEntryNote.Size = new System.Drawing.Size(271, 253);
            this.textEntryNote.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // DetailOutgoingEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupEntry);
            this.Name = "DetailOutgoingEntry";
            this.Size = new System.Drawing.Size(518, 385);
            this.groupEntry.ResumeLayout(false);
            this.tlpEntry.ResumeLayout(false);
            this.tlpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEntry;
        private System.Windows.Forms.TableLayoutPanel tlpEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedEntityAmount;
        private System.Windows.Forms.DateTimePicker dateEntityDate;
        private System.Windows.Forms.ComboBox comboEntityType;
        private System.Windows.Forms.TextBox textEntryNote;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
