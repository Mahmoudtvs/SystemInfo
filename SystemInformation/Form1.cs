using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfo_MouseHover(object sender, EventArgs e)
        {
            btnGetInfo.ForeColor = Color.White;
        }

        private void btnGetInfo_MouseLeave(object sender, EventArgs e)
        {
            btnGetInfo.ForeColor = Color.Black;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Black;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to closing the system ?", "Application Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to closing the system ?", "Application Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            textBox8.Enabled = true;

            string info1 = Environment.MachineName;
            textBox1.Text = info1;

            string info2 = Environment.UserName;
            textBox2.Text = info2;

            int info3 = Environment.ProcessorCount;
            textBox6.Text = Convert.ToString(info3);

            bool info4 = Environment.Is64BitOperatingSystem;
            textBox7.Text = Convert.ToString(info4);

            bool info5 = Environment.Is64BitProcess;
            textBox8.Text = Convert.ToString(info5);

            string info6 = Environment.OSVersion.ToString();
            textBox4.Text = info6;

            string info7 = Environment.OSVersion.Platform.ToString();
            textBox5.Text = info7;

            string info8 = Environment.OSVersion.Version.ToString();
            textBox3.Text = info8;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox7.Text=="True")
            {
                MessageBox.Show("Your system is a 64 bit operating system", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your system is a 32 bit operating system", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox8.Text=="True")
            {
                MessageBox.Show("Your device is a 64 bit processor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your device is a 32 bit processor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
