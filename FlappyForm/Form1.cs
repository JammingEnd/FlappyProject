using System;
using System.Windows.Forms;

namespace FlappyForm
{
    public partial class Form1 : Form
    {
        private int flappyJumpSpeed = 80; //default for now
        private int gameSpeed = 10; //default for now
        private int score = 0; //default starting score
        private int tableOf = 5; //preset for the table of 5
        private int defaultLives = 3;
        private int startingLives = 3; //should be self explanatory
        private int totalScore = 0;
        private int HSscore;
        private string HSname;
        private DateTime HSdate;
        

        public Form1()
        {
            InitializeComponent();
          
            WindowState = FormWindowState.Maximized;
            SQLReader();
            FlappyBird.BringToFront();
            MenuPanel.Visible = true;
            timer1.Enabled = false;
            birdTimer.Enabled = false;
            this.DoubleBuffered = true;
            GOText.Visible = false;
            currentScore.Visible = false;
            menuScore.Visible = false;
            KeyPreview = true;
            lifeLabel.Text = "lives:" + startingLives.ToString();
            healthbar.Maximum = startingLives;
            healthbar.Minimum = 0;
            healthbar.Value = healthbar.Maximum;
            StartupHeight();
            pipeTop1.Visible = false;
            PipeBottom1.Visible = false;
            HighscorePanel.Visible = false;
        }

        void SQLReader()
        {
            CreateTable.Program program = new CreateTable.Program();

            program.MReaderMain();
            HSscore = program.score;
            HSname = program.name;
            HSdate = program.date;

            if (HSscore == 0 || HSname == null)
            {
                Console.WriteLine("error occured");
                return;
                
            }
            Console.WriteLine(HSscore.ToString(), HSname, HSdate.ToString());
        }

        private Random h = new Random(); //random height
        private Random betweenRandom = new Random(); //random space between the pipes
                                                     //  private Random offRandom = new Random(); //pipe offset

        private void StartupHeight()
        {
            pipe2.Height = h.Next(100, 300);//random value between the entered numbers
            pipe1.Top = pipe2.Bottom + betweenRandom.Next(150, 250);
            pipe4.Height = h.Next(100, 300);//random value between the entered numbers
            pipe5.Top = pipe4.Bottom + betweenRandom.Next(150, 250);
            pipeTop1.Height = h.Next(100, 300);//random value between the entered numbers
            PipeBottom1.Top = pipeTop1.Bottom + betweenRandom.Next(150, 250);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movepipe(gameSpeed);
            gameOver();
            speedUp();
            // addPoints();
            
        }

