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



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }
               
        public void charge_on()
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("b" + '\n');
            port.Close();
        }

        public void charge_off()
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("a" + '\n');
            port.Close();
        }


        public void batt()
        {
            PowerStatus status = SystemInformation.PowerStatus;
            var current_percent = status.BatteryLifePercent * 100;
            String charger_status = status.PowerLineStatus.ToString();

            label1.Text = (current_percent.ToString() + " %");
      
            if (charger_status == "Online") { label2.Text = "Charging till 95%"; }
            if (charger_status == "Offline") { label2.Text = "Remaining till 50%"; }


            if (current_percent > 95)
            {
                charge_on();

                if (charger_status == "Online") { MessageBox.Show("DISCONNECT CHARGER"); }
            }

            if (current_percent <= 50)
            {  charge_off();
                if (charger_status == "Offline") { MessageBox.Show("CONNECT CHARGER"); }
            }


        }
                
        private void Form1_Load(object sender, EventArgs e)
        {}
              
        private void label10_Click(object sender, EventArgs e)
        {}

        private void label7_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        { batt();  }

        private void button2_Click(object sender, EventArgs e)
        { charge_on();}

        private void button3_Click(object sender, EventArgs e)
        { charge_off(); }

        private void timer1_Tick(object sender, EventArgs e)
        {   batt(); }

        private void ac_on_off_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("c" + '\n');
            port.Close();
        }

        private void heat32_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("d" + '\n');
            port.Close();
        }

        private void heat25_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("e" + '\n');
            port.Close();
        }

        private void heat22_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("f" + '\n');
            port.Close();
        }

        private void cold18_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("g" + '\n');
            port.Close();
        }

        private void cold23_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("h" + '\n');
            port.Close();
        }

        private void fan_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            port.Write("l" + '\n');
            port.Close();
        }
    }


}
