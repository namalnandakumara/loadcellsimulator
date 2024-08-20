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
using System.Threading;
using KnobControl;

namespace knobname
{
    public partial class knob : Form
    {
        int divisions;
        double angle, mV;
        string comNumber;
        string span;

        public knob(string comNumber, string span)
        {
            this.comNumber = comNumber;
            this.span = span;
            InitializeComponent();
            getAvailablePorts();
            comboBox2.SelectedIndex = 0;

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox2.SelectedItem.ToString(), out divisions))
            {
                knobControl1.ScaleDivisions = divisions + 1;
                knobControl1.Maximum = divisions;
                knobControl1.Value = 0;
                label3.Text = "0.0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comNumber))
                {
                    label4.Text = "Please select a Serial Port";
                }
                else if (serialPort1.IsOpen)
                {
                    //  button1.Enabled = false;
                    //  button2.Enabled = true;
                    MessageBox.Show("COM port already connected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    label4.Text = "";
                    Thread.Sleep(100);
                    serialPort1.Write("0");
                    knobControl1.Value = 0;
                    label3.Text = knobControl1.Value.ToString();
                    knobControl1.Enabled = true;
                    textBox2.Text = "Port Open";
                    pBar1.Value = 100;
                    button1.Enabled = false;
                    button2.Enabled = true;


                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("COM port is already opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

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
                textBox2.Text = "Port Open";

                serialPort1.Write("0");
                knobControl1.Value = 0;
                label3.Text = knobControl1.Value.ToString();
                knobControl1.Enabled = true;

               // MessageBox.Show("COM port connected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

       

        private void button2_Click(object sender, EventArgs e)
        {

            serialPort1.Close();
            //serialPort2.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            textBox2.Text = "Port Closed";
            pBar1.Value = 0;
        }

        private void pBar1_Click(object sender, EventArgs e)
        {

        }

       

        private void knobControl1_Load(object sender, EventArgs e)
        {
            try
            {
                angle = knobControl1.Value;

                if (divisions == 10) mV = angle * 0.2;
                else if (divisions == 5) mV = angle * 0.4;
                else mV = angle * 0.5;
                label3.Text = mV.ToString("0.0");
                String mVV = label3.Text;
                //label3.Text = angle.ToString("0.0");

                //if (angle == 3 && divisions == 5) serialPort1.Write("H");

                if (mVV == "0.0") serialPort1.Write("2,"+span+",0,\n,\r");
                else if (mVV == "0.2") serialPort1.Write("2," + span + ",1,\n,\r"); 
                else if (mVV == "0.4") serialPort1.Write("2," + span + ",2,\n,\r");
                else if (mVV == "0.5") serialPort1.Write("2," + span + ",3,\n,\r");
                else if (mVV == "0.6") serialPort1.Write("2," + span + ",4,\n,\r");
                else if (mVV == "0.8") serialPort1.Write("2," + span + ",5,\n,\r");
                else if (mVV == "1.0") serialPort1.Write("2," + span + ",6,\n,\r");
                else if (mVV == "1.2") serialPort1.Write("2," + span + ",7,\n,\r"); 
                else if (mVV == "1.4") serialPort1.Write("2," + span + ",8,\n,\r");
                else if (mVV == "1.5") serialPort1.Write("2," + span + ",9,\n,\r"); 
                else if (mVV == "1.6") serialPort1.Write("2," + span + ",10,\n,\r"); 
                else if (mVV == "1.8") serialPort1.Write("2," + span + ",11,\n,\r");
                else if (mVV == "2.0") serialPort1.Write("2," + span + ",12,\n,\r");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending command to Device: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

