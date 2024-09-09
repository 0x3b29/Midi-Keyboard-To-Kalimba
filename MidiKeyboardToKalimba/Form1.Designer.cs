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
            this.btnMajorScaleUp = new System.Windows.Forms.Button();
            this.btnMajorScaleCenter = new System.Windows.Forms.Button();
            this.btnMajorScaleDown = new System.Windows.Forms.Button();
            this.btnNonDiatonicDown = new System.Windows.Forms.Button();
            this.btnNonDiatonicCenter = new System.Windows.Forms.Button();
            this.btnNonDiatonicUp = new System.Windows.Forms.Button();
            this.btnMajorScaleStairs = new System.Windows.Forms.Button();
            this.btnNonDiatonicStairs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMajorScaleNotesPerfect = new System.Windows.Forms.Label();
            this.lblMajorScaleNotesWrapped = new System.Windows.Forms.Label();
            this.lblMajorScaleNotesPlayed = new System.Windows.Forms.Label();
            this.lblNonDiatonicNotesPerfect = new System.Windows.Forms.Label();
            this.lblNonDiatonicNotesWrapped = new System.Windows.Forms.Label();
            this.lblNonDiatonicNotesPlayed = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxWrapNotes = new System.Windows.Forms.CheckBox();
            this.lblMajorScaleNotesIgnored = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblNonDiatonicNotesIgnored = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(11, 337);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(310, 21);
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
            this.cbMidiDevices.Location = new System.Drawing.Point(12, 37);
            this.cbMidiDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMidiDevices.Name = "cbMidiDevices";
            this.cbMidiDevices.Size = new System.Drawing.Size(151, 21);
            this.cbMidiDevices.TabIndex = 1;
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(12, 114);
            this.cbSerialPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(151, 21);
            this.cbSerialPorts.TabIndex = 2;
            // 
            // btnConnectMidi
            // 
            this.btnConnectMidi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectMidi.Location = new System.Drawing.Point(167, 37);
            this.btnConnectMidi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnectMidi.Name = "btnConnectMidi";
            this.btnConnectMidi.Size = new System.Drawing.Size(76, 21);
            this.btnConnectMidi.TabIndex = 3;
            this.btnConnectMidi.Text = "Connect";
            this.btnConnectMidi.UseVisualStyleBackColor = true;
            this.btnConnectMidi.Click += new System.EventHandler(this.btnConnectMidi_Click);
            // 
            // btnConnectSerial
            // 
            this.btnConnectSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectSerial.Location = new System.Drawing.Point(167, 114);
            this.btnConnectSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnectSerial.Name = "btnConnectSerial";
            this.btnConnectSerial.Size = new System.Drawing.Size(76, 21);
            this.btnConnectSerial.TabIndex = 4;
            this.btnConnectSerial.Text = "Connect";
            this.btnConnectSerial.UseVisualStyleBackColor = true;
            this.btnConnectSerial.Click += new System.EventHandler(this.btnConnectSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Midi Input Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Major scale Kalimba Bot";
            // 
            // btnDisconnectMidi
            // 
            this.btnDisconnectMidi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectMidi.Location = new System.Drawing.Point(247, 37);
            this.btnDisconnectMidi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnectMidi.Name = "btnDisconnectMidi";
            this.btnDisconnectMidi.Size = new System.Drawing.Size(76, 21);
            this.btnDisconnectMidi.TabIndex = 7;
            this.btnDisconnectMidi.Text = "Disconnect";
            this.btnDisconnectMidi.UseVisualStyleBackColor = true;
            this.btnDisconnectMidi.Click += new System.EventHandler(this.btnDisconnectMidi_Click);
            // 
            // btnDisconnectSerial
            // 
            this.btnDisconnectSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectSerial.Location = new System.Drawing.Point(247, 114);
            this.btnDisconnectSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnectSerial.Name = "btnDisconnectSerial";
            this.btnDisconnectSerial.Size = new System.Drawing.Size(76, 21);
            this.btnDisconnectSerial.TabIndex = 8;
            this.btnDisconnectSerial.Text = "Disconnect";
            this.btnDisconnectSerial.UseVisualStyleBackColor = true;
            this.btnDisconnectSerial.Click += new System.EventHandler(this.btnDisconnectSerial_Click);
            // 
            // btnDisconnectSerial2
            // 
            this.btnDisconnectSerial2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconnectSerial2.Location = new System.Drawing.Point(245, 241);
            this.btnDisconnectSerial2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnectSerial2.Name = "btnDisconnectSerial2";
            this.btnDisconnectSerial2.Size = new System.Drawing.Size(76, 21);
            this.btnDisconnectSerial2.TabIndex = 12;
            this.btnDisconnectSerial2.Text = "Disconnect";
            this.btnDisconnectSerial2.UseVisualStyleBackColor = true;
            this.btnDisconnectSerial2.Click += new System.EventHandler(this.btnDisconnectSerial2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Non-diatonic Kalimba Bot";
            // 
            // btnConnectSerial2
            // 
            this.btnConnectSerial2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnectSerial2.Location = new System.Drawing.Point(165, 241);
            this.btnConnectSerial2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnectSerial2.Name = "btnConnectSerial2";
            this.btnConnectSerial2.Size = new System.Drawing.Size(76, 21);
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
            this.cbSerialPorts2.Location = new System.Drawing.Point(12, 242);
            this.cbSerialPorts2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSerialPorts2.Name = "cbSerialPorts2";
            this.cbSerialPorts2.Size = new System.Drawing.Size(149, 21);
            this.cbSerialPorts2.TabIndex = 9;
            // 
            // btnMajorScaleUp
            // 
            this.btnMajorScaleUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMajorScaleUp.Location = new System.Drawing.Point(224, 89);
            this.btnMajorScaleUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMajorScaleUp.Name = "btnMajorScaleUp";
            this.btnMajorScaleUp.Size = new System.Drawing.Size(21, 21);
            this.btnMajorScaleUp.TabIndex = 13;
            this.btnMajorScaleUp.Text = "↑";
            this.btnMajorScaleUp.UseVisualStyleBackColor = true;
            this.btnMajorScaleUp.Click += new System.EventHandler(this.btnMajorScaleUp_Click);
            // 
            // btnMajorScaleCenter
            // 
            this.btnMajorScaleCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMajorScaleCenter.Location = new System.Drawing.Point(249, 89);
            this.btnMajorScaleCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMajorScaleCenter.Name = "btnMajorScaleCenter";
            this.btnMajorScaleCenter.Size = new System.Drawing.Size(21, 21);
            this.btnMajorScaleCenter.TabIndex = 14;
            this.btnMajorScaleCenter.Text = "-";
            this.btnMajorScaleCenter.UseVisualStyleBackColor = true;
            this.btnMajorScaleCenter.Click += new System.EventHandler(this.btnMajorScaleCenter_Click);
            // 
            // btnMajorScaleDown
            // 
            this.btnMajorScaleDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMajorScaleDown.Location = new System.Drawing.Point(275, 89);
            this.btnMajorScaleDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMajorScaleDown.Name = "btnMajorScaleDown";
            this.btnMajorScaleDown.Size = new System.Drawing.Size(21, 21);
            this.btnMajorScaleDown.TabIndex = 15;
            this.btnMajorScaleDown.Text = "↓";
            this.btnMajorScaleDown.UseVisualStyleBackColor = true;
            this.btnMajorScaleDown.Click += new System.EventHandler(this.btnMajorScaleDown_Click);
            // 
            // btnNonDiatonicDown
            // 
            this.btnNonDiatonicDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNonDiatonicDown.Location = new System.Drawing.Point(275, 216);
            this.btnNonDiatonicDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNonDiatonicDown.Name = "btnNonDiatonicDown";
            this.btnNonDiatonicDown.Size = new System.Drawing.Size(21, 21);
            this.btnNonDiatonicDown.TabIndex = 18;
            this.btnNonDiatonicDown.Text = "↓";
            this.btnNonDiatonicDown.UseVisualStyleBackColor = true;
            this.btnNonDiatonicDown.Click += new System.EventHandler(this.btnNonDiatonicDown_Click);
            // 
            // btnNonDiatonicCenter
            // 
            this.btnNonDiatonicCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNonDiatonicCenter.Location = new System.Drawing.Point(249, 216);
            this.btnNonDiatonicCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNonDiatonicCenter.Name = "btnNonDiatonicCenter";
            this.btnNonDiatonicCenter.Size = new System.Drawing.Size(21, 21);
            this.btnNonDiatonicCenter.TabIndex = 17;
            this.btnNonDiatonicCenter.Text = "-";
            this.btnNonDiatonicCenter.UseVisualStyleBackColor = true;
            this.btnNonDiatonicCenter.Click += new System.EventHandler(this.btnNonDiatonicCenter_Click);
            // 
            // btnNonDiatonicUp
            // 
            this.btnNonDiatonicUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNonDiatonicUp.Location = new System.Drawing.Point(224, 216);
            this.btnNonDiatonicUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNonDiatonicUp.Name = "btnNonDiatonicUp";
            this.btnNonDiatonicUp.Size = new System.Drawing.Size(21, 21);
            this.btnNonDiatonicUp.TabIndex = 16;
            this.btnNonDiatonicUp.Text = "↑";
            this.btnNonDiatonicUp.UseVisualStyleBackColor = true;
            this.btnNonDiatonicUp.Click += new System.EventHandler(this.btnNonDiatonicUp_Click);
            // 
            // btnMajorScaleStairs
            // 
            this.btnMajorScaleStairs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMajorScaleStairs.Location = new System.Drawing.Point(300, 89);
            this.btnMajorScaleStairs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMajorScaleStairs.Name = "btnMajorScaleStairs";
            this.btnMajorScaleStairs.Size = new System.Drawing.Size(21, 21);
            this.btnMajorScaleStairs.TabIndex = 19;
            this.btnMajorScaleStairs.Text = "S";
            this.btnMajorScaleStairs.UseVisualStyleBackColor = true;
            this.btnMajorScaleStairs.Click += new System.EventHandler(this.btnMajorScaleStairs_Click);
            // 
            // btnNonDiatonicStairs
            // 
            this.btnNonDiatonicStairs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNonDiatonicStairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonDiatonicStairs.Location = new System.Drawing.Point(300, 216);
            this.btnNonDiatonicStairs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNonDiatonicStairs.Name = "btnNonDiatonicStairs";
            this.btnNonDiatonicStairs.Size = new System.Drawing.Size(21, 21);
            this.btnNonDiatonicStairs.TabIndex = 20;
            this.btnNonDiatonicStairs.Text = "S";
            this.btnNonDiatonicStairs.UseVisualStyleBackColor = true;
            this.btnNonDiatonicStairs.Click += new System.EventHandler(this.btnNonDiatonicStairs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Notes Played:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Wrapped Notes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Perfect Notes:";
            // 
            // lblMajorScaleNotesPerfect
            // 
            this.lblMajorScaleNotesPerfect.AutoSize = true;
            this.lblMajorScaleNotesPerfect.Location = new System.Drawing.Point(125, 167);
            this.lblMajorScaleNotesPerfect.Name = "lblMajorScaleNotesPerfect";
            this.lblMajorScaleNotesPerfect.Size = new System.Drawing.Size(13, 13);
            this.lblMajorScaleNotesPerfect.TabIndex = 26;
            this.lblMajorScaleNotesPerfect.Text = "0";
            this.lblMajorScaleNotesPerfect.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMajorScaleNotesWrapped
            // 
            this.lblMajorScaleNotesWrapped.AutoSize = true;
            this.lblMajorScaleNotesWrapped.Location = new System.Drawing.Point(308, 147);
            this.lblMajorScaleNotesWrapped.Name = "lblMajorScaleNotesWrapped";
            this.lblMajorScaleNotesWrapped.Size = new System.Drawing.Size(13, 13);
            this.lblMajorScaleNotesWrapped.TabIndex = 25;
            this.lblMajorScaleNotesWrapped.Text = "0";
            this.lblMajorScaleNotesWrapped.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMajorScaleNotesPlayed
            // 
            this.lblMajorScaleNotesPlayed.AutoSize = true;
            this.lblMajorScaleNotesPlayed.Location = new System.Drawing.Point(125, 147);
            this.lblMajorScaleNotesPlayed.Name = "lblMajorScaleNotesPlayed";
            this.lblMajorScaleNotesPlayed.Size = new System.Drawing.Size(13, 13);
            this.lblMajorScaleNotesPlayed.TabIndex = 24;
            this.lblMajorScaleNotesPlayed.Text = "0";
            this.lblMajorScaleNotesPlayed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNonDiatonicNotesPerfect
            // 
            this.lblNonDiatonicNotesPerfect.AutoSize = true;
            this.lblNonDiatonicNotesPerfect.Location = new System.Drawing.Point(128, 294);
            this.lblNonDiatonicNotesPerfect.Name = "lblNonDiatonicNotesPerfect";
            this.lblNonDiatonicNotesPerfect.Size = new System.Drawing.Size(13, 13);
            this.lblNonDiatonicNotesPerfect.TabIndex = 32;
            this.lblNonDiatonicNotesPerfect.Text = "0";
            this.lblNonDiatonicNotesPerfect.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNonDiatonicNotesWrapped
            // 
            this.lblNonDiatonicNotesWrapped.AutoSize = true;
            this.lblNonDiatonicNotesWrapped.Location = new System.Drawing.Point(308, 274);
            this.lblNonDiatonicNotesWrapped.Name = "lblNonDiatonicNotesWrapped";
            this.lblNonDiatonicNotesWrapped.Size = new System.Drawing.Size(13, 13);
            this.lblNonDiatonicNotesWrapped.TabIndex = 31;
            this.lblNonDiatonicNotesWrapped.Text = "0";
            this.lblNonDiatonicNotesWrapped.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNonDiatonicNotesPlayed
            // 
            this.lblNonDiatonicNotesPlayed.AutoSize = true;
            this.lblNonDiatonicNotesPlayed.Location = new System.Drawing.Point(128, 274);
            this.lblNonDiatonicNotesPlayed.Name = "lblNonDiatonicNotesPlayed";
            this.lblNonDiatonicNotesPlayed.Size = new System.Drawing.Size(13, 13);
            this.lblNonDiatonicNotesPlayed.TabIndex = 30;
            this.lblNonDiatonicNotesPlayed.Text = "0";
            this.lblNonDiatonicNotesPlayed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Perfect Notes:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(191, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Wrapped Notes:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Notes Played:";
            // 
            // cbxWrapNotes
            // 
            this.cbxWrapNotes.AutoSize = true;
            this.cbxWrapNotes.Checked = true;
            this.cbxWrapNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWrapNotes.Location = new System.Drawing.Point(240, 10);
            this.cbxWrapNotes.Name = "cbxWrapNotes";
            this.cbxWrapNotes.Size = new System.Drawing.Size(83, 17);
            this.cbxWrapNotes.TabIndex = 33;
            this.cbxWrapNotes.Text = "Wrap Notes";
            this.cbxWrapNotes.UseVisualStyleBackColor = true;
            // 
            // lblMajorScaleNotesIgnored
            // 
            this.lblMajorScaleNotesIgnored.AutoSize = true;
            this.lblMajorScaleNotesIgnored.Location = new System.Drawing.Point(308, 167);
            this.lblMajorScaleNotesIgnored.Name = "lblMajorScaleNotesIgnored";
            this.lblMajorScaleNotesIgnored.Size = new System.Drawing.Size(13, 13);
            this.lblMajorScaleNotesIgnored.TabIndex = 35;
            this.lblMajorScaleNotesIgnored.Text = "0";
            this.lblMajorScaleNotesIgnored.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(191, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Ignored Notes:";
            // 
            // lblNonDiatonicNotesIgnored
            // 
            this.lblNonDiatonicNotesIgnored.AutoSize = true;
            this.lblNonDiatonicNotesIgnored.Location = new System.Drawing.Point(308, 294);
            this.lblNonDiatonicNotesIgnored.Name = "lblNonDiatonicNotesIgnored";
            this.lblNonDiatonicNotesIgnored.Size = new System.Drawing.Size(13, 13);
            this.lblNonDiatonicNotesIgnored.TabIndex = 37;
            this.lblNonDiatonicNotesIgnored.Text = "0";
            this.lblNonDiatonicNotesIgnored.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(191, 294);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Ignored Notes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 369);
            this.Controls.Add(this.lblNonDiatonicNotesIgnored);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblMajorScaleNotesIgnored);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxWrapNotes);
            this.Controls.Add(this.lblNonDiatonicNotesPerfect);
            this.Controls.Add(this.lblNonDiatonicNotesWrapped);
            this.Controls.Add(this.lblNonDiatonicNotesPlayed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblMajorScaleNotesPerfect);
            this.Controls.Add(this.lblMajorScaleNotesWrapped);
            this.Controls.Add(this.lblMajorScaleNotesPlayed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNonDiatonicStairs);
            this.Controls.Add(this.btnMajorScaleStairs);
            this.Controls.Add(this.btnNonDiatonicDown);
            this.Controls.Add(this.btnNonDiatonicCenter);
            this.Controls.Add(this.btnNonDiatonicUp);
            this.Controls.Add(this.btnMajorScaleDown);
            this.Controls.Add(this.btnMajorScaleCenter);
            this.Controls.Add(this.btnMajorScaleUp);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btnMajorScaleUp;
        private System.Windows.Forms.Button btnMajorScaleCenter;
        private System.Windows.Forms.Button btnMajorScaleDown;
        private System.Windows.Forms.Button btnNonDiatonicDown;
        private System.Windows.Forms.Button btnNonDiatonicCenter;
        private System.Windows.Forms.Button btnNonDiatonicUp;
        private System.Windows.Forms.Button btnMajorScaleStairs;
        private System.Windows.Forms.Button btnNonDiatonicStairs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMajorScaleNotesPerfect;
        private System.Windows.Forms.Label lblMajorScaleNotesWrapped;
        private System.Windows.Forms.Label lblMajorScaleNotesPlayed;
        private System.Windows.Forms.Label lblNonDiatonicNotesPerfect;
        private System.Windows.Forms.Label lblNonDiatonicNotesWrapped;
        private System.Windows.Forms.Label lblNonDiatonicNotesPlayed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbxWrapNotes;
        private System.Windows.Forms.Label lblMajorScaleNotesIgnored;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblNonDiatonicNotesIgnored;
        private System.Windows.Forms.Label label19;
    }
}

