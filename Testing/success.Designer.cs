namespace FTC
{
    /// <summary>
    /// A simple form to indicate a successful record add attempt.
    /// </summary>
    partial class Success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptSuccess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record Added";
            // 
            // AcceptSuccess
            // 
            this.AcceptSuccess.Location = new System.Drawing.Point(51, 46);
            this.AcceptSuccess.Name = "AcceptSuccess";
            this.AcceptSuccess.Size = new System.Drawing.Size(94, 25);
            this.AcceptSuccess.TabIndex = 1;
            this.AcceptSuccess.Text = "Ok";
            this.AcceptSuccess.UseVisualStyleBackColor = true;
            this.AcceptSuccess.Click += new System.EventHandler(this.AcceptSuccess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FTC.Properties.Resources.success;
            this.pictureBox1.Image = global::FTC.Properties.Resources.success;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 5);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 83);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AcceptSuccess);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Success";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Success";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AcceptSuccess;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}