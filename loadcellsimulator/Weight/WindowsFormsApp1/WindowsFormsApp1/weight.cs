using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using KnobControl;

namespace weightname
{
    public partial class weight : Form
    {
        string comNumber;
        string span;
        public weight(string comNumber,string span)
        {
            InitializeComponent();
            getAvailablePorts();
            this.comNumber = comNumber;
            this.span = span;
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
                  
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            base.OnFormClosing(e);
            if (serialPort1.IsOpen)
            {

                serialPort1.Close();
            }
            serialPort1.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comNumber))
                {
                    MessageBox.Show("Please Select a Serial Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    serialPort1.PortName = comNumber;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.RtsEnable = true;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.DtrEnable = true;
;
                    serialPort1.Open();
                    pBar1.Value = 100;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("COM port is already opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (serialPort1.IsOpen)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                label3.Text = "Port Open";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            label3.Text = "Port Closed";
            pBar1.Value = 0;
        }

        public void opencommonport()
        {
            try
            {
                serialPort1.PortName = comNumber;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.RtsEnable = true;
                serialPort1.Handshake = Handshake.None;
                serialPort1.DtrEnable = true;

                serialPort1.Open();
                pBar1.Value = 100;
                button1.Enabled = false;
                button2.Enabled = true;
                label3.Text = "Port Open";


             //   MessageBox.Show("COM port connected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access to COM port denied. It may be already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to COM port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void knobControl1_ValueChanged(object sender, EventArgs e)
        { 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String textValue = textBox1.Text;
            int intspan = int.Parse(span);

            if (int.TryParse(textValue, out int result))
            {
                if (result > intspan)
                {
                    // Show error message if number is above 5000
                    MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (result < 0)
                {
                    // Show error message if number is negative
                    MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    textValue = "4," + span + "," + textValue + ",\n\r";
                    serialPort1.Write(textValue);
                  //  MessageBox.Show("Value sent");
                }
            }
            else
            {
                // Show error message
                MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pBar1_Click(object sender, EventArgs e)
        {

        }
    }

}

