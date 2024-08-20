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
using basicname;
using knobname;
using axelname;
using weightname;
using wtname;
using viewname;
using System.Diagnostics;
using System.IO;

namespace comapp
{
    public partial class Form1 : Form
    {
        viewForm viewerForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;

                if (viewerForm == null)
                {
                    viewerForm = new viewForm();
                }
                viewerForm.ShowDialog();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
            basic base1 = new basic(cBoxCOMPORT.Text,btnspan.Text);
            base1.Show();
            base1.opencommonport();
            
        }

        private void btnknob_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
            knob knobcon1 = new knob(cBoxCOMPORT.Text,btnspan.Text);
            knobcon1.Show();
            knobcon1.opencommonport();
        }

        private void btnAxel_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
            axel axel1 = new axel(cBoxCOMPORT.Text, btnspan.Text);
            axel1.Show();
            axel1.opencommonport();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
            weight weight1 = new weight(cBoxCOMPORT.Text, btnspan.Text);
            weight1.Show();
            weight1.opencommonport();
        }

    

        private void btnPathSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";
            openFileDialog.Title = "Select a HEX file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tBoxpathSelect.Text = openFileDialog.FileName;
            }
             
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // viewForm viform1 = new viewForm();
            // viform1.ShowDialog();
            // Store usbasp, m328p, and hex file path in variables
            // Show the view form when the button is clicked
            //viewForm viform1 = new viewForm();
            //viform1.Show();
            if (viewerForm == null || viewerForm.IsDisposed)
            {
                viewerForm = new viewForm();
                viewerForm.FormClosed += ViewerForm_FormClosed;
            }
            viewerForm.Show();

            string hexFilePath = tBoxpathSelect.Text;
            string programmer = comboBox1.SelectedItem?.ToString();
            string controller = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(hexFilePath))
            {
                MessageBox.Show("Please select a HEX file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string command = $"avrdude -c {programmer} -p {controller} -U flash:w:{hexFilePath}:i";
            StringBuilder output = new StringBuilder();

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(processStartInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            output.AppendLine(line);
                        }
                    }

                    using (StreamReader reader = process.StandardError)
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            output.AppendLine(line);
                        }
                    }

                    process.WaitForExit();
                    output.AppendLine($"Exited with code: {process.ExitCode}");
                }
            }
            catch (Exception ex)
            {
                output.AppendLine("Error: " + ex.Message);
            }

            viewerForm.ViewE(output.ToString());
        }

        private void ViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewerForm = null; // Reset viewerForm when closed
        }

     

        private void tBoxpathSelect_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnspan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
