using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_A_C_Sharp
{
    public partial class Form1 : Form
    {
        int speed = 1;
        bool moveRight, moveUp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_text_Click(object sender, EventArgs e)
        {
            this.richTextBox_text.AppendText("Welcome to Applications A_1 in C#" + Environment.NewLine);
        }

        private void button_startStop_Click(object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {
                this.button_startStop.Text = "Start";
                this.timer1.Stop();
            }
            else
            {
                this.button_startStop.Text = "Stop";
                this.timer1.Start();
            }
        }

        private void comboBox_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            speed = Int32.Parse(comboBox_speed.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveRight)
            {
                this.pictureBox_ball.Left += speed;
            }
            else
            {
                this.pictureBox_ball.Left -= speed;
            }

            if (moveUp)
            {
                this.pictureBox_ball.Top -= speed;
            }
            else
            {
                this.pictureBox_ball.Top += speed;
            }

            if (this.pictureBox_ball.Left < this.pictureBox_rectangle.Left + 3)
            {
                moveRight = true;
            }

            if (this.pictureBox_ball.Left + this.pictureBox_ball.Width > this.pictureBox_rectangle.Right - 3)
            {
                moveRight = false;
            }

            if (this.pictureBox_ball.Top < this.pictureBox_rectangle.Top + 3)
            {
                moveUp = false;
            }

            if (this.pictureBox_ball.Bottom > this.pictureBox_rectangle.Bottom - 3)
            {
                moveUp = true;
            }
        }
    }
}
