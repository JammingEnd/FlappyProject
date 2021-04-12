using System;
using System.Drawing;
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
        private int totalScore = 0; //bginning value of the totalscore

        /// <summary>
        /// on application load, loads all the default values for the application
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            SQLReader(); //call the SQL class and datatable
            FlappyBird.BringToFront();

            this.DoubleBuffered = true;
            MiscStart();
            Start();
            StartupHeight();
        }

        private void Start()
        {
            pipeTop1.Visible = false;
            PipeBottom1.Visible = false;
            HighscorePanel.Visible = false;
            HSNameBox.Text = null;
            GOText.Visible = false;
            currentScore.Visible = false;
            menuScore.Visible = false;
            KeyPreview = true;
            lifeLabel.Text = "lives:" + startingLives.ToString();
            healthbar.Maximum = startingLives;
            healthbar.Minimum = 0;
            healthbar.Value = healthbar.Maximum;
            MenuPanel.Visible = true;
            timer1.Enabled = false;
            birdTimer.Enabled = false;
        }

        /// <summary>
        /// void for miscellaneous, edits the button borders and style
        /// </summary>
        private void MiscStart()
        {
            StartButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            HSButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            HSBackbutton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            ExitButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            sqlSendButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            StartButton.FlatAppearance.BorderSize = 0;
            HSButton.FlatAppearance.BorderSize = 0;
            HSBackbutton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.BorderSize = 0;
            sqlSendButton.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// void for the database
        /// </summary>
        private void SQLReader()
        {
            CreateTable.Program program = new CreateTable.Program();
            program.MReaderMain();
            dataGridView1.DataSource = program.dtscore;
        }

        private Random h = new Random(); //random height
        private Random betweenRandom = new Random(); //random space between the pipes
        //  private Random offRandom = new Random(); //pipe offset

        /// <summary>
        /// gives the pipes a random height upon load
        /// </summary>
        private void StartupHeight()
        {
            pipe2.Height = h.Next(100, 300);//random value between the entered numbers
            pipe1.Top = pipe2.Bottom + betweenRandom.Next(150, 250);
            pipe4.Height = h.Next(100, 300);//random value between the entered numbers
            pipe5.Top = pipe4.Bottom + betweenRandom.Next(150, 250);
            pipeTop1.Height = h.Next(100, 300);//random value between the entered numbers
            PipeBottom1.Top = pipeTop1.Bottom + betweenRandom.Next(150, 250);
        }

        /// <summary>
        /// main engine of the game. controls the speed and Updates other void.
        /// its like the Update method from unity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            movepipe(gameSpeed);
            gameOver();
            speedUp();
            //addPoints();  //code redirected, its staying because i can show how i did it before
        }

        /// <summary>
        /// this code moves the pipes, speed is pixels in this case
        /// </summary>
        /// <param name="speed"></param>
        private void movepipe(int speed)
        {
            if (pipe1.Left >= 0) //bottom pipe
            { pipe1.Left += -speed; }
            else
            {
                pipe1.Left = 1770;
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (pipe5.Left >= 0) //bottom pipe
            { pipe5.Left += -speed; }
            else
            {
                pipe5.Left = 1770;
                score = score + 1;
                currentScore.Text = "Score:" + score.ToString();
            }
            if (PipeBottom1.Left >= 0) //bottom pipe
            { PipeBottom1.Left += -speed; }
            else
            {
                PipeBottom1.Left = 1770;
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
                //  pipe2.Left = 1800 + offRandom.Next(0, 150); //this offsets the horizontal distance between the pipes, it causes issues overtime.
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
                //  pipe4.Left = 1800 + offRandom.Next(0, 150); //this offsets the horizontal distance between the pipes, it causes issues overtime.
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
                //  pipeTop1.Left = 1800 + offRandom.Next(0, 150); //this offsets the horizontal distance between the pipes, it causes issues overtime.
            }
        }

        /// <summary>
        /// increases the gamespeed every set of tableOf
        /// </summary>
        private void speedUp()
        {
            if (score == 9 || score == 10)
            {
                tableOf = 15;
            }
            if (score == tableOf)
            {
                gameSpeed = gameSpeed + 1;
                tableOf = tableOf + 5;
                currentScore.Text = "speed up!";
            }
        }

        //failed code

        #region addpoints [decapretated]

        /// <summary>
        /// adds a point every time a pipe reaches 0
        /// </summary>
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

        /// <summary>
        /// handels the part when you intersect come in contact with a pipe.
        /// </summary>
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
            //the above code handles the first 2 pipes in the game to be invisible.

            //when i contact with a pipe or too high or low, it resets most aspects of the game
            if ((FlappyBird.Bounds.IntersectsWith(pipe1.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe2.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe5.Bounds)) || (FlappyBird.Bounds.IntersectsWith(pipe4.Bounds)) || FlappyBird.Top == 660 || FlappyBird.Top == 0 || intersectsWithBottom || intersectsWithTop)
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
                totalScore = totalScore + score; //at the end of your run, set totalscore to add your current score.
                menuScore.Text = "Total score:" + totalScore.ToString();
                HSButton.Enabled = true;

                Reset();
            }
        }

        /// <summary>
        /// places all the pipes in the default position.
        /// </summary>
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

        /// <summary>
        /// when youre out of lives, the rest of the game resets
        /// </summary>
        private void LifeReset()
        {
            if (startingLives == 0)
            {
                startingLives = defaultLives;
                totalScore = 0;
            }
        }

        /// <summary>
        /// exit the application
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// initiates the game
        /// </summary>
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

        /// <summary>
        /// jump little bird, JUMP. when space is pressed tho
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (HighscorePanel.Visible == false && MenuPanel.Visible == false)
            {
                if (e.KeyCode == Keys.Space)
                {
                    FlappyBird.Top += -flappyJumpSpeed;
                }
            }
        }

        /// <summary>
        /// independed timer for flappy birds jumps
        /// </summary>
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (FlappyBird.Top <= 655)
                FlappyBird.Top += 5;
        }

        //region for accidental voids

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

        /// <summary>
        /// shows the highscore panel and hides the main menu
        /// </summary>
        private void HSButton_Click(object sender, EventArgs e)
        {
            HighscorePanel.Visible = true;
            MenuPanel.Visible = false;

            HSNameBox.Text = "";
            HSscoreViewer.Text = "Current Score: " + totalScore.ToString();
            StartButton.Enabled = false;
        }

        /// <summary>
        /// highscore button for leaving the panel
        /// </summary>
        private void HSBackbutton_Click(object sender, EventArgs e)
        {
            HighscorePanel.Visible = false;
            MenuPanel.Visible = true;
            StartButton.Enabled = true;
        }

        /// <summary>
        /// send the name and score to the Database class
        /// </summary>
        private void sqlSendButton_Click(object sender, EventArgs e)
        {
            if (startingLives != 0)
            {
                HSNameBox.Text = "0 lives required for leaderboard";

                return;
            }

            CreateTable.Program program = new CreateTable.Program();
            string nameSend = HSNameBox.Text;

            if (nameSend != "")
            {
                program.SQLConnect(nameSend, totalScore);

                HSNameBox.Text = "Scores Send!!!";
            }
            else if (nameSend == "" || nameSend == null)
            {
                HSNameBox.Text = "Insert a name!";
                if (nameSend != "" || nameSend != null)
                {
                    HSNameBox.Text = "";
                }
            }
        }

        private void PipeBottom1_Click(object sender, EventArgs e)
        {

        }
    }
}