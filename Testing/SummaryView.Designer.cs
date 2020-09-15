namespace FTC
{
    partial class SummaryView
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
            this.SumClose = new System.Windows.Forms.Button();
            this.SummaryViewGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SumClose
            // 
            this.SumClose.Location = new System.Drawing.Point(451, 447);
            this.SumClose.Name = "SumClose";
            this.SumClose.Size = new System.Drawing.Size(104, 25);
            this.SumClose.TabIndex = 21;
            this.SumClose.Text = "Return to Menu";
            this.SumClose.UseVisualStyleBackColor = true;
            this.SumClose.Click += new System.EventHandler(this.SumClose_Click);
            // 
            // SummaryViewGrid
            // 
            this.SummaryViewGrid.AllowUserToAddRows = false;
            this.SummaryViewGrid.AllowUserToDeleteRows = false;
            this.SummaryViewGrid.AllowUserToResizeRows = false;
            this.SummaryViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.SummaryViewGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SummaryViewGrid.Location = new System.Drawing.Point(12, 12);
            this.SummaryViewGrid.MultiSelect = false;
            this.SummaryViewGrid.Name = "SummaryViewGrid";
            this.SummaryViewGrid.ReadOnly = true;
            this.SummaryViewGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SummaryViewGrid.Size = new System.Drawing.Size(543, 429);
            this.SummaryViewGrid.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Full Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 255;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Gender";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date of Birth";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // SummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 509);
            this.Controls.Add(this.SummaryViewGrid);
            this.Controls.Add(this.SumClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SummaryView";
            this.Text = "SummaryView";
            ((System.ComponentModel.ISupportInitialize)(this.SummaryViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SumClose;
        private System.Windows.Forms.DataGridView SummaryViewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}