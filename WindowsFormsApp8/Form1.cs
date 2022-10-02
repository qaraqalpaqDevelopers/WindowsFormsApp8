using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        SoundPlayer qosiq = new SoundPlayer(@"tiydi.wav");
        public Form1()
        {
            InitializeComponent();
        }
       

        int l_x = 10, l_y = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = label1.Location.ToString();
            label1.Left += l_x;
            label1.Top += l_y;
            if(label1.Bounds.IntersectsWith(flowLayoutPanel1.Bounds))
            {

                qosiq.Play();
                l_x = l_x - 10;

                label1.ForeColor = Color.Lime;
                flowLayoutPanel1.BackColor = label1.ForeColor;

            }
            if (label1.Bounds.IntersectsWith(flowLayoutPanel2.Bounds))
            {

                qosiq.Play();

                l_y = l_y - 10;

                label1.ForeColor = Color.DarkMagenta;
                flowLayoutPanel2.BackColor = label1.ForeColor;


            }
            if (label1.Bounds.IntersectsWith(flowLayoutPanel3.Bounds))
            {
                qosiq.Play();

                l_x = 10;
                label1.ForeColor = Color.Red;
                flowLayoutPanel3.BackColor = label1.ForeColor;

            }
            if (label1.Bounds.IntersectsWith(flowLayoutPanel4.Bounds))
            {
                qosiq.Play();

                l_y = 10;
                label1.ForeColor = Color.Blue;
                flowLayoutPanel4.BackColor = label1.ForeColor;

            }

        }
    }
}
