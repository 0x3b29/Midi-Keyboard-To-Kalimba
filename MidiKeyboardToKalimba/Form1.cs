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
        }

        private SerialPort _serialPort;
        private InputDevice _inputDevice;

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

            updateButtonsEnabledStates();
        }

        private void OnEventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            var midiDevice = (MidiDevice)sender;
            Console.WriteLine($"Event received from '{midiDevice.Name}' at {DateTime.Now}: {e.Event}");

            if (_serialPort == null || !_serialPort.IsOpen)
            {
                return;
            }

            string notePrefix = "";

            Melanchall.DryWetMidi.MusicTheory.Note note;

            if (e.Event.EventType.Equals(MidiEventType.NoteOn))
            {
                notePrefix = "";
                note = Melanchall.DryWetMidi.MusicTheory.Note.Get(((NoteOnEvent)e.Event).NoteNumber);
            }

            else if (e.Event.EventType.Equals(MidiEventType.NoteOff))
            {
                // Lowercase "s" means silence note
                notePrefix = "s";
                note = Melanchall.DryWetMidi.MusicTheory.Note.Get(((NoteOffEvent)e.Event).NoteNumber);
            }
            else
            {
                // We do not handle other midi events
                return;
            }

             

            int processedNote = processNote(note.NoteName, note.Octave);
            Console.WriteLine("Arduino gets: " + notePrefix + processedNote + ";");

            try
            {
                _serialPort.WriteLine(notePrefix + processedNote + ";");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Got exception: " + ex.InnerException);
            }
        }

        private void btnConnectMidi_Click(object sender, EventArgs e)
        {
            if (cbMidiDevices.Items.Count == 0)
            {
                MessageBox.Show("No Midi Device selected", "Error");
                return;
            }

            _inputDevice = InputDevice.GetById(((ComboboxItem)cbMidiDevices.SelectedItem).Value);
            _inputDevice.EventReceived += OnEventReceived;

            try
            {
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

        int unplayableCounter = 0;
        int tooLowCounter = 0;
        int tooHighCounter = 0;
        int goodNotesCounter = 0;
        int baseOctave = 7;
        bool wrapNotes = false;

        private int processNote(NoteName noteName, int noteOctave)
        {
            int kalimbaMappedNote = getKalimbaMappedNote(noteName);

            if (kalimbaMappedNote == 0)
            {
                unplayableCounter++;

                // We can never make unplayable notes work because of how a Kalimba is arranged

                return 0;
            }

            if (kalimbaMappedNote + ((noteOctave - baseOctave) * 7) < 1)
            {
                tooLowCounter++;

                if (wrapNotes)
                {
                    Console.WriteLine("kalimbaMappedNote(" + kalimbaMappedNote + ") + ((noteOctave(" + noteOctave + ") - baseOctave(" + baseOctave + ")) * 7)(" + (kalimbaMappedNote + ((noteOctave - baseOctave) * 7)) + ") < 1");

                    // Adjust the octave of the note upwards until the note is in the playable range
                    while (kalimbaMappedNote + ((noteOctave - baseOctave) * 7) < 1)
                    {

                        noteOctave++;

                        Console.WriteLine("kalimbaMappedNote(" + kalimbaMappedNote + ") + ((noteOctave(" + noteOctave + ") - baseOctave(" + baseOctave + ")) * 7)(" + (kalimbaMappedNote + ((noteOctave - baseOctave) * 7)) + ") < 1");
                    }
                }
                else
                {
                    // If we dont wrap the notes around, we are done with this note
                    return 0;
                }
            }
            else if (kalimbaMappedNote + ((noteOctave - baseOctave) * 7) > 17)
            {
                tooHighCounter++;

                if (wrapNotes)
                {
                    // Adjust the octave of the note downwards until the note is in the playable range
                    while (kalimbaMappedNote + ((noteOctave - baseOctave) * 7) > 17)
                    {
                        noteOctave--;
                    }
                }
                else
                {
                    // If we dont wrap the notes around, we are done with this note
                    return 0;
                }
            }
            else
            {
                goodNotesCounter++;
            }

            // If we got here, we either had a good note, or we wrapped a note that was too low or too high
            return (kalimbaMappedNote + ((noteOctave - baseOctave) * 7));
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

                default: return 0;
            }
        }

        private void updateButtonsEnabledStates()
        {
            if (_inputDevice != null || _serialPort != null)
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
            }
            else
            {
                cbSerialPorts.Enabled = true;
                btnConnectSerial.Enabled = true;
                btnDisconnectSerial.Enabled = false;
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
            _inputDevice.StopEventsListening();
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
    }
}
