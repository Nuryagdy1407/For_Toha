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

        int team1Points;
        int team2Points;
        int second;

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;
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
            if (data == 1)
            {
                MainLabel.BackColor = Color.Tomato;
            }
            else if(data == 2)
            {
                MainLabel.BackColor= Color.M;
            }
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

        private void team_1UP_Click(object sender, EventArgs e)
        {
            team1Points++;
            team1_Points.Text = team1Points.ToString();
        }

        private void team_1DOWN_Click(object sender, EventArgs e)
        {
            team1Points--;
            team1_Points.Text = team1Points.ToString();
        }

        private void team_2UP_Click(object sender, EventArgs e)
        {
            team2Points++;
            team2_Points.Text = team2Points.ToString();

        }

        private void team_2DOWN_Click(object sender, EventArgs e)
        {
            team2Points--;
            team2_Points.Text = team2Points.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Start")
            {
                timer1.Start();
                button1.Text = "Stop";
            }
            else if(button1.Text == "Stop")
            {
                timer1.Stop();
                button1.Text = "Reset";
            }
            else
            {
                MainLabel.Text = "0";
                second = 0;
                button1.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            MainLabel.Text = second.ToString();
            if
        }
    }
}
