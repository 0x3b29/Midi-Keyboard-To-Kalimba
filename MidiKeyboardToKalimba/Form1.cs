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
        }

        static SerialPort _serialPort;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbMidiDevices.Items.Clear();
            List<ComboboxItem> midiDevicesComboBoxItems = new List<ComboboxItem>();

            foreach (InputDevice inputDevice in InputDevice.GetAll())
            {
                midiDevicesComboBoxItems.Add(new ComboboxItem {Name = inputDevice.Name, Value = inputDevice.Id });
            }

            cbMidiDevices.DataSource = midiDevicesComboBoxItems;
            cbMidiDevices.DisplayMember = "Name";
            cbMidiDevices.ValueMember = "Value";      
            cbMidiDevices.DropDownStyle = ComboBoxStyle.DropDownList;


            cbSerialPorts.Items.Clear();
            List<ComboboxItem> serialPortsComboBoxItems = new List<ComboboxItem>();

            foreach (string serialPortName in SerialPort.GetPortNames())
            {
                serialPortsComboBoxItems.Add(new ComboboxItem { Name = serialPortName, Value = -1 });
            }

            cbSerialPorts.DataSource = serialPortsComboBoxItems;
            cbSerialPorts.DisplayMember = "Name";
            cbSerialPorts.ValueMember = "Value";
            cbSerialPorts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void OnEventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            var midiDevice = (MidiDevice)sender;
            Console.WriteLine($"Event received from '{midiDevice.Name}' at {DateTime.Now}: {e.Event}");

            if (e.Event.EventType.Equals(MidiEventType.NoteOn))
            {
                if (_serialPort.IsOpen)
                {
                    Melanchall.DryWetMidi.MusicTheory.Note note = Melanchall.DryWetMidi.MusicTheory.Note.Get(((NoteOnEvent)e.Event).NoteNumber);

                    Console.WriteLine("Arduino gets: " + processNote(note.NoteName, note.Octave));

                    try
                    {
                        _serialPort.WriteLine(processNote(note.NoteName, note.Octave) + ";");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Got exception: " + ex.InnerException);
                    } 
                }
            }

            if (e.Event.EventType.Equals(MidiEventType.NoteOff))
            {
                if (_serialPort.IsOpen)
                {
                    Melanchall.DryWetMidi.MusicTheory.Note note = Melanchall.DryWetMidi.MusicTheory.Note.Get(((NoteOffEvent)e.Event).NoteNumber);

                    Console.WriteLine("Arduino gets off: " + processNote(note.NoteName, note.Octave));

                    try
                    {
                        _serialPort.WriteLine("s" + processNote(note.NoteName, note.Octave) + ";");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Got exception: " + ex.InnerException);
                    }
                }
            }
        }

        private void btnConnectMidi_Click(object sender, EventArgs e)
        {
            if (cbMidiDevices.Items.Count > 0)
            {
                InputDevice inputDevice = InputDevice.GetById(((ComboboxItem)cbMidiDevices.SelectedItem).Value);
                inputDevice.EventReceived += OnEventReceived;
                inputDevice.StartEventsListening();
            }
            else
            {
                MessageBox.Show("Error", "No Midi Device selected");
            }
        }

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            if (cbSerialPorts.Items.Count > 0)
            {
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Could not open serial port : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error", "No serial port selected");
            }
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
    }
}
