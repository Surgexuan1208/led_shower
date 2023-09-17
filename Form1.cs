using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string left(string text) {
            string str = "";
            for (int i = 1; i < text.Length; i++)
            {
                str += text[i];
            }
            return str;
        }
        private void SetTimer()
        {
            // Create a timer with a two second interval.
            timer1 = new Timer((int)numericUpDown2.Value*1000);
            // Hook up the Elapsed event for the timer. 
            timer1.Elapsed += OnTimedEvent;
            timer1.AutoReset = true;
            timer1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetTimer();
            string str = textBox1.Text;
            label3.Text = str;
            for (int i=0;i< textBox1.Text.Length; i++)
            {
                str = left(str);
                label3.Text= str;
            }
            timer1.Stop();
            timer1.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
