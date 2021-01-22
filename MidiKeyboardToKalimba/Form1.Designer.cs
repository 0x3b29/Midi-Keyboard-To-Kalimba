namespace PlayKalimbaWithKeyboard
{
    partial class Form1
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbMidiDevices = new System.Windows.Forms.ComboBox();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnConnectMidi = new System.Windows.Forms.Button();
            this.btnConnectSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbMidiDevices
            // 
            this.cbMidiDevices.FormattingEnabled = true;
            this.cbMidiDevices.Location = new System.Drawing.Point(12, 51);
            this.cbMidiDevices.Name = "cbMidiDevices";
            this.cbMidiDevices.Size = new System.Drawing.Size(297, 28);
            this.cbMidiDevices.TabIndex = 1;
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(315, 51);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(161, 28);
            this.cbSerialPorts.TabIndex = 2;
            // 
            // btnConnectMidi
            // 
            this.btnConnectMidi.Location = new System.Drawing.Point(12, 85);
            this.btnConnectMidi.Name = "btnConnectMidi";
            this.btnConnectMidi.Size = new System.Drawing.Size(297, 32);
            this.btnConnectMidi.TabIndex = 3;
            this.btnConnectMidi.Text = "Connect";
            this.btnConnectMidi.UseVisualStyleBackColor = true;
            this.btnConnectMidi.Click += new System.EventHandler(this.btnConnectMidi_Click);
            // 
            // btnConnectSerial
            // 
            this.btnConnectSerial.Location = new System.Drawing.Point(315, 85);
            this.btnConnectSerial.Name = "btnConnectSerial";
            this.btnConnectSerial.Size = new System.Drawing.Size(161, 32);
            this.btnConnectSerial.TabIndex = 4;
            this.btnConnectSerial.Text = "Connect";
            this.btnConnectSerial.UseVisualStyleBackColor = true;
            this.btnConnectSerial.Click += new System.EventHandler(this.btnConnectSerial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 191);
            this.Controls.Add(this.btnConnectSerial);
            this.Controls.Add(this.btnConnectMidi);
            this.Controls.Add(this.cbSerialPorts);
            this.Controls.Add(this.cbMidiDevices);
            this.Controls.Add(this.btnRefresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbMidiDevices;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Button btnConnectMidi;
        private System.Windows.Forms.Button btnConnectSerial;
    }
}

