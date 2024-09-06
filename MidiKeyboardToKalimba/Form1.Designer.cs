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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbMidiDevices = new System.Windows.Forms.ComboBox();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.btnConnectMidi = new System.Windows.Forms.Button();
            this.btnConnectSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnectMidi = new System.Windows.Forms.Button();
            this.btnDisconnectSerial = new System.Windows.Forms.Button();
            this.btnDisconnectSerial2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnectSerial2 = new System.Windows.Forms.Button();
            this.cbSerialPorts2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 313);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(480, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbMidiDevices
            // 
            this.cbMidiDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMidiDevices.FormattingEnabled = true;
            this.cbMidiDevices.Location = new System.Drawing.Point(12, 56);
            this.cbMidiDevices.Name = "cbMidiDevices";
            this.cbMidiDevices.Size = new System.Drawing.Size(240, 28);
            this.cbMidiDevices.TabIndex = 1;
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(12, 154);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(240, 28);
            this.cbSerialPorts.TabIndex = 2;
            // 
            // btnConnectMidi
            // 
            this.btnConnectMidi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectMidi.Location = new System.Drawing.Point(258, 54);
            this.btnConnectMidi.Name = "btnConnectMidi";
            this.btnConnectMidi.Size = new System.Drawing.Size(114, 32);
            this.btnConnectMidi.TabIndex = 3;
            this.btnConnectMidi.Text = "Connect";
            this.btnConnectMidi.UseVisualStyleBackColor = true;
            this.btnConnectMidi.Click += new System.EventHandler(this.btnConnectMidi_Click);
            // 
            // btnConnectSerial
            // 
            this.btnConnectSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectSerial.Location = new System.Drawing.Point(258, 152);
            this.btnConnectSerial.Name = "btnConnectSerial";
            this.btnConnectSerial.Size = new System.Drawing.Size(114, 32);
            this.btnConnectSerial.TabIndex = 4;
            this.btnConnectSerial.Text = "Connect";
            this.btnConnectSerial.UseVisualStyleBackColor = true;
            this.btnConnectSerial.Click += new System.EventHandler(this.btnConnectSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Midi Input Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port for the major scale Kalimba Bot";
            // 
            // btnDisconnectMidi
            // 
            this.btnDisconnectMidi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectMidi.Location = new System.Drawing.Point(378, 54);
            this.btnDisconnectMidi.Name = "btnDisconnectMidi";
            this.btnDisconnectMidi.Size = new System.Drawing.Size(114, 32);
            this.btnDisconnectMidi.TabIndex = 7;
            this.btnDisconnectMidi.Text = "Disconnect";
            this.btnDisconnectMidi.UseVisualStyleBackColor = true;
            this.btnDisconnectMidi.Click += new System.EventHandler(this.btnDisconnectMidi_Click);
            // 
            // btnDisconnectSerial
            // 
            this.btnDisconnectSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectSerial.Location = new System.Drawing.Point(378, 152);
            this.btnDisconnectSerial.Name = "btnDisconnectSerial";
            this.btnDisconnectSerial.Size = new System.Drawing.Size(114, 32);
            this.btnDisconnectSerial.TabIndex = 8;
            this.btnDisconnectSerial.Text = "Disconnect";
            this.btnDisconnectSerial.UseVisualStyleBackColor = true;
            this.btnDisconnectSerial.Click += new System.EventHandler(this.btnDisconnectSerial_Click);
            // 
            // btnDisconnectSerial2
            // 
            this.btnDisconnectSerial2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectSerial2.Location = new System.Drawing.Point(376, 252);
            this.btnDisconnectSerial2.Name = "btnDisconnectSerial2";
            this.btnDisconnectSerial2.Size = new System.Drawing.Size(114, 32);
            this.btnDisconnectSerial2.TabIndex = 12;
            this.btnDisconnectSerial2.Text = "Disconnect";
            this.btnDisconnectSerial2.UseVisualStyleBackColor = true;
            this.btnDisconnectSerial2.Click += new System.EventHandler(this.btnDisconnectSerial2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(606, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port for the non-diatonic Kalimba Bot";
            // 
            // btnConnectSerial2
            // 
            this.btnConnectSerial2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectSerial2.Location = new System.Drawing.Point(256, 252);
            this.btnConnectSerial2.Name = "btnConnectSerial2";
            this.btnConnectSerial2.Size = new System.Drawing.Size(114, 32);
            this.btnConnectSerial2.TabIndex = 10;
            this.btnConnectSerial2.Text = "Connect";
            this.btnConnectSerial2.UseVisualStyleBackColor = true;
            this.btnConnectSerial2.Click += new System.EventHandler(this.btnConnectSerial2_Click);
            // 
            // cbSerialPorts2
            // 
            this.cbSerialPorts2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialPorts2.FormattingEnabled = true;
            this.cbSerialPorts2.Location = new System.Drawing.Point(10, 254);
            this.cbSerialPorts2.Name = "cbSerialPorts2";
            this.cbSerialPorts2.Size = new System.Drawing.Size(240, 28);
            this.cbSerialPorts2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 358);
            this.Controls.Add(this.btnDisconnectSerial2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnectSerial2);
            this.Controls.Add(this.cbSerialPorts2);
            this.Controls.Add(this.btnDisconnectSerial);
            this.Controls.Add(this.btnDisconnectMidi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnectSerial);
            this.Controls.Add(this.btnConnectMidi);
            this.Controls.Add(this.cbSerialPorts);
            this.Controls.Add(this.cbMidiDevices);
            this.Controls.Add(this.btnRefresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Midi Device To Kalimba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbMidiDevices;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Button btnConnectMidi;
        private System.Windows.Forms.Button btnConnectSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnectMidi;
        private System.Windows.Forms.Button btnDisconnectSerial;
        private System.Windows.Forms.Button btnDisconnectSerial2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnectSerial2;
        private System.Windows.Forms.ComboBox cbSerialPorts2;
    }
}

