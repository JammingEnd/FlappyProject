using System;
using System.Windows.Forms;

namespace FlappyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FlappyBird.BringToFront();
            MenuPanel.Visible = true;
            timer1.Enabled = false;
            birdTimer.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movepipe(10);
        }

        Random h = new Random();
        void movepipe(int speed)
        {
            if (pipe1.Left >= 0)
            { pipe1.Left += -speed; }
            else
            { pipe1.Left = 1020;
                pipe1.Height = h.Next(300, 400);  //random value between the entered numbers
                pipe1.Top = 100;
            } //waarschijnlijk de zijkant van de form
            if (pipe2.Left >= 0)
            { pipe2.Left += -speed; }
            else
            { pipe2.Left = 1020;
                pipe2.Height = h.Next(100, 200);
            } //waarschijnlijk de zijkant van de form





        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            birdTimer.Enabled = true;
            MenuPanel.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MenuPanel.Visible = true;
                timer1.Enabled = false;
                birdTimer.Enabled = false;
                Console.WriteLine("esc pressed");
            }
            if (e.KeyCode == Keys.Space)
            {
                FlappyBird.Top += -60;
                Console.WriteLine("space pressed");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(FlappyBird.Top <= 640)
            FlappyBird.Top += 10;
        }

    }
}
