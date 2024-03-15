using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Brain_Ring
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            serialPort1.Close();
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            Console.WriteLine(ports);
            // Display each port name to the console.
            foreach (string port in ports)
            {
                serialPort1.PortName = port;
            }
            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Maglumat beriji enjamlar bilen baglanyşyk kesildi! Baglanyşygy barlaň!");
                Main_Form_Load(MessageBoxButtons.OKCancel, null);
            }
        }

        private void yazdyr(long data)
        {
            label1.Text = data.ToString();
        }

        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadLine();
            data.Trim();
            long k = Int64.Parse(data);
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    yazdyr(k);
                }));
            }
        }
    }
}
