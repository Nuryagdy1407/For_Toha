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
using WMPLib;

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
        bool beforeStart = true;
        bool afterstart = true;

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
            if (beforeStart == false)
            {
                beforeStart = true;
                timer1.Stop();
                if (data == 1)
                {
                    MainLabel.BackColor = Color.Tomato;
                }
                else if (data == 2)
                {
                    MainLabel.BackColor = Color.RoyalBlue;
                }
            }
            else if (beforeStart == true && afterstart == true)
            {
                string mp3FileName = "music.wav";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + mp3FileName);
                player.Play();
                button1.Text = "Reset";
                afterstart = false;
                if (data == 1)
                {
                    MainLabel.BackColor = Color.Tomato;
                }
                else if (data == 2)
                {
                    MainLabel.BackColor = Color.RoyalBlue;
                }
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
            if (button1.Text == "Start")
            {
                timer1.Start();
                beforeStart = false;
                button1.Text = "Reset";
            }
            else if(button1.Text == "Reset")
            {
                timer1.Stop();
                beforeStart=true;
                afterstart = true;
                MainLabel.Text = "60";
                MainLabel.BackColor = Color.White;
                second = 0;
                button1.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            MainLabel.Text = (60-second).ToString();
        }
    }
}
