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

namespace wtname
{
    public partial class wt : Form
    {

        public wt()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            
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
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Select a Serial Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.RtsEnable = true;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.DtrEnable = true;
;
                    serialPort1.Open();

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String InputW = textBox1.Text;
            String InputT = textBox2.Text;
            //label5.Text = Input;

            if (int.TryParse(InputW, out int resultW) && int.TryParse(InputT, out int resultT))
            {
                if (resultW > 5000)
                {
                    // Show error message if number is above 5000
                    MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }             

                else if (resultW < 0 && resultT < 0)
                {
                    // Show error message if numbers are negative
                    MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {                    
                    String DataW = resultW.ToString();
                    String DataT = resultT.ToString();
                   
                    String Data = DataW + "," + DataT + "\r";
                    serialPort1.Write(Data);
                }
            }
            else
            {
                // Show error message
                MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

