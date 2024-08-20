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

namespace axelname
{

    public partial class axel : Form
    {
        private int fNumber;
        string comNumber;
        string span;

        public axel(string comNumber , string span)
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
            catch (Exception ) 
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

               
              //  MessageBox.Show("COM port connected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            button1.Enabled = true;
            button2.Enabled = false;
            label3.Text = "Port Closed";
            pBar1.Value = 0;
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;

            if (int.TryParse(number, out int result))
            {
                if (result > 10)
                {
                    // Show error message if number is above 10
                    MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (result < 0)
                {
                    // Show error message if number is negative
                    MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    fNumber = result;
                    String Finalnumber = result.ToString();

                    //label7.Text = Finalnumber;

                    // Set visibility for text boxes
                    Control[] w = { w1, w2, w3, w4, w5, w6, w7, w8, w9, w10 };
                    Control[] t = { t1, t2, t3, t4, t5, t6, t7, t8, t9 };
 
                    for (int i = 0; i < w.Length; i++)
                    { w[i].Visible = false; }
                    for (int i = 0; i < t.Length; i++)
                    { t[i].Visible = false; }

                    // Clear text boxes
                    for (int i = 0; i < w.Length; i++)
                    { w[i].Text = String.Empty; }
                    for (int i = 0; i < t.Length; i++)
                    { t[i].Text = String.Empty; }

                    for (int i = 0; i < fNumber; i++)
                    { w[i].Visible = true; }
                    for (int i = 0; i < fNumber - 1; i++)
                    { t[i].Visible = true; }

                    // Set visibility for labels
                    Control[] wl = { wl1, wl2, wl3, wl4, wl5, wl6, wl7, wl8, wl9, wl10 };
                    Control[] tl = { tl1, tl2, tl3, tl4, tl5, tl6, tl7, tl8, tl9 };
                    
                    for (int i = 0; i < wl.Length; i++)
                    { wl[i].Visible = false; }
                    for (int i = 0; i < tl.Length; i++)
                    { tl[i].Visible = false; }

                    for (int i = 0; i < fNumber; i++)
                    { wl[i].Visible = true; }
                    for (int i = 0; i < fNumber - 1; i++)
                    { tl[i].Visible = true; }

                }
            }
            else
            {
                // Show error message
                MessageBox.Show("Please enter a valid number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int intspan = int.Parse(span);

            Control[] weights = { w1, w2, w3, w4, w5, w6, w7, w8, w9, w10 };
            Control[] time = { t1, t2, t3, t4, t5, t6, t7, t8, t9 };

            int[] resultW = new int[10]; 
            int[] resultT = new int[10];

            for (int i = 0; i < fNumber; i++)
            {
                if (int.TryParse(weights[i].Text, out resultW[i]) )
                {
                    if (resultW[i] > intspan)
                    {
                        // Show error message if number is above 5000
                        MessageBox.Show("Please enter a valid number for W"+ (i + 1), "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (resultW[i] < 0)
                    {
                        // Show error message if number is negative
                        MessageBox.Show("Please enter a valid number for W"+ (i + 1), "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Show error message
                    MessageBox.Show("Please enter a valid number for W"+ (i + 1), "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               
            }

            for (int i = 0; i < fNumber-1; i++)
            {
                if (int.TryParse(time[i].Text, out resultT[i]))
                {
                    if (resultT[i] < 0)
                    {
                        // Show error message if number is not divisible by 50
                        MessageBox.Show("Please enter a valid number for T"+ (i + 1), "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Show error message
                    MessageBox.Show("Please enter a valid number for T"+ (i + 1), "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

                string Data = "";

            for (int i = 0; i < fNumber; i++)
            {
                Data += resultW[i];
                if (i < fNumber - 1)
                {
                    Data += "," + resultT[i] + ",";
                }
            }

            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }

            String DataN = "3,"+span+","+Data + "\r" + "\n";
            serialPort1.Write(DataN);
            //label7.Text = DataN;
        }

        private void axel_Load(object sender, EventArgs e)
        {

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

        private void pBar1_Click(object sender, EventArgs e)
        {

        }

        
    }

}

