namespace Ult.FamilyBalance.UI
{
    partial class FormCalc
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotTitle = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();
            // 
            // numValue
            // 
            this.numValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.numValue.DecimalPlaces = 2;
            this.numValue.Location = new System.Drawing.Point(12, 12);
            this.numValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(150, 20);
            this.numValue.TabIndex = 0;
            this.numValue.ThousandsSeparator = true;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 38);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(120, 134);
            this.lstItems.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(138, 67);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 24);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotTitle
            // 
            this.lblTotTitle.AutoSize = true;
            this.lblTotTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotTitle.Location = new System.Drawing.Point(10, 178);
            this.lblTotTitle.Name = "lblTotTitle";
            this.lblTotTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTotTitle.TabIndex = 4;
            this.lblTotTitle.Text = "Tot:";
            // 
            // lblTot
            // 
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(44, 178);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(88, 13);
            this.lblTot.TabIndex = 5;
            this.lblTot.Text = "0,00 €";
            this.lblTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Location = new System.Drawing.Point(15, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Ok";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(138, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(24, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "c";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 228);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblTotTitle);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.numValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " Calculator";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCalc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotTitle;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClear;
    }
}