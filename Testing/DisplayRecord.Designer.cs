namespace FTC
{
    /// <summary>
    /// This form displays detailed information on the record chosen from the combobox.
    /// </summary>
    partial class DisplayRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseDisplay = new System.Windows.Forms.ComboBox();
            this.RetName = new System.Windows.Forms.TextBox();
            this.RetGender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RetDoB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RetDoD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RetSpouse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RetMother = new System.Windows.Forms.TextBox();
            this.RetFather = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ChildrenNamesBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RetClose = new System.Windows.Forms.Button();
            this.SiblingsNamesBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RetSpouseNum = new System.Windows.Forms.TextBox();
            this.RetMotherNum = new System.Windows.Forms.TextBox();
            this.RetFatherNum = new System.Windows.Forms.TextBox();
            this.SiblingsNumberBox = new System.Windows.Forms.TextBox();
            this.ChildrenNumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Record";
            // 
            // ChooseDisplay
            // 
            this.ChooseDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseDisplay.FormattingEnabled = true;
            this.ChooseDisplay.Location = new System.Drawing.Point(12, 40);
            this.ChooseDisplay.Name = "ChooseDisplay";
            this.ChooseDisplay.Size = new System.Drawing.Size(121, 21);
            this.ChooseDisplay.TabIndex = 1;
            this.ChooseDisplay.DropDownClosed += new System.EventHandler(this.ChooseDisplay_DropDownClosed);
            // 
            // RetName
            // 
            this.RetName.Location = new System.Drawing.Point(236, 40);
            this.RetName.Name = "RetName";
            this.RetName.ReadOnly = true;
            this.RetName.Size = new System.Drawing.Size(310, 20);
            this.RetName.TabIndex = 2;
            // 
            // RetGender
            // 
            this.RetGender.Location = new System.Drawing.Point(236, 73);
            this.RetGender.Name = "RetGender";
            this.RetGender.ReadOnly = true;
            this.RetGender.Size = new System.Drawing.Size(68, 20);
            this.RetGender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Birth";
            // 
            // RetDoB
            // 
            this.RetDoB.Location = new System.Drawing.Point(382, 77);
            this.RetDoB.Name = "RetDoB";
            this.RetDoB.ReadOnly = true;
            this.RetDoB.Size = new System.Drawing.Size(164, 20);
            this.RetDoB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date of Death";
            // 
            // RetDoD
            // 
            this.RetDoD.Location = new System.Drawing.Point(382, 103);
            this.RetDoD.Name = "RetDoD";
            this.RetDoD.ReadOnly = true;
            this.RetDoD.Size = new System.Drawing.Size(164, 20);
            this.RetDoD.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Spouse";
            // 
            // RetSpouse
            // 
            this.RetSpouse.Location = new System.Drawing.Point(236, 129);
            this.RetSpouse.Name = "RetSpouse";
            this.RetSpouse.ReadOnly = true;
            this.RetSpouse.Size = new System.Drawing.Size(218, 20);
            this.RetSpouse.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parents";
            // 
            // RetMother
            // 
            this.RetMother.Location = new System.Drawing.Point(236, 185);
            this.RetMother.Name = "RetMother";
            this.RetMother.ReadOnly = true;
            this.RetMother.Size = new System.Drawing.Size(218, 20);
            this.RetMother.TabIndex = 14;
            // 
            // RetFather
            // 
            this.RetFather.Location = new System.Drawing.Point(236, 159);
            this.RetFather.Name = "RetFather";
            this.RetFather.ReadOnly = true;
            this.RetFather.Size = new System.Drawing.Size(218, 20);
            this.RetFather.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Siblings";
            // 
            // ChildrenNamesBox
            // 
            this.ChildrenNamesBox.Location = new System.Drawing.Point(236, 316);
            this.ChildrenNamesBox.Multiline = true;
            this.ChildrenNamesBox.Name = "ChildrenNamesBox";
            this.ChildrenNamesBox.ReadOnly = true;
            this.ChildrenNamesBox.Size = new System.Drawing.Size(218, 99);
            this.ChildrenNamesBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Children";
            // 
            // RetClose
            // 
            this.RetClose.Location = new System.Drawing.Point(441, 472);
            this.RetClose.Name = "RetClose";
            this.RetClose.Size = new System.Drawing.Size(104, 25);
            this.RetClose.TabIndex = 20;
            this.RetClose.Text = "Return to Menu";
            this.RetClose.UseVisualStyleBackColor = true;
            this.RetClose.Click += new System.EventHandler(this.RetClose_Click);
            // 
            // SiblingsNamesBox
            // 
            this.SiblingsNamesBox.Location = new System.Drawing.Point(236, 211);
            this.SiblingsNamesBox.Multiline = true;
            this.SiblingsNamesBox.Name = "SiblingsNamesBox";
            this.SiblingsNamesBox.ReadOnly = true;
            this.SiblingsNamesBox.Size = new System.Drawing.Size(218, 99);
            this.SiblingsNamesBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 20);
            this.button1.TabIndex = 22;
            this.button1.Text = "Modify Record";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RetSpouseNum
            // 
            this.RetSpouseNum.Location = new System.Drawing.Point(460, 129);
            this.RetSpouseNum.Name = "RetSpouseNum";
            this.RetSpouseNum.ReadOnly = true;
            this.RetSpouseNum.Size = new System.Drawing.Size(86, 20);
            this.RetSpouseNum.TabIndex = 23;
            // 
            // RetMotherNum
            // 
            this.RetMotherNum.Location = new System.Drawing.Point(459, 185);
            this.RetMotherNum.Name = "RetMotherNum";
            this.RetMotherNum.ReadOnly = true;
            this.RetMotherNum.Size = new System.Drawing.Size(86, 20);
            this.RetMotherNum.TabIndex = 24;
            // 
            // RetFatherNum
            // 
            this.RetFatherNum.Location = new System.Drawing.Point(460, 159);
            this.RetFatherNum.Name = "RetFatherNum";
            this.RetFatherNum.ReadOnly = true;
            this.RetFatherNum.Size = new System.Drawing.Size(86, 20);
            this.RetFatherNum.TabIndex = 25;
            // 
            // SiblingsNumberBox
            // 
            this.SiblingsNumberBox.Location = new System.Drawing.Point(459, 211);
            this.SiblingsNumberBox.Multiline = true;
            this.SiblingsNumberBox.Name = "SiblingsNumberBox";
            this.SiblingsNumberBox.ReadOnly = true;
            this.SiblingsNumberBox.Size = new System.Drawing.Size(87, 99);
            this.SiblingsNumberBox.TabIndex = 26;
            // 
            // ChildrenNumberBox
            // 
            this.ChildrenNumberBox.Location = new System.Drawing.Point(460, 316);
            this.ChildrenNumberBox.Multiline = true;
            this.ChildrenNumberBox.Name = "ChildrenNumberBox";
            this.ChildrenNumberBox.ReadOnly = true;
            this.ChildrenNumberBox.Size = new System.Drawing.Size(87, 99);
            this.ChildrenNumberBox.TabIndex = 27;
            // 
            // DisplayRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 547);
            this.Controls.Add(this.ChildrenNumberBox);
            this.Controls.Add(this.SiblingsNumberBox);
            this.Controls.Add(this.RetFatherNum);
            this.Controls.Add(this.RetMotherNum);
            this.Controls.Add(this.RetSpouseNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SiblingsNamesBox);
            this.Controls.Add(this.RetClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChildrenNamesBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RetFather);
            this.Controls.Add(this.RetMother);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RetSpouse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RetDoD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RetDoB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetGender);
            this.Controls.Add(this.RetName);
            this.Controls.Add(this.ChooseDisplay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayRecord";
            this.Text = "DisplayRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseDisplay;
        private System.Windows.Forms.TextBox RetName;
        private System.Windows.Forms.TextBox RetGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RetDoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RetDoD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RetSpouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RetMother;
        private System.Windows.Forms.TextBox RetFather;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ChildrenNamesBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RetClose;
        private System.Windows.Forms.TextBox SiblingsNamesBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RetSpouseNum;
        private System.Windows.Forms.TextBox RetMotherNum;
        private System.Windows.Forms.TextBox RetFatherNum;
        private System.Windows.Forms.TextBox SiblingsNumberBox;
        private System.Windows.Forms.TextBox ChildrenNumberBox;
    }
}