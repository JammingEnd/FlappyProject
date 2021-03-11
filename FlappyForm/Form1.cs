using System;
using System.Windows.Forms;

namespace FlappyForm
{
    
    public partial class Form1 : Form
    {
        int flappyJumpSpeed = 80; //default for now
        int gameSpeed = 10; //default for now
        int score = 0;
        int tableOf = 5;
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FlappyBird.BringToFront();
            MenuPanel.Visible = true;
            timer1.Enabled = false;
            birdTimer.Enabled = false;
            this.DoubleBuffered = true;
            GOText.Visible = false;
            currentScore.Visible = false;
            menuScore.Visible = false;
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movepipe(gameSpeed);
            gameOver();
            speedUp();
           // addPoints();
        }

        Random h = new Random();
        void movepipe(int speed)
        {
            if (pipe1.Left >= 0) //bottom pipe
            { pipe1.Left += -speed; }
            else
            { pipe1.Left = 1800;
                pipe1.Height = h.Next(50 ,100);  //random value between the entered numbers
             // reversing height somewhay
            }

            if (pipe5.Left >= 0) //bottom pipe
            { pipe5.Left += -speed; }
            else
            {
                pipe5.Left = 1800;
                pipe5.Height = h.Next(50, 100);  //random value between the entered numbers
               
              
                                                 // reversing height somewhay
            }

            if (pipe2.Left >= 0)  //top pipe
            { pipe2.Left += -speed; }
            else
            { pipe2.Left = 1800;
                pipe2.Height = h.Next(100, 500);
            }

            if (pipe4.Left >= 0)  //top pipe
            { pipe4.Left += -speed; }
            else
            {
                pipe4.Left = 1800;
                pipe4.Height = h.Next(100, 500);
            }
            if (detectPipe1.Left >= 0)  
            { detectPipe1.Left += -speed; }
            else
            {
                detectPipe1.Left = 1800;
              
            }
            if (detectPipe2.Left >= 0)  
            { detectPipe2.Left += -speed; }
            else
            {
                detectPipe2.Left = 1800;
             
            }
        }
        void speedUp()
        {
            if(score == tableOf)
            {
                gameSpeed = gameSpeed + 1;
                tableOf = tableOf + 5;
                currentScore.Text = "speed up!";
            }
        }
        void addPoints()
        {
            if((FlappyBird.Bounds.IntersectsWith(detectPipe1.Bounds)) || (FlappyBird.Bounds.IntersectsWith(detectPipe2.Bounds)))
            {
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            
        }
        void gameOver()
        {
        if (/*(FlappyBird.Bounds.IntersectsWith(pipe1.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe2.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe5.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe4.Bounds)) || */ FlappyBird.Top == 660 || FlappyBird.Top == 0)
            {
                MenuPanel.Visible = true;
                timer1.Enabled = false;
                birdTimer.Enabled = false;
                flappyJumpSpeed = 0;
                GOText.Visible = true;
                menuScore.Visible = true;
                menuScore.Text = score.ToString();
                gameSpeed = 10;

            }
         
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
            GOText.Visible = false;
            currentScore.Visible = true;
            score = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                FlappyBird.Top += -flappyJumpSpeed;
                Console.WriteLine("space pressed");
            }
               
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(FlappyBird.Top <= 655)
               FlappyBird.Top += 5;
        }

        private void FlappyBird_Click(object sender, EventArgs e)
        {

        }

        private void pipe2_Click(object sender, EventArgs e)
        {

        }

        private void pointTimer_Tick(object sender, EventArgs e)
        {
            addPoints();
        }
    }
}
