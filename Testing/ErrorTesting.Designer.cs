namespace FTC
{
    partial class ErrorTesting
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
            this.ErrorBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(78, 56);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.Size = new System.Drawing.Size(211, 33);
            this.ErrorBox.TabIndex = 5;
            this.ErrorBox.Text = "";
            // 
            // ErrorTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 172);
            this.Controls.Add(this.ErrorBox);
            this.Name = "ErrorTesting";
            this.Text = "ErrorTesting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ErrorBox;
    }
}