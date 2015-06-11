namespace EngineTester
{
    partial class TemperatureTester
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
            this.CurrentTemperatureLabel = new System.Windows.Forms.Label();
            this.SetTemperatureLabel = new System.Windows.Forms.Label();
            this.SetTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SensorIDLabel = new System.Windows.Forms.Label();
            this.SensorIDTextbox = new System.Windows.Forms.TextBox();
            this.SubmitIDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentTemperatureLabel
            // 
            this.CurrentTemperatureLabel.AutoSize = true;
            this.CurrentTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTemperatureLabel.Location = new System.Drawing.Point(21, 90);
            this.CurrentTemperatureLabel.Name = "CurrentTemperatureLabel";
            this.CurrentTemperatureLabel.Size = new System.Drawing.Size(191, 20);
            this.CurrentTemperatureLabel.TabIndex = 0;
            this.CurrentTemperatureLabel.Text = "Current Temperature: N/A";
            // 
            // SetTemperatureLabel
            // 
            this.SetTemperatureLabel.AutoSize = true;
            this.SetTemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTemperatureLabel.Location = new System.Drawing.Point(21, 134);
            this.SetTemperatureLabel.Name = "SetTemperatureLabel";
            this.SetTemperatureLabel.Size = new System.Drawing.Size(137, 20);
            this.SetTemperatureLabel.TabIndex = 1;
            this.SetTemperatureLabel.Text = "Set Temperature: ";
            // 
            // SetTemperatureTextbox
            // 
            this.SetTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTemperatureTextbox.Location = new System.Drawing.Point(164, 131);
            this.SetTemperatureTextbox.Name = "SetTemperatureTextbox";
            this.SetTemperatureTextbox.Size = new System.Drawing.Size(100, 26);
            this.SetTemperatureTextbox.TabIndex = 2;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.Location = new System.Drawing.Point(164, 163);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(100, 26);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SensorIDLabel
            // 
            this.SensorIDLabel.AutoSize = true;
            this.SensorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorIDLabel.Location = new System.Drawing.Point(21, 23);
            this.SensorIDLabel.Name = "SensorIDLabel";
            this.SensorIDLabel.Size = new System.Drawing.Size(180, 20);
            this.SensorIDLabel.TabIndex = 4;
            this.SensorIDLabel.Text = "Temperature Sensor ID:";
            // 
            // SensorIDTextbox
            // 
            this.SensorIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SensorIDTextbox.Location = new System.Drawing.Point(25, 46);
            this.SensorIDTextbox.Name = "SensorIDTextbox";
            this.SensorIDTextbox.Size = new System.Drawing.Size(100, 26);
            this.SensorIDTextbox.TabIndex = 5;
            // 
            // SubmitIDButton
            // 
            this.SubmitIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitIDButton.Location = new System.Drawing.Point(131, 46);
            this.SubmitIDButton.Name = "SubmitIDButton";
            this.SubmitIDButton.Size = new System.Drawing.Size(100, 26);
            this.SubmitIDButton.TabIndex = 6;
            this.SubmitIDButton.Text = "Submit";
            this.SubmitIDButton.UseVisualStyleBackColor = true;
            this.SubmitIDButton.Click += new System.EventHandler(this.SubmitIDButton_Click);
            // 
            // TemperatureTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 216);
            this.Controls.Add(this.SubmitIDButton);
            this.Controls.Add(this.SensorIDTextbox);
            this.Controls.Add(this.SensorIDLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SetTemperatureTextbox);
            this.Controls.Add(this.SetTemperatureLabel);
            this.Controls.Add(this.CurrentTemperatureLabel);
            this.Name = "TemperatureTester";
            this.Text = "TemperatureTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTemperatureLabel;
        private System.Windows.Forms.Label SetTemperatureLabel;
        private System.Windows.Forms.TextBox SetTemperatureTextbox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label SensorIDLabel;
        private System.Windows.Forms.TextBox SensorIDTextbox;
        private System.Windows.Forms.Button SubmitIDButton;
    }
}