        private void movepipe(int speed)
        {
            if (pipe1.Left >= 0) //bottom pipe
            { pipe1.Left += -speed; }
            else
            {
                pipe1.Left = 1800;
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (pipe5.Left >= 0) //bottom pipe
            { pipe5.Left += -speed; }
            else
            {
                pipe5.Left = 1800;
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (PipeBottom1.Left >= 0) //bottom pipe
            { PipeBottom1.Left += -speed; }
            else
            {
                PipeBottom1.Left = 1800;
                if (PipeBottom1.Visible != false)
                {
                    score = score + 1;
                }
                currentScore.Text = "Score:" + score.ToString();
            }

            if (pipe2.Left >= 0)  //top pipe
            { pipe2.Left += -speed; }
            else
            {
                pipe2.Left = 1800;
                pipe2.Height = h.Next(100, 300);//random value between the entered numbers
                pipe1.Top = pipe2.Bottom + betweenRandom.Next(150, 250);
                //  pipe2.Left = 1800 + offRandom.Next(0, 150);
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }

            if (pipe4.Left >= 0)  //top pipe
            { pipe4.Left += -speed; }
            else
            {
                pipe4.Left = 1800;
                pipe4.Height = h.Next(100, 300);//random value between the entered numbers
                pipe5.Top = pipe4.Bottom + betweenRandom.Next(150, 250);
                //  pipe4.Left = 1800 + offRandom.Next(0, 150);
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (pipeTop1.Left >= 0)  //top pipe
            { pipeTop1.Left += -speed; }
            else
            {
                pipeTop1.Left = 1800;
                pipeTop1.Height = h.Next(100, 300);//random value between the entered numbers
                PipeBottom1.Top = pipeTop1.Bottom + betweenRandom.Next(150, 250);
                if (pipeTop1.Visible != false)
                {
                    score = score + 1;
                }

                currentScore.Text = "Score:" + score.ToString();
                //  pipeTop1.Left = 1800 + offRandom.Next(0, 150);
            }
        }

        private void speedUp()
        {
            if (score == tableOf)
            {
                gameSpeed = gameSpeed + 1;
                tableOf = tableOf + 5;
                currentScore.Text = "speed up!";
            }
        }

        #region addpoints [decapretated]

        private void addPoints()
        {
            if (pipe1.Left <= 0)
            {
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (pipe2.Left <= 0)
            {
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (pipe5.Left <= 0)
            {
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (pipe4.Left <= 0)
            {
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (pipeTop1.Left <= 0)
            {
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (PipeBottom1.Left <= 0)
            {
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
        }

        #endregion addpoints [decapretated]

        private void gameOver()
        {
            var intersectsWithTop = FlappyBird.Bounds.IntersectsWith(pipeTop1.Bounds);
            var intersectsWithBottom = FlappyBird.Bounds.IntersectsWith(PipeBottom1.Bounds);
            if (score < 2)
            {
                intersectsWithTop = pipe1.Bounds.IntersectsWith(pipeTop1.Bounds);
                intersectsWithBottom = pipe1.Bounds.IntersectsWith(PipeBottom1.Bounds);
                pipeTop1.Visible = false;
                PipeBottom1.Visible = false;
            }
            else
            {
                pipeTop1.Visible = true;
                PipeBottom1.Visible = true;
            }
            if (/*(FlappyBird.Bounds.IntersectsWith(pipe1.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe2.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe5.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe4.Bounds)) || */ FlappyBird.Top == 660 || FlappyBird.Top == 0 || intersectsWithBottom || intersectsWithTop)
            {
                MenuPanel.Visible = true;
                timer1.Enabled = false;
                birdTimer.Enabled = false;
                flappyJumpSpeed = 0;
                GOText.Visible = true;
                menuScore.Visible = true;
                gameSpeed = 10;
                startingLives = startingLives - 1;
                healthbar.Value = startingLives;
                lifeLabel.Text = startingLives.ToString();
                StartButton.Enabled = true;
                totalScore = totalScore + score;
                menuScore.Text = "Total score:" + totalScore.ToString();
                HSButton.Enabled = true;

                Reset();
            }
        }

        private void Reset()
        {
            #region Default Form

            FlappyBird.Top = 265;
            pipe1.Location = new System.Drawing.Point(1784, 604);
            pipe2.Location = new System.Drawing.Point(1784, -2);
            pipe4.Location = new System.Drawing.Point(998, -2);
            pipe5.Location = new System.Drawing.Point(998, 604);
            pipeTop1.Location = new System.Drawing.Point(341, -2);
            PipeBottom1.Location = new System.Drawing.Point(341, 604);
            // pipe1.Height = 451;
            // pipe2.Height = 195;
            // pipe4.Height = 195;
            //  pipe5.Height = 451;
            //  pipeTop1.Height = 195;
            // PipeBottom1.Height = 451;
            pipeTop1.Visible = false;
            PipeBottom1.Visible = false;

            #endregion Default Form
        }

        private void LifeReset()
        {
            if (startingLives == 0)
            {
                startingLives = defaultLives;
                totalScore = 0;
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
            if (flappyJumpSpeed == 0)
            {
                flappyJumpSpeed = 80;
            }

            StartButton.Enabled = false;
            MenuPanel.Visible = false;
            GOText.Visible = false;
            currentScore.Visible = true;
            HighscorePanel.Visible = false;
            HSButton.Enabled = false;
            score = 0;
            LifeReset();
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
            if (FlappyBird.Top <= 655)
                FlappyBird.Top += 5;
        }

        #region oopsies void

        private void FlappyBird_Click(object sender, EventArgs e)
        {
        }

        private void pipe2_Click(object sender, EventArgs e)
        {
        }

        private void menuScore_Click(object sender, EventArgs e)
        {
        }

        private void lifeLabel_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pipe4_Click(object sender, EventArgs e)
        {
        }

        private void pipeTop1_Click(object sender, EventArgs e)
        {
        }

        #endregion oopsies void

        private void HSButton_Click(object sender, EventArgs e)
        {
            HighscorePanel.Visible = true;
            MenuPanel.Visible = false;
        }

        private void HSBackbutton_Click(object sender, EventArgs e)
        {
            HighscorePanel.Visible = false;
            MenuPanel.Visible = true;
        }

        private void sqlSendButton_Click(object sender, EventArgs e)
        {
            CreateTable.Program program = new CreateTable.Program();
            string nameSend = HSNameBox.Text.ToString();

            program.SQLConnect(nameSend, totalScore);

        }
    }
}