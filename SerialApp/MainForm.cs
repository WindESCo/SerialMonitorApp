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

namespace SerialApp
{
    public partial class MainForm : Form
    {
        private SerialPort SerialPort;
        private delegate void PrintOutputDelegate(string msg);

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string portName = ComPortTb.Text;
                if (portName.Length == 0)
                    throw new Exception("COM port can't be empty");
                int baudRate = int.Parse(BaudRateCmb.Text);
                int dataBits = int.Parse(DataBitsTb.Text);
                StopBits stopBits = (StopBits)StopBitsCmb.SelectedIndex;
                Parity parity = (Parity)ParityCmb.SelectedIndex;
                SerialPort = new SerialPort(ComPortTb.Text, baudRate, parity, dataBits, stopBits);
                SerialPort.DataReceived += SerialPort_DataReceived;
                SerialPort.Open();
                OpenBtn.Enabled = false;
                CloseBtn.Enabled = true;
                SendBtn.Enabled = true;
                PrintOutput("Serial port opened.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[SerialPort.ReadBufferSize];
            int bytesRead = SerialPort.Read(buffer, 0, buffer.Length);
            string received = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            PrintOutput(received);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            SerialPort.Close();
            SerialPort.DataReceived -= SerialPort_DataReceived;
            SerialPort.Dispose();
            PrintOutput("Serial port closed.");
            OpenBtn.Enabled = true;
            CloseBtn.Enabled = false;
            SendBtn.Enabled = false;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string sendStr;
            if (AppendCrCb.Checked == true)
                sendStr = string.Format("{0}\r", CommandTb.Text);
            else
                sendStr = CommandTb.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(string.Format("{0}\r", sendStr));
            SerialPort.Write(bytes, 0, bytes.Length);
            PrintOutput(CommandTb.Text);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            OutputTb.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BaudRateCmb.SelectedIndex = 6;
            StopBitsCmb.SelectedIndex = 1;
            ParityCmb.SelectedIndex = 0;
        }

        private void PrintOutput(string msg)
        {
            if (OutputTb.InvokeRequired)
            {
                PrintOutputDelegate d = new PrintOutputDelegate(PrintOutput);
                Invoke(d, new object[] { msg });
            }
            else
            {
                OutputTb.Text += string.Format("{0}\r\n", msg);
            }
        }
    }
}
