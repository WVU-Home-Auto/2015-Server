namespace EngineTester
{
    partial class MotionDetectorTester
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
            this.DetectorOffButton = new System.Windows.Forms.RadioButton();
            this.DetectorOnButton = new System.Windows.Forms.RadioButton();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SubmitIDButton = new System.Windows.Forms.Button();
            this.SetStatusLabel = new System.Windows.Forms.Label();
            this.ApplyChangesLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.DetectorIDTextbox = new System.Windows.Forms.TextBox();
            this.DetectorInfoLabel = new System.Windows.Forms.Label();
            this.DetectorIDLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DetectorOffButton
            // 
            this.DetectorOffButton.AutoSize = true;
            this.DetectorOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectorOffButton.Location = new System.Drawing.Point(219, 247);
            this.DetectorOffButton.Name = "DetectorOffButton";
            this.DetectorOffButton.Size = new System.Drawing.Size(49, 24);
            this.DetectorOffButton.TabIndex = 27;
            this.DetectorOffButton.TabStop = true;
            this.DetectorOffButton.Text = "Off";
            this.DetectorOffButton.UseVisualStyleBackColor = true;
            // 
            // DetectorOnButton
            // 
            this.DetectorOnButton.AutoSize = true;
            this.DetectorOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectorOnButton.Location = new System.Drawing.Point(154, 247);
            this.DetectorOnButton.Name = "DetectorOnButton";
            this.DetectorOnButton.Size = new System.Drawing.Size(48, 24);
            this.DetectorOnButton.TabIndex = 26;
            this.DetectorOnButton.TabStop = true;
            this.DetectorOnButton.Text = "On";
            this.DetectorOnButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.Location = new System.Drawing.Point(154, 277);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(103, 26);
            this.ApplyButton.TabIndex = 25;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SubmitIDButton
            // 
            this.SubmitIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitIDButton.Location = new System.Drawing.Point(181, 49);
            this.SubmitIDButton.Name = "SubmitIDButton";
            this.SubmitIDButton.Size = new System.Drawing.Size(103, 26);
            this.SubmitIDButton.TabIndex = 24;
            this.SubmitIDButton.Text = "Submit";
            this.SubmitIDButton.UseVisualStyleBackColor = true;
            // 
            // SetStatusLabel
            // 
            this.SetStatusLabel.AutoSize = true;
            this.SetStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetStatusLabel.Location = new System.Drawing.Point(45, 249);
            this.SetStatusLabel.Name = "SetStatusLabel";
            this.SetStatusLabel.Size = new System.Drawing.Size(89, 20);
            this.SetStatusLabel.TabIndex = 22;
            this.SetStatusLabel.Text = "Set Status:";
            // 
            // ApplyChangesLabel
            // 
            this.ApplyChangesLabel.AutoSize = true;
            this.ApplyChangesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyChangesLabel.Location = new System.Drawing.Point(18, 215);
            this.ApplyChangesLabel.Name = "ApplyChangesLabel";
            this.ApplyChangesLabel.Size = new System.Drawing.Size(167, 25);
            this.ApplyChangesLabel.TabIndex = 20;
            this.ApplyChangesLabel.Text = "Apply Changes:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLabel.Location = new System.Drawing.Point(45, 152);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(137, 20);
            this.YLabel.TabIndex = 19;
            this.YLabel.Text = "Y-Coordinate: N/A";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(45, 127);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(137, 20);
            this.XLabel.TabIndex = 18;
            this.XLabel.Text = "X-Coordinate: N/A";
            // 
            // DetectorIDTextbox
            // 
            this.DetectorIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectorIDTextbox.Location = new System.Drawing.Point(23, 49);
            this.DetectorIDTextbox.Name = "DetectorIDTextbox";
            this.DetectorIDTextbox.Size = new System.Drawing.Size(152, 26);
            this.DetectorIDTextbox.TabIndex = 17;
            // 
            // DetectorInfoLabel
            // 
            this.DetectorInfoLabel.AutoSize = true;
            this.DetectorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectorInfoLabel.Location = new System.Drawing.Point(18, 93);
            this.DetectorInfoLabel.Name = "DetectorInfoLabel";
            this.DetectorInfoLabel.Size = new System.Drawing.Size(142, 25);
            this.DetectorInfoLabel.TabIndex = 16;
            this.DetectorInfoLabel.Text = "Detector Info:";
            // 
            // DetectorIDLabel
            // 
            this.DetectorIDLabel.AutoSize = true;
            this.DetectorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetectorIDLabel.Location = new System.Drawing.Point(18, 21);
            this.DetectorIDLabel.Name = "DetectorIDLabel";
            this.DetectorIDLabel.Size = new System.Drawing.Size(198, 25);
            this.DetectorIDLabel.TabIndex = 15;
            this.DetectorIDLabel.Text = "Motion Detector ID:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(45, 177);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(90, 20);
            this.StatusLabel.TabIndex = 29;
            this.StatusLabel.Text = "Status: N/A";
            // 
            // MotionDetectorTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 325);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DetectorOffButton);
            this.Controls.Add(this.DetectorOnButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SubmitIDButton);
            this.Controls.Add(this.SetStatusLabel);
            this.Controls.Add(this.ApplyChangesLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.DetectorIDTextbox);
            this.Controls.Add(this.DetectorInfoLabel);
            this.Controls.Add(this.DetectorIDLabel);
            this.Name = "MotionDetectorTester";
            this.Text = "MotionDetectorTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DetectorOffButton;
        private System.Windows.Forms.RadioButton DetectorOnButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button SubmitIDButton;
        private System.Windows.Forms.Label SetStatusLabel;
        private System.Windows.Forms.Label ApplyChangesLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox DetectorIDTextbox;
        private System.Windows.Forms.Label DetectorInfoLabel;
        private System.Windows.Forms.Label DetectorIDLabel;
        private System.Windows.Forms.Label StatusLabel;
    }
}