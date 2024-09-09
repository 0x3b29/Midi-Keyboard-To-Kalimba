using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Melanchall.DryWetMidi.Devices;
using System.IO.Ports;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.MusicTheory;

namespace PlayKalimbaWithKeyboard
{
    public partial class Form1 : Form
    {
        public class ComboboxItem
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            refreshMidiDevicesAndSerialPortsDropDowns();
            updateNotesCounters();
        }

        private SerialPort _serialPort;
        private SerialPort _serialPort2;
        private InputDevice _inputDevice;

        private const int _noteOctaveOffset = -1;
        private const int _kalimbaBaseOctave = 4;

        private int majorScaleNotesPlayed = 0;
        private int majorScaleNotesPerfect = 0;
        private int majorScaleNotesWrapped = 0;
        private int majorScaleNotesIgnored = 0;

        private int nonDiatonicNotesPlayed = 0;
        private int nonDiatonicNotesPerfect = 0;
        private int nonDiatonicNotesWrapped = 0;
        private int nonDiatonicNotesIgnored = 0;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshMidiDevicesAndSerialPortsDropDowns();
        }

        private void refreshMidiDevicesAndSerialPortsDropDowns()
        {
            cbMidiDevices.DataSource = null;
            List<ComboboxItem> midiDevicesComboBoxItems = new List<ComboboxItem>();

            foreach (InputDevice inputDevice in InputDevice.GetAll())
            {
                midiDevicesComboBoxItems.Add(new ComboboxItem { Name = inputDevice.Name, Value = inputDevice.Id });
            }

            cbMidiDevices.DataSource = midiDevicesComboBoxItems;
            cbMidiDevices.DisplayMember = "Name";
            cbMidiDevices.ValueMember = "Value";
            cbMidiDevices.DropDownStyle = ComboBoxStyle.DropDownList;

            cbSerialPorts.DataSource = null;
            List<ComboboxItem> serialPortsComboBoxItems = new List<ComboboxItem>();

            foreach (string serialPortName in SerialPort.GetPortNames())
            {
                serialPortsComboBoxItems.Add(new ComboboxItem { Name = serialPortName, Value = -1 });
            }

            cbSerialPorts.DataSource = serialPortsComboBoxItems;
            cbSerialPorts.DisplayMember = "Name";
            cbSerialPorts.ValueMember = "Value";
            cbSerialPorts.DropDownStyle = ComboBoxStyle.DropDownList;

            cbSerialPorts2.DataSource = null;
            List<ComboboxItem> serialPortsComboBoxItems2 = new List<ComboboxItem>();

            foreach (string serialPortName in SerialPort.GetPortNames())
            {
                serialPortsComboBoxItems2.Add(new ComboboxItem { Name = serialPortName, Value = -1 });
            }

            cbSerialPorts2.DataSource = serialPortsComboBoxItems2;
            cbSerialPorts2.DisplayMember = "Name";
            cbSerialPorts2.ValueMember = "Value";
            cbSerialPorts2.DropDownStyle = ComboBoxStyle.DropDownList;

            updateButtonsEnabledStates();
        }

        // Generic method to safely update any label from another thread
        private void UpdateLabelSafely(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke((MethodInvoker)delegate
                {
                    label.Text = text;
                });
            }
            else
            {
                label.Text = text;
            }
        }

        private void UpdateButtonEnabledSafely(Button button, bool isEnabled)
        {
            if (button.InvokeRequired)
            {
                button.Invoke((MethodInvoker)delegate {
                    button.Enabled = isEnabled;
                });
            }
            else
            {
                button.Enabled = isEnabled;
            }
        }

        private void updateNotesCounters()
        {
            // Update major scale labels safely
            UpdateLabelSafely(lblMajorScaleNotesPlayed, majorScaleNotesPlayed.ToString());
            UpdateLabelSafely(lblMajorScaleNotesPerfect, majorScaleNotesPerfect.ToString());
            UpdateLabelSafely(lblMajorScaleNotesWrapped, majorScaleNotesWrapped.ToString());
            UpdateLabelSafely(lblMajorScaleNotesIgnored, majorScaleNotesIgnored.ToString());

            // Update non-diatonic scale labels safely
            UpdateLabelSafely(lblNonDiatonicNotesPlayed, nonDiatonicNotesPlayed.ToString());
            UpdateLabelSafely(lblNonDiatonicNotesPerfect, nonDiatonicNotesPerfect.ToString());
            UpdateLabelSafely(lblNonDiatonicNotesWrapped, nonDiatonicNotesWrapped.ToString());
            UpdateLabelSafely(lblNonDiatonicNotesIgnored, nonDiatonicNotesIgnored.ToString());

            // Calculate the sum of the counters
            int sum = majorScaleNotesPlayed + majorScaleNotesPerfect + majorScaleNotesWrapped + majorScaleNotesIgnored
                + nonDiatonicNotesPlayed + nonDiatonicNotesPerfect + nonDiatonicNotesWrapped + nonDiatonicNotesIgnored;

            // Enable or disable the button safely
            UpdateButtonEnabledSafely(btnResetCounters, sum > 0);
        }

        private void OnEventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            var midiDevice = (MidiDevice)sender;
            Console.WriteLine($"Event received from '{midiDevice.Name}' at {DateTime.Now}: {e.Event}");

            string notePrefix = "";

            Melanchall.DryWetMidi.MusicTheory.Note note;
            bool isNoteOff = false;

            if (e.Event.EventType.Equals(MidiEventType.NoteOn))
            {
                notePrefix = "";
                note = Melanchall.DryWetMidi.MusicTheory.Note.Get(((NoteOnEvent)e.Event).NoteNumber);
            }

            else if (e.Event.EventType.Equals(MidiEventType.NoteOff))
            {
                // Lowercase "s" means silence note
                notePrefix = "s";
                isNoteOff = true;
                note = Melanchall.DryWetMidi.MusicTheory.Note.Get(((NoteOffEvent)e.Event).NoteNumber);
            }
            else
            {
                // We do not handle other midi events
                return;
            }

            int adjustedOctave = note.Octave + _noteOctaveOffset;
            int processedNote = processNote(note.NoteName, adjustedOctave);

            bool isKalimbaConnected = false;
            bool isMajorNote = getIsMajorNote(note.NoteName);

            if (isMajorNote && _serialPort != null)
            {
                isKalimbaConnected = true;
            }
            else if (!isMajorNote && _serialPort2 != null)
            {
                isKalimbaConnected = true;
            }

            adjustCounters(note.NoteName, adjustedOctave, isMajorNote, isNoteOff, isKalimbaConnected);
            updateNotesCounters();

            if (isMajorNote)
            {
                if (_serialPort == null || !_serialPort.IsOpen)
                {
                    return;
                }

                try
                {
                    Console.WriteLine("Major Arduino gets: " + notePrefix + processedNote + ";");
                    _serialPort.WriteLine(notePrefix + processedNote + ";");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Got exception: " + ex.InnerException);
                }
            }
            else
            {
                if (_serialPort2 == null || !_serialPort2.IsOpen)
                {
                    return;
                }

                try
                {
                    Console.WriteLine("Non Diatonic Arduino gets: " + notePrefix + processedNote + ";");
                    _serialPort2.WriteLine(notePrefix + processedNote + ";");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Got exception: " + ex.InnerException);
                }
            }
        }

        private void btnConnectMidi_Click(object sender, EventArgs e)
        {
            if (cbMidiDevices.Items.Count == 0)
            {
                btnConnectMidi.BackColor = Color.Red;
                MessageBox.Show("No Midi Device selected", "Error");
                return;
            }

            try
            {
                _inputDevice = InputDevice.GetById(((ComboboxItem)cbMidiDevices.SelectedItem).Value);
                _inputDevice.EventReceived += OnEventReceived;
                _inputDevice.StartEventsListening();
                btnConnectMidi.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Midi Device could not be selected: '" + ex.Message + "'", "Error");
                btnConnectMidi.BackColor = Color.Red;
            }

            updateButtonsEnabledStates();
        }

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            if (cbSerialPorts.Items.Count == 0)
            {
                MessageBox.Show("No serial port selected", "Error");
                btnConnectSerial.BackColor = Color.Red;

                return;
            }

            _serialPort = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort.PortName = ((ComboboxItem)cbSerialPorts.SelectedItem).Name;
            _serialPort.BaudRate = 115200;
            _serialPort.Parity = 0;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = 0;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 1000;

            try
            {
                _serialPort.Open();
                btnConnectSerial.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open serial port : " + ex.Message, "Error");
                _serialPort = null;
                btnConnectSerial.BackColor = Color.Red;
            }

            updateButtonsEnabledStates();
        }

        private void adjustCounters(NoteName noteName, int dawAdjustedOctave, bool isMajorNote, bool isNoteOff, bool isKalimbaConnected)
        {
            if (isNoteOff)
            {
                return;
            }

            if (!isKalimbaConnected)
            {
                if (isMajorNote)
                {
                    majorScaleNotesIgnored++;
                }
                else
                {
                    nonDiatonicNotesIgnored++;
                }

                return;
            }

            // Value from 1 = C to 7 = B
            int mappedNoteNumber = getKalimbaMappedNote(noteName);

            // Valid octaves are 0, 1 and 2, but 2 only partially (C, D and E)
            int kalimbaOctave = dawAdjustedOctave - _kalimbaBaseOctave;

            // Valid tines are 1 = C4 to 17 = E6
            int kalimbaTine = mappedNoteNumber + (kalimbaOctave * 7);

            bool needsWrapping = false;

            if (kalimbaTine < 1 || kalimbaTine > 17)
            {
                needsWrapping = true;
            }

            if (needsWrapping)
            {
                if (cbxWrapNotes.Checked)
                {
                    if (isMajorNote)
                    {
                        majorScaleNotesWrapped++;
                        majorScaleNotesPlayed++;
                    }
                    else
                    {
                        nonDiatonicNotesWrapped++;
                        nonDiatonicNotesPlayed++;
                    }
                }
                else
                {
                    if (isMajorNote)
                    {
                        majorScaleNotesIgnored++;
                    }
                    else
                    {
                        nonDiatonicNotesIgnored++;
                    }
                }
            }
            else
            {
                if (isMajorNote)
                {
                    majorScaleNotesPerfect++;
                    majorScaleNotesPlayed++;
                }
                else
                {
                    nonDiatonicNotesPerfect++;
                    nonDiatonicNotesPlayed++;
                }
            }
        }

        private int processNote(NoteName noteName, int dawAdjustedOctave)
        {
            // Value from 1 = C to 7 = B
            int mappedNoteNumber = getKalimbaMappedNote(noteName);

            // Valid octaves are 0, 1 and 2, but 2 only partially (C, D and E)
            int kalimbaOctave = dawAdjustedOctave - _kalimbaBaseOctave;

            // Valid tines are 1 = C4 to 17 = E6
            int kalimbaTine = mappedNoteNumber + (kalimbaOctave * 7);

            // Wrap around to valid tines (1 to 17)
            int wrappedTine = kalimbaTine;

            // Wrap the tines around the valid range from 1 (C4) to 17 (E6)
            if (wrappedTine < 1)
            {
                // Wrap down into valid range by adding 14 (2 full octaves of 7 notes)
                while (wrappedTine < 1)
                {
                    wrappedTine += 14;  // Add 14 to wrap into the higher valid octave
                }
            }
            else if (wrappedTine > 17)
            {
                // Wrap up into valid range by subtracting 14 (2 octaves)
                while (wrappedTine > 17)
                {
                    wrappedTine -= 14;  // Subtract 14 to wrap back into the valid range
                }
            }

            Console.WriteLine("kalimbaTine: " + kalimbaTine + ", wrappedTine: " + wrappedTine + ", dawAdjustedOctave: " + dawAdjustedOctave);

            bool isNoteBelowKalimbaRange = kalimbaTine < 1;
            bool isNoteAboveKalimbaRange = kalimbaTine > 17;

            if (isNoteBelowKalimbaRange || isNoteAboveKalimbaRange)
            {
                if (cbxWrapNotes.Checked)
                {
                    return wrappedTine;
                }
                else
                {
                    // If we dont wrap the notes around, we are done with this note
                    return 0;
                }
            }

            // If we got here, we either had a good note, or we wrapped a note that was too low or too high
            return kalimbaTine;
        }

        private bool getIsMajorNote(NoteName noteName)
        {
            switch (noteName)
            {
                case NoteName.C:
                case NoteName.D:
                case NoteName.E:
                case NoteName.F:
                case NoteName.G:
                case NoteName.A:
                case NoteName.B:
                    return true;

                default:
                    return false;
            }
        }

        private int getKalimbaMappedNote(NoteName noteName)
        {
            switch (noteName)
            {
                case NoteName.C: return 1;
                case NoteName.D: return 2;
                case NoteName.E: return 3;
                case NoteName.F: return 4;
                case NoteName.G: return 5;
                case NoteName.A: return 6;
                case NoteName.B: return 7;

                case NoteName.CSharp: return 1;
                case NoteName.DSharp: return 2;
                case NoteName.FSharp: return 4;
                case NoteName.GSharp: return 5;
                case NoteName.ASharp: return 6;

                default: return 0;
            }
        }

        private void updateButtonsEnabledStates()
        {
            if (_inputDevice != null || _serialPort != null || _serialPort2 != null)
            {
                btnRefresh.Enabled = false;
            }
            else
            {
                btnRefresh.Enabled = true;
            }

            if (_serialPort != null)
            {
                cbSerialPorts.Enabled = false;
                btnConnectSerial.Enabled = false;
                btnDisconnectSerial.Enabled = true;

                btnMajorScaleUp.Enabled = true;
                btnMajorScaleCenter.Enabled = true;
                btnMajorScaleDown.Enabled = true;
                btnMajorScaleStairs.Enabled = true;
            }
            else
            {
                cbSerialPorts.Enabled = true;
                btnConnectSerial.Enabled = true;
                btnDisconnectSerial.Enabled = false;

                btnMajorScaleUp.Enabled = false;
                btnMajorScaleCenter.Enabled = false;
                btnMajorScaleDown.Enabled = false;
                btnMajorScaleStairs.Enabled = false;
            }

            if (_serialPort2 != null)
            {
                cbSerialPorts2.Enabled = false;
                btnConnectSerial2.Enabled = false;
                btnDisconnectSerial2.Enabled = true;

                btnNonDiatonicUp.Enabled = true;
                btnNonDiatonicCenter.Enabled = true;
                btnNonDiatonicDown.Enabled = true;
                btnNonDiatonicStairs.Enabled = true;
            }
            else
            {
                cbSerialPorts2.Enabled = true;
                btnConnectSerial2.Enabled = true;
                btnDisconnectSerial2.Enabled = false;

                btnNonDiatonicUp.Enabled = false;
                btnNonDiatonicCenter.Enabled = false;
                btnNonDiatonicDown.Enabled = false;
                btnNonDiatonicStairs.Enabled = false;
            }

            if (_inputDevice != null)
            {
                cbMidiDevices.Enabled = false;
                btnConnectMidi.Enabled = false;
                btnDisconnectMidi.Enabled = true;
            }
            else
            {
                cbMidiDevices.Enabled = true;
                btnConnectMidi.Enabled = true;
                btnDisconnectMidi.Enabled = false;
            }
        }

        private void btnDisconnectMidi_Click(object sender, EventArgs e)
        {
            try
            {
                _inputDevice.StopEventsListening();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error stopping the event listening: " + ex.Message);
            }

            _inputDevice.EventReceived -= OnEventReceived;
            _inputDevice.Dispose();
            _inputDevice = null;

            btnConnectMidi.BackColor = Color.LightGray;
            updateButtonsEnabledStates();
        }

        private void btnDisconnectSerial_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            _serialPort = null;
            btnConnectSerial.BackColor = Color.LightGray;
            updateButtonsEnabledStates();
        }

        private void btnConnectSerial2_Click(object sender, EventArgs e)
        {
            if (cbSerialPorts.Items.Count == 0)
            {
                MessageBox.Show("No serial port selected", "Error");
                btnConnectSerial.BackColor = Color.Red;

                return;
            }

            _serialPort2 = new SerialPort();

            // Allow the user to set the appropriate properties.
            _serialPort2.PortName = ((ComboboxItem)cbSerialPorts2.SelectedItem).Name;
            _serialPort2.BaudRate = 115200;
            _serialPort2.Parity = 0;
            _serialPort2.DataBits = 8;
            _serialPort2.StopBits = StopBits.One;
            _serialPort2.Handshake = 0;

            // Set the read/write timeouts
            _serialPort2.ReadTimeout = 500;
            _serialPort2.WriteTimeout = 1000;

            try
            {
                _serialPort2.Open();
                btnConnectSerial2.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open serial port : " + ex.Message, "Error");
                _serialPort2 = null;
                btnConnectSerial2.BackColor = Color.Red;
            }

            updateButtonsEnabledStates();
        }

        private void btnDisconnectSerial2_Click(object sender, EventArgs e)
        {
            _serialPort2.Close();
            _serialPort2 = null;
            btnConnectSerial2.BackColor = Color.LightGray;
            updateButtonsEnabledStates();
        }

        private void btnMajorScaleUp_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("u;");
        }

        private void btnMajorScaleCenter_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("c;");
        }

        private void btnMajorScaleDown_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("d;");
        }

        private void btnMajorScaleStairs_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("x;");
        }

        private void btnNonDiatonicUp_Click(object sender, EventArgs e)
        {
            _serialPort2.WriteLine("u;");
        }

        private void btnNonDiatonicCenter_Click(object sender, EventArgs e)
        {
            _serialPort2.WriteLine("c;");
        }

        private void btnNonDiatonicDown_Click(object sender, EventArgs e)
        {
            _serialPort2.WriteLine("d;");
        }

        private void btnNonDiatonicStairs_Click(object sender, EventArgs e)
        {
            _serialPort2.WriteLine("x;");
        }

        private void btnResetCounters_Click(object sender, EventArgs e)
        {
            majorScaleNotesPlayed = 0;
            majorScaleNotesPerfect = 0;
            majorScaleNotesWrapped = 0;
            majorScaleNotesIgnored = 0;

            nonDiatonicNotesPlayed = 0;
            nonDiatonicNotesPerfect = 0;
            nonDiatonicNotesWrapped = 0;
            nonDiatonicNotesIgnored = 0;

            updateNotesCounters();
        }
    }
}
