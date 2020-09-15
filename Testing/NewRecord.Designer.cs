namespace FTC
{
    partial class NewRecord
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
            this.components = new System.ComponentModel.Container();
            this.FirstNameEntry = new System.Windows.Forms.TextBox();
            this.AddCancel = new System.Windows.Forms.Button();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LastNameEntry = new System.Windows.Forms.TextBox();
            this.LNLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddSubmit = new System.Windows.Forms.Button();
            this.RecordDisplay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpouseEntryLabel = new System.Windows.Forms.Label();
            this.SpouseEntry = new System.Windows.Forms.ComboBox();
            this.MNLabel = new System.Windows.Forms.Label();
            this.MiddleNameEntry = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SpouseKidsDisplay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PreviousNamesEntry = new System.Windows.Forms.TextBox();
            this.PreviousAddButton = new System.Windows.Forms.Button();
            this.PreviousRemoveButton = new System.Windows.Forms.Button();
            this.PreviousNamesList = new System.Windows.Forms.ListBox();
            this.MdNLabel = new System.Windows.Forms.Label();
            this.MaidenNameEntry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DoDLabel = new System.Windows.Forms.Label();
            this.IsDeceased = new System.Windows.Forms.CheckBox();
            this.DoBEntry = new System.Windows.Forms.DateTimePicker();
            this.DoDEntry = new System.Windows.Forms.DateTimePicker();
            this.ParentsEntryLabel = new System.Windows.Forms.Label();
            this.ParentsEntry = new System.Windows.Forms.ComboBox();
            this.KidsEntryLabel = new System.Windows.Forms.Label();
            this.KidsEntry = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameEntry
            // 
            this.FirstNameEntry.Location = new System.Drawing.Point(108, 56);
            this.FirstNameEntry.Name = "FirstNameEntry";
            this.FirstNameEntry.Size = new System.Drawing.Size(97, 20);
            this.FirstNameEntry.TabIndex = 0;
            this.FirstNameEntry.TextChanged += new System.EventHandler(this.FirstNameEntry_TextChanged);
            this.FirstNameEntry.MouseCaptureChanged += new System.EventHandler(this.FirstNameEntry_MouseCaptureChanged);
            // 
            // AddCancel
            // 
            this.AddCancel.Location = new System.Drawing.Point(495, 505);
            this.AddCancel.Name = "AddCancel";
            this.AddCancel.Size = new System.Drawing.Size(80, 21);
            this.AddCancel.TabIndex = 12;
            this.AddCancel.Text = "Cancel";
            this.AddCancel.UseVisualStyleBackColor = true;
            this.AddCancel.Click += new System.EventHandler(this.AddCancel_Click);
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(45, 63);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(57, 13);
            this.FNLabel.TabIndex = 255;
            this.FNLabel.Text = "First Name";
            // 
            // LastNameEntry
            // 
            this.LastNameEntry.Location = new System.Drawing.Point(108, 82);
            this.LastNameEntry.Name = "LastNameEntry";
            this.LastNameEntry.Size = new System.Drawing.Size(97, 20);
            this.LastNameEntry.TabIndex = 2;
            this.LastNameEntry.TextChanged += new System.EventHandler(this.LastNameEntry_TextChanged);
            this.LastNameEntry.MouseCaptureChanged += new System.EventHandler(this.LastNameEntry_MouseCaptureChanged);
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(45, 89);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(58, 13);
            this.LNLabel.TabIndex = 43;
            this.LNLabel.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create New Record";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(45, 114);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 30;
            this.GenderLabel.Text = "Gender";
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Location = new System.Drawing.Point(6, 9);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(48, 17);
            this.MaleButton.TabIndex = 4;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            this.MaleButton.Click += new System.EventHandler(this.MaleButton_Click);
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(6, 30);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleButton.TabIndex = 5;
            this.FemaleButton.TabStop = true;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            this.FemaleButton.Click += new System.EventHandler(this.FemaleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MaleButton);
            this.groupBox1.Controls.Add(this.FemaleButton);
            this.groupBox1.Location = new System.Drawing.Point(108, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 51);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // AddSubmit
            // 
            this.AddSubmit.Location = new System.Drawing.Point(495, 468);
            this.AddSubmit.Name = "AddSubmit";
            this.AddSubmit.Size = new System.Drawing.Size(80, 21);
            this.AddSubmit.TabIndex = 11;
            this.AddSubmit.Text = "Submit";
            this.AddSubmit.UseVisualStyleBackColor = true;
            this.AddSubmit.Click += new System.EventHandler(this.AddSubmit_Click);
            // 
            // RecordDisplay
            // 
            this.RecordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordDisplay.Location = new System.Drawing.Point(466, 56);
            this.RecordDisplay.Name = "RecordDisplay";
            this.RecordDisplay.ReadOnly = true;
            this.RecordDisplay.Size = new System.Drawing.Size(97, 20);
            this.RecordDisplay.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Record #";
            // 
            // SpouseEntryLabel
            // 
            this.SpouseEntryLabel.AutoSize = true;
            this.SpouseEntryLabel.Location = new System.Drawing.Point(45, 167);
            this.SpouseEntryLabel.Name = "SpouseEntryLabel";
            this.SpouseEntryLabel.Size = new System.Drawing.Size(43, 13);
            this.SpouseEntryLabel.TabIndex = 44;
            this.SpouseEntryLabel.Text = "Spouse";
            // 
            // SpouseEntry
            // 
            this.SpouseEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpouseEntry.FormattingEnabled = true;
            this.SpouseEntry.Location = new System.Drawing.Point(108, 164);
            this.SpouseEntry.Name = "SpouseEntry";
            this.SpouseEntry.Size = new System.Drawing.Size(271, 21);
            this.SpouseEntry.TabIndex = 6;
            this.SpouseEntry.SelectedValueChanged += new System.EventHandler(this.SpouseEntry_SelectedValueChanged);
            // 
            // MNLabel
            // 
            this.MNLabel.AutoSize = true;
            this.MNLabel.Location = new System.Drawing.Point(211, 63);
            this.MNLabel.Name = "MNLabel";
            this.MNLabel.Size = new System.Drawing.Size(69, 13);
            this.MNLabel.TabIndex = 15;
            this.MNLabel.Text = "Middle Name";
            this.toolTip1.SetToolTip(this.MNLabel, "Enter all middle names here, leave blank if no middle name.");
            // 
            // MiddleNameEntry
            // 
            this.MiddleNameEntry.Location = new System.Drawing.Point(298, 56);
            this.MiddleNameEntry.Name = "MiddleNameEntry";
            this.MiddleNameEntry.Size = new System.Drawing.Size(97, 20);
            this.MiddleNameEntry.TabIndex = 1;
            this.toolTip1.SetToolTip(this.MiddleNameEntry, "Enter all middle names here, leave blank if no middle name.");
            this.MiddleNameEntry.TextChanged += new System.EventHandler(this.MiddleNameEntry_TextChanged);
            this.MiddleNameEntry.MouseCaptureChanged += new System.EventHandler(this.MiddleNameEntry_MouseCaptureChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 258;
            this.label1.Text = "Kid(s) from";
            this.toolTip1.SetToolTip(this.label1, "Spouse\'s kids will automatically be added to this record.");
            // 
            // SpouseKidsDisplay
            // 
            this.SpouseKidsDisplay.FormattingEnabled = true;
            this.SpouseKidsDisplay.Location = new System.Drawing.Point(108, 309);
            this.SpouseKidsDisplay.Name = "SpouseKidsDisplay";
            this.SpouseKidsDisplay.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.SpouseKidsDisplay.Size = new System.Drawing.Size(198, 56);
            this.SpouseKidsDisplay.TabIndex = 259;
            this.toolTip1.SetToolTip(this.SpouseKidsDisplay, "Spouse\'s kids will automatically be added to this record.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 260;
            this.label2.Text = "Spouse";
            this.toolTip1.SetToolTip(this.label2, "Spouse\'s kids will automatically be added to this record.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 261;
            this.label4.Text = "Previous Names";
            this.toolTip1.SetToolTip(this.label4, "Add any previously used last names here.");
            // 
            // PreviousNamesEntry
            // 
            this.PreviousNamesEntry.Location = new System.Drawing.Point(298, 108);
            this.PreviousNamesEntry.Name = "PreviousNamesEntry";
            this.PreviousNamesEntry.Size = new System.Drawing.Size(97, 20);
            this.PreviousNamesEntry.TabIndex = 262;
            this.toolTip1.SetToolTip(this.PreviousNamesEntry, "Add any previously used last names here.");
            this.PreviousNamesEntry.TextChanged += new System.EventHandler(this.PreviousNamesEntry_TextChanged);
            this.PreviousNamesEntry.MouseCaptureChanged += new System.EventHandler(this.PreviousNamesEntry_MouseCaptureChanged);
            // 
            // PreviousAddButton
            // 
            this.PreviousAddButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PreviousAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousAddButton.Location = new System.Drawing.Point(421, 99);
            this.PreviousAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.PreviousAddButton.Name = "PreviousAddButton";
            this.PreviousAddButton.Size = new System.Drawing.Size(26, 17);
            this.PreviousAddButton.TabIndex = 263;
            this.PreviousAddButton.Text = "»";
            this.toolTip1.SetToolTip(this.PreviousAddButton, "Add name from Previous Names box to list.");
            this.PreviousAddButton.UseVisualStyleBackColor = true;
            this.PreviousAddButton.Click += new System.EventHandler(this.PreviousAddButton_Click);
            // 
            // PreviousRemoveButton
            // 
            this.PreviousRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PreviousRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousRemoveButton.Location = new System.Drawing.Point(421, 116);
            this.PreviousRemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.PreviousRemoveButton.Name = "PreviousRemoveButton";
            this.PreviousRemoveButton.Size = new System.Drawing.Size(26, 17);
            this.PreviousRemoveButton.TabIndex = 264;
            this.PreviousRemoveButton.Text = "«";
            this.toolTip1.SetToolTip(this.PreviousRemoveButton, "Remove highlighted name from list.");
            this.PreviousRemoveButton.UseVisualStyleBackColor = true;
            this.PreviousRemoveButton.Click += new System.EventHandler(this.PreviousRemoveButton_Click);
            // 
            // PreviousNamesList
            // 
            this.PreviousNamesList.FormattingEnabled = true;
            this.PreviousNamesList.Location = new System.Drawing.Point(466, 89);
            this.PreviousNamesList.Name = "PreviousNamesList";
            this.PreviousNamesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PreviousNamesList.Size = new System.Drawing.Size(97, 69);
            this.PreviousNamesList.TabIndex = 265;
            this.toolTip1.SetToolTip(this.PreviousNamesList, "List of previous names");
            // 
            // MdNLabel
            // 
            this.MdNLabel.AutoSize = true;
            this.MdNLabel.Location = new System.Drawing.Point(211, 89);
            this.MdNLabel.Name = "MdNLabel";
            this.MdNLabel.Size = new System.Drawing.Size(73, 13);
            this.MdNLabel.TabIndex = 26;
            this.MdNLabel.Text = "Maiden Name";
            // 
            // MaidenNameEntry
            // 
            this.MaidenNameEntry.Location = new System.Drawing.Point(298, 82);
            this.MaidenNameEntry.Name = "MaidenNameEntry";
            this.MaidenNameEntry.Size = new System.Drawing.Size(97, 20);
            this.MaidenNameEntry.TabIndex = 3;
            this.MaidenNameEntry.TextChanged += new System.EventHandler(this.MaidenNameEntry_TextChanged);
            this.MaidenNameEntry.MouseCaptureChanged += new System.EventHandler(this.MaidenNameEntry_MouseCaptureChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date of Birth";
            // 
            // DoDLabel
            // 
            this.DoDLabel.AutoSize = true;
            this.DoDLabel.Location = new System.Drawing.Point(321, 401);
            this.DoDLabel.Name = "DoDLabel";
            this.DoDLabel.Size = new System.Drawing.Size(74, 13);
            this.DoDLabel.TabIndex = 20;
            this.DoDLabel.Text = "Date of Death";
            // 
            // IsDeceased
            // 
            this.IsDeceased.AutoSize = true;
            this.IsDeceased.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsDeceased.Location = new System.Drawing.Point(320, 372);
            this.IsDeceased.Name = "IsDeceased";
            this.IsDeceased.Size = new System.Drawing.Size(75, 17);
            this.IsDeceased.TabIndex = 9;
            this.IsDeceased.Text = "Deceased";
            this.IsDeceased.UseVisualStyleBackColor = true;
            this.IsDeceased.Click += new System.EventHandler(this.IsDeceased_CheckedChanged);
            // 
            // DoBEntry
            // 
            this.DoBEntry.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoBEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoBEntry.Location = new System.Drawing.Point(46, 426);
            this.DoBEntry.Name = "DoBEntry";
            this.DoBEntry.ShowUpDown = true;
            this.DoBEntry.Size = new System.Drawing.Size(85, 20);
            this.DoBEntry.TabIndex = 8;
            this.DoBEntry.ValueChanged += new System.EventHandler(this.DoBEntry_ValueChanged);
            // 
            // DoDEntry
            // 
            this.DoDEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DoDEntry.Location = new System.Drawing.Point(324, 426);
            this.DoDEntry.Name = "DoDEntry";
            this.DoDEntry.ShowUpDown = true;
            this.DoDEntry.Size = new System.Drawing.Size(84, 20);
            this.DoDEntry.TabIndex = 10;
            this.DoDEntry.ValueChanged += new System.EventHandler(this.DoDEntry_ValueChanged);
            // 
            // ParentsEntryLabel
            // 
            this.ParentsEntryLabel.AutoSize = true;
            this.ParentsEntryLabel.Location = new System.Drawing.Point(45, 205);
            this.ParentsEntryLabel.Name = "ParentsEntryLabel";
            this.ParentsEntryLabel.Size = new System.Drawing.Size(49, 13);
            this.ParentsEntryLabel.TabIndex = 24;
            this.ParentsEntryLabel.Text = "Parent(s)";
            // 
            // ParentsEntry
            // 
            this.ParentsEntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParentsEntry.FormattingEnabled = true;
            this.ParentsEntry.Location = new System.Drawing.Point(108, 202);
            this.ParentsEntry.Name = "ParentsEntry";
            this.ParentsEntry.Size = new System.Drawing.Size(271, 21);
            this.ParentsEntry.TabIndex = 7;
            this.ParentsEntry.SelectedValueChanged += new System.EventHandler(this.ParentsEntry_SelectedValueChanged);
            // 
            // KidsEntryLabel
            // 
            this.KidsEntryLabel.AutoSize = true;
            this.KidsEntryLabel.Location = new System.Drawing.Point(45, 241);
            this.KidsEntryLabel.Name = "KidsEntryLabel";
            this.KidsEntryLabel.Size = new System.Drawing.Size(33, 13);
            this.KidsEntryLabel.TabIndex = 256;
            this.KidsEntryLabel.Text = "Kid(s)";
            // 
            // KidsEntry
            // 
            this.KidsEntry.FormattingEnabled = true;
            this.KidsEntry.Location = new System.Drawing.Point(108, 239);
            this.KidsEntry.Name = "KidsEntry";
            this.KidsEntry.Size = new System.Drawing.Size(198, 64);
            this.KidsEntry.TabIndex = 257;
            // 
            // NewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 547);
            this.Controls.Add(this.PreviousNamesList);
            this.Controls.Add(this.PreviousRemoveButton);
            this.Controls.Add(this.PreviousAddButton);
            this.Controls.Add(this.PreviousNamesEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpouseKidsDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KidsEntry);
            this.Controls.Add(this.KidsEntryLabel);
            this.Controls.Add(this.MaidenNameEntry);
            this.Controls.Add(this.MdNLabel);
            this.Controls.Add(this.ParentsEntry);
            this.Controls.Add(this.ParentsEntryLabel);
            this.Controls.Add(this.DoDEntry);
            this.Controls.Add(this.DoBEntry);
            this.Controls.Add(this.IsDeceased);
            this.Controls.Add(this.DoDLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MiddleNameEntry);
            this.Controls.Add(this.MNLabel);
            this.Controls.Add(this.SpouseEntry);
            this.Controls.Add(this.SpouseEntryLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RecordDisplay);
            this.Controls.Add(this.AddSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LNLabel);
            this.Controls.Add(this.LastNameEntry);
            this.Controls.Add(this.FNLabel);
            this.Controls.Add(this.AddCancel);
            this.Controls.Add(this.FirstNameEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewRecord";
            this.Text = "New Record";
            this.Load += new System.EventHandler(this.NewRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameEntry;
        private System.Windows.Forms.Button AddCancel;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.TextBox LastNameEntry;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton MaleButton;
        private System.Windows.Forms.RadioButton FemaleButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddSubmit;
        private System.Windows.Forms.TextBox RecordDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SpouseEntryLabel;
        private System.Windows.Forms.ComboBox SpouseEntry;
        private System.Windows.Forms.Label MNLabel;
        private System.Windows.Forms.TextBox MiddleNameEntry;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DoDLabel;
        private System.Windows.Forms.CheckBox IsDeceased;
        private System.Windows.Forms.DateTimePicker DoBEntry;
        private System.Windows.Forms.DateTimePicker DoDEntry;
        private System.Windows.Forms.Label ParentsEntryLabel;
        private System.Windows.Forms.ComboBox ParentsEntry;
        private System.Windows.Forms.Label MdNLabel;
        private System.Windows.Forms.TextBox MaidenNameEntry;
        private System.Windows.Forms.Label KidsEntryLabel;
        private System.Windows.Forms.CheckedListBox KidsEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SpouseKidsDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PreviousNamesEntry;
        private System.Windows.Forms.Button PreviousAddButton;
        private System.Windows.Forms.Button PreviousRemoveButton;
        private System.Windows.Forms.ListBox PreviousNamesList;
    }
}