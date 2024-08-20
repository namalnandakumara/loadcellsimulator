using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace basicname
{
    public partial class basic : Form
    {
       

        string comNumber;
        string span;

        public basic(string comNumber , string span)
        {
            this.comNumber = comNumber;
            this.span = span;
            InitializeComponent();
            GetAvailablePorts();
           
        }

        void GetAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comNumber))
            {
                MessageBox.Show("Please select a port before opening.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
               // MessageBox.Show("COM port disconnected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeButtonAppearance(false);
                pBar1.Value = 0;
            }
            else
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
                 //   MessageBox.Show("COM port connected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangeButtonAppearance(true);
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
                ChangeButtonAppearance(true);
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

        private void ChangeButtonAppearance(bool connected)
        {
            if (connected)
            {
                button1.Enabled = true;
                button1.Text = "close";
                label1.Text = "connected";
                pBar1.Value = 100;

                button1.ForeColor = Color.Green;
                button1.Font = new Font(button1.Font, FontStyle.Bold);
                button1.BackColor = Color.Gray;
            }
            else
            {
                button1.Enabled = true;
                button1.Text = "open";
                label1.Text = "disconnected";
                button1.BackColor = SystemColors.Control;
                pBar1.Value = 0;
            }
        }

    

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (serialPort1.IsOpen)
                serialPort1.Close();
            serialPort1.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("8,"+span+",0" + ",\n," + "\r");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error: Access to COM port denied. It may be already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: An I/O error occurred while communicating with the COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("8," + span + ",1" + "\n," + "\r");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error: Access to COM port denied. It may be already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: An I/O error occurred while communicating with the COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("8," + span + ",2" + "\r," + "\n");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error: Access to COM port denied. It may be already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: An I/O error occurred while communicating with the COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("8," + span + ",3" + "\r," + "\n");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error: Access to COM port denied. It may be already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: An I/O error occurred while communicating with the COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void SendSignal(char signal)
        {
            button1.Enabled = true;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(signal.ToString());
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error: Access to COM port denied. It may be already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Error: An I/O error occurred while communicating with the COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void knobControl1_Load_1(object sender, EventArgs e)
        {
            int stage = knobControl1.Value;
            switch (stage)
            {
                case 0:
                    serialPort1.Write("1," +span+ ",0"+"\r," + "\n");
                    break;
                case 1:
                    serialPort1.Write("1," + span + ",1" + "\r," + "\n");
                    break;
                case 2:
                    serialPort1.Write("1," + span + ",2" + "\r," + "\n");
                    break;
                case 3:
                    serialPort1.Write("1," + span + ",3" + "\r," + "\n");
                    break;
                case 4:
                    serialPort1.Write("1," + span + ",4" + "\r," + "\n");
                    break;
                default:
                    // Handle invalid stage
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the default ding sound
                e.SuppressKeyPress = true;

                // Get the text from textBox1
                string textValue = textBox1.Text;

                // Try to convert the text to an integer
                int intValue;
                bool success = int.TryParse(textValue, out intValue);

                if (!success || intValue < 0)
                {
                    MessageBox.Show("Number is not valid. Please enter a value between 0 and 5000.");
                }
                else
                {
                    // If conversion is successful, show the value
                  //  MessageBox.Show("Converted value: " + intValue);

                  //  int wiper = intValue ;
                  //  char ch = (char)wiper;
                    // Ensure 'wiper' is sent as a string or byte array
                  //  string wiperString = ch.ToString();

                    try
                    {
                        textValue = "7," + span +","+textValue + "\r," + "\n";
                        serialPort1.Write(textValue);
                      //  MessageBox.Show("Value sent");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending data: " + ex.Message);
                    }

                   // MessageBox.Show("Value of: " + (wiper * 50));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